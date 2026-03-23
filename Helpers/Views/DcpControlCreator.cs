using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Avalonia.Styling;
using FloorDigitalization.Enums;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.L625.ViewModels;
using FloorDigitalization.L625.Views;
using FloorDigitalization.ViewModels;


namespace FloorDigitalization.Helpers.Views;

public static  class DcpControlCreator
{
    public static Grid CreateGrid(List<Dcp> dcps)
    {
        throw new NotImplementedException("This method is deprecated, use method with bindingSufix paramenter");
    }
    public static Grid CreateGrid(List<Dcp> dcps, string _bindingSufix, string headerGage = "Técnica de mecición")
    {
        string bindingSufix = _bindingSufix;
        var grid = new Grid()
        {
            ShowGridLines = false,
        };
        
        // Columns
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(80)));
        grid.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Star));
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(150)));
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(80)));
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(200)));
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(200)));
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(150)));
        
        grid.RowDefinitions.Add(new RowDefinition(GridLength.Auto));

        int row = 0;
        CreateStandardHeaders(grid, row, headerGage);
        row++;

        foreach (var item in dcps)
        {
            // Rows
            int totalRows = item.InputPerTurn * (item.HasStart ? 1 : 0) +
                            item.InputPerTurn * (item.HasMid ? 1 : 0) +
                            item.InputPerTurn * (item.HasEnd ? 1 : 0) ; // This is due top the Header

            totalRows = totalRows == 0 ? 1 : totalRows;
            
            for (int i = 0; i < totalRows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition(GridLength.Auto));
            }

            var control = CreateBorder(CreateTextBlock(item.Code));
            
            Grid.SetColumn(control, 0);
            Grid.SetRow(control, row);
            Grid.SetRowSpan(control, totalRows);
            grid.Children.Add(control);

            control = CreateBorder(CreateTextBlock(item.Description, item.BoldDescription, item.PostDescription));
            Grid.SetColumn(control, 1);
            Grid.SetRow(control, row);
            Grid.SetRowSpan(control, totalRows);
            grid.Children.Add(control);

            control = CreateBorder(CreateTextBlock(item.Gage));
            Grid.SetColumn(control, 2);
            Grid.SetRow(control, row);
            Grid.SetRowSpan(control, totalRows);
            grid.Children.Add(control);

            control = CreateBorder(CreateTextBlock(item.Sample));
            Grid.SetColumn(control, 3);
            Grid.SetRow(control, row);
            Grid.SetRowSpan(control, totalRows);
            grid.Children.Add(control);

            control = CreateBorder(CreateTextBlock(item.InspectFrequency));
            Grid.SetColumn(control, 4);
            Grid.SetRow(control, row);
            Grid.SetRowSpan(control, totalRows);
            grid.Children.Add(control);

            // one per row

            // string propertyPath = (DataContext as MainWindowViewModel)?.Balanceo.GetType().GetProperties()[row * 3 + 0].Name ?? "";
            if (item.DcpValues != null && item.DcpValues.Count > 0)
            {
                foreach (string phase in new string[]{"Start","Mid","End","Any"})
                {
                    if( item.Code == "SN\n34")
                    {
                        Console.WriteLine("Debuging");
                    }
                    var Values =   item.DcpValues.Where<string>(v => v.Contains(phase));
                    for(int i = 0 ; i < Values.Count() ; i++)
                    {
                        var value = Values.ElementAt(i);


                        // Frequencies
                        control = CreateBorder(CreateTextBlock(value.Contains("Start") ? "Inicio de turno" :
                                                  value.Contains("Mid") ? "Mitad de turno" :
                                                  value.Contains("End") ? "Final de turno" :
                                                  value.Contains("Any") ? "" : ""));
                        Grid.SetColumn(control, 5);
                        Grid.SetRow(control, row);
                        grid.Children.Add(control);

                        // Panel for holding the input control and the NT indicator
                        Panel inputPanel = new Panel();

                        Control inputControl;
                        if (item.IsCheckBox)
                        {
                            inputControl = CreateCheckBox($"{bindingSufix}Record.{value}", bindingSufix, phase);
                        }
                        else
                        {
                            inputControl = CreateNumeric($"{bindingSufix}Record.{value}", bindingSufix, phase);
                            // For some reason this is bugged since it shows a data validation error when inputting decimals
                            // inputControl = CreateNumeric($"{item.ParentName}.{value}", item.ParentName, phase);
                        }
                        // Style for when hidding the input
                        string inputClassName = $"inputNt{phase}Class";
                        inputControl.Styles.Add(new Style()
                        {
                            Setters =
                            {
                                new Setter(Visual.IsVisibleProperty, false),
                            }
                        });
                        inputControl.Styles.Add(new Style(x => x.Class(inputClassName))
                        {
                            Setters =
                            {
                                new Setter(Visual.IsVisibleProperty, true),
                            }
                        });
                        inputControl.Classes.Add(inputClassName);
                        inputControl.BindClass(inputClassName, new Avalonia.Data.Binding($"{bindingSufix}NtOff{phase}")
                        {
                            Mode = Avalonia.Data.BindingMode.TwoWay,
                        }, anchor: false);

                        inputPanel.Children.Add(inputControl);

                        // NT TextBlock indicator for when nt is active

                        TextBlock ntTextBlock = new TextBlock
                        {
                            Text = "NT",
                            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                            Margin = new Thickness(5,5,5,5),
                        };
                        ntTextBlock.Styles.Add( new Style()
                        {
                            Setters =
                            {
                                new Setter(TextBlock.IsVisibleProperty, true),
                            }
                        });
                        ntTextBlock.Styles.Add(new Style(x => x.OfType<TextBlock>().Class("ntActiveTextClass"))
                        {
                            Setters =
                            {
                                new Setter(TextBlock.IsVisibleProperty, false),
                            }
                        });
                        ntTextBlock.Classes.Add($"ntActiveTextClass");
                        ntTextBlock.BindClass("ntActiveTextClass", new Binding($"{bindingSufix}NtOff{phase}")
                        {
                            Mode = BindingMode.TwoWay,
                        }, anchor: true);
                        inputPanel.Children.Add(ntTextBlock);

                        var border = CreateBorder(inputPanel);
                        Grid.SetColumn(border, 6);
                        Grid.SetRow(border, row);

                        grid.Children.Add(border);
                        row++;
                    }
                }

            }
            else
            {
                throw new ArgumentException("DcpValues is null or empty");
            }
        }

        return grid;
    }

    public static Grid CreateGridPrelavadora(List<LavadoraDcp> dcps, string _bindingSufix, Dictionary<int,string> sectionRows)
    {
        string bindingSufix = _bindingSufix;
        var grid = new Grid()
        {
            ShowGridLines = false,
        };

        grid.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Star)); // Descripcion
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(200))); // Parametro
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(200))); // Frecuencia
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(150))); // Registro
        grid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(150))); // Valor

        int row = 0;

        grid.RowDefinitions.Add(new RowDefinition(GridLength.Auto));
        string[] headers = {"Descripción", "Parametro", "Frecuencia", "Registro", "Valor"};
        int col = 0;
        foreach (string header in headers)
        {
            var textBlock = new TextBlock
                {
                    Text = header
                };
            textBlock.Classes.Add("HeaderText");
            var control = new Border
            {
                Child = textBlock
            };
            control.Classes.Add("HeaderBorder");

            Grid.SetColumn(control, col);
            Grid.SetRow(control, row);
            grid.Children.Add(control);
            col++;
        }

        row++;

        foreach (var item in dcps)
        {
            // Add row for different sections in the washer e.g. prelavadora, tina 1, tina 2
            if(sectionRows.Keys.Contains(row))
            {
                grid.RowDefinitions.Add(new RowDefinition(GridLength.Auto));
                var divider = CreateBorder(CreateTextBlock(sectionRows[row]));
                divider.Classes.Add("BorderDivider");

                Grid.SetColumn(divider, 0);
                Grid.SetRow(divider, row);
                Grid.SetColumnSpan(divider, 5);
                grid.Children.Add(divider);
                row++;
            }

            // Rows
            int totalRows = item.InputPerTurn * (item.HasStart ? 1 : 0) +
                            item.InputPerTurn * (item.HasMid ? 1 : 0) +
                            item.InputPerTurn * (item.HasEnd ? 1 : 0) ; // This is due top the Header
            
            for (int i = 0; i < totalRows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition(GridLength.Auto));
            }

            // Description
            var control = CreateBorder(CreateTextBlock(item.Description, item.BoldDescription, item.PostDescription));
            
            Grid.SetColumn(control, 0);
            Grid.SetRow(control, row);
            Grid.SetRowSpan(control, totalRows);
            grid.Children.Add(control);

            // Parametro
            control = CreateBorder(CreateTextBlock(item.Parametro));
            Grid.SetColumn(control, 1);
            Grid.SetRow(control, row);
            Grid.SetRowSpan(control, totalRows);
            grid.Children.Add(control);

            // Frecuencia
            control = CreateBorder(CreateTextBlock(item.InspectFrequency));
            Grid.SetColumn(control, 2);
            Grid.SetRow(control, row);
            Grid.SetRowSpan(control, totalRows);
            grid.Children.Add(control);

            // one per row

            // string propertyPath = (DataContext as MainWindowViewModel)?.Balanceo.GetType().GetProperties()[row * 3 + 0].Name ?? "";
            if (item.DcpValues != null && item.DcpValues.Count > 0)
            {
                foreach (string phase in new string[]{"Start","Mid","End"})
                {
                    var Values =   item.DcpValues.Where<string>(v => v.Contains(phase));
                    for(int i = 0 ; i < Values.Count() ; i++)
                    {
                        var value = Values.ElementAt(i);


                        // Registro
                        control = CreateBorder(CreateTextBlock(value.Contains("Start") ? "Inicio de turno" :
                                                  value.Contains("Mid") ? "Mitad de turno" :
                                                  value.Contains("End") ? "Final de turno" : ""));
                        Grid.SetColumn(control, 3);
                        Grid.SetRow(control, row);
                        grid.Children.Add(control);

                        // Panel for holding the input control and the NT indicator
                        Panel inputPanel = new Panel();

                        Control inputControl;
                        if (item.IsCheckBox)
                        {
                            inputControl = CreateCheckBox($"{bindingSufix}Record.{value}", bindingSufix, phase);
                        }
                        else
                        {
                            inputControl = CreateNumeric($"{bindingSufix}Record.{value}", bindingSufix, phase);
                            // For some reason this is bugged since it shows a data validation error when inputting decimals
                            // inputControl = CreateNumeric($"{item.ParentName}.{value}", item.ParentName, phase);
                        }
                        // Style for when hidding the input
                        string inputClassName = $"inputNt{phase}Class";
                        inputControl.Styles.Add(new Style()
                        {
                            Setters =
                            {
                                new Setter(Visual.IsVisibleProperty, false),
                            }
                        });
                        inputControl.Styles.Add(new Style(x => x.Class(inputClassName))
                        {
                            Setters =
                            {
                                new Setter(Visual.IsVisibleProperty, true),
                            }
                        });
                        inputControl.Classes.Add(inputClassName);
                        inputControl.BindClass(inputClassName, new Avalonia.Data.Binding($"{bindingSufix}NtOff{phase}")
                        {
                            Mode = Avalonia.Data.BindingMode.TwoWay,
                        }, anchor: false);

                        inputPanel.Children.Add(inputControl);

                        // NT TextBlock indicator for when nt is active

                        TextBlock ntTextBlock = new TextBlock
                        {
                            Text = "NT",
                            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                            Margin = new Thickness(5,5,5,5),
                        };
                        ntTextBlock.Styles.Add( new Style()
                        {
                            Setters =
                            {
                                new Setter(TextBlock.IsVisibleProperty, true),
                            }
                        });
                        ntTextBlock.Styles.Add(new Style(x => x.OfType<TextBlock>().Class("ntActiveTextClass"))
                        {
                            Setters =
                            {
                                new Setter(TextBlock.IsVisibleProperty, false),
                            }
                        });
                        ntTextBlock.Classes.Add($"ntActiveTextClass");
                        ntTextBlock.BindClass("ntActiveTextClass", new Binding($"{bindingSufix}NtOff{phase}")
                        {
                            Mode = BindingMode.TwoWay,
                        }, anchor: true);
                        inputPanel.Children.Add(ntTextBlock);

                        var border = CreateBorder(inputPanel);
                        Grid.SetColumn(border, 4);
                        Grid.SetRow(border, row);

                        grid.Children.Add(border);
                        row++;
                    }
                }

            }
            else
            {
                throw new ArgumentException("DcpValues is null or empty");
            }
        }

        return grid;
    }

    private static void CreateStandardHeaders(Grid grid, int row, string headerGage = "Técnica de mecición")
    {
        string[] headers = {"DCP", "Descripción", headerGage, "Muestra", "Frec. de inspección", "Frec. de registro", "Valor"};

        int i = 0;
        foreach (string header in headers)
        {
            var textBlock = new TextBlock
                {
                    Text = header
                };
            textBlock.Classes.Add("HeaderText");
            var control = new Border
            {
                Child = textBlock
            };
            control.Classes.Add("HeaderBorder");

            Grid.SetColumn(control, i);
            Grid.SetRow(control, row);
            grid.Children.Add(control);
            i++;
        }
        
    }

    private static Border CreateBorder(Control content)
    {   
        var control = new Border
        {
            Child = content,
        };

        control.Classes.Add("CellBorder");

        return control;
    }

    private static TextBlock CreateTextBlock(string text, string boldText = "", string postText = "")
    {
        TextBlock textBlock;
        if (!string.IsNullOrEmpty(boldText))
        {
            textBlock = new TextBlock
            {
                Inlines = new InlineCollection(),
            };
            textBlock.Inlines.Add(text);
            textBlock.Inlines.Add(new Run(boldText + " ")
            {
                FontWeight = Avalonia.Media.FontWeight.Bold
            });
            textBlock.Inlines.Add(postText);
        } 
        else
        {
            textBlock = new TextBlock
            {
                Text = text
            };
            
        }

        textBlock.Classes.Add("CellTextBlock");

        return textBlock;
    }

    private static TextBox CreateTextBox(string bindableProperty, string parent, string phase)
    {
        var binding = new Avalonia.Data.Binding(bindableProperty)
        {
            Mode = Avalonia.Data.BindingMode.TwoWay,
        };
        // Todo, get the Object name
        var enabledBinding = new Avalonia.Data.Binding($"{parent}{phase}Phase")
        {
            Mode = Avalonia.Data.BindingMode.TwoWay,
        };

        var textBox = new TextBox
        {
            Text = "",
            TextWrapping = Avalonia.Media.TextWrapping.Wrap,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
        };

        textBox.Bind(TextBox.TextProperty, binding);
        textBox.Bind(TextBox.IsEnabledProperty, enabledBinding);

        textBox.Classes.Add("InputTextBox");

        return textBox;
    }

    private static NumericUpDown CreateNumeric(string bindableProperty, string parent, string phase)
    {
        var binding = new Avalonia.Data.Binding(bindableProperty)
        {
            Mode = Avalonia.Data.BindingMode.TwoWay,
        };
        // Todo, get the Object name
        var enabledBinding = new Avalonia.Data.Binding($"{parent}{phase}Phase")
        {
            Mode = Avalonia.Data.BindingMode.TwoWay,
        };

        var numericUpDown = new NumericUpDown
        {
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            ShowButtonSpinner = false,
            AllowSpin = false,
            Increment = 0.001m,
        };

        numericUpDown.Bind(NumericUpDown.ValueProperty, binding);
        numericUpDown.Bind(NumericUpDown.IsEnabledProperty, enabledBinding);

        numericUpDown.Classes.Add("InputNumeric");

        return numericUpDown;        
    } 

    private static CheckBox CreateCheckBox(string bindableProperty, string parent, string phase)
    {

        var control = new CheckBox
        {
            IsChecked = false,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            Content = "OK",
        };

        var binding = new Avalonia.Data.Binding(bindableProperty)
        {
            Mode = Avalonia.Data.BindingMode.TwoWay,
        };
        control.Bind(CheckBox.IsCheckedProperty, binding);

        var enabledBinding = new Avalonia.Data.Binding($"{parent}{phase}Phase")
        {
            Mode = Avalonia.Data.BindingMode.TwoWay,
        };
        control.Bind(CheckBox.IsEnabledProperty, enabledBinding);

        return control;
    }

    public static TabItem CreateTabItem(string _header, string _title, RecordNumber _bindingPropertyName, Grid _dcpGrid)
    {
        string header = _header;
        string title = _title;
        string bindingPropertyName = _bindingPropertyName.ToString();
        Grid dcpGrid = _dcpGrid;

        var content = new Panel();
        var panelGrid = new Grid();
        panelGrid.RowDefinitions.Add(new RowDefinition(GridLength.Auto)); // Title
        panelGrid.RowDefinitions.Add(new RowDefinition(GridLength.Auto)); // Operator code input
        panelGrid.RowDefinitions.Add(new RowDefinition(GridLength.Star)); // DCP Grid (ScrollViewer) 
        panelGrid.RowDefinitions.Add(new RowDefinition(GridLength.Auto)); // Submit button

        var titleBorder = new Border
        {
            Background = new Avalonia.Media.SolidColorBrush(Avalonia.Media.Colors.ForestGreen),
            Margin = new Thickness(5),
            CornerRadius = new CornerRadius(10),
            Child = new TextBlock
            {
                Text = title,
                Margin = new Thickness(5),
                FontSize = 24,
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            },
        };

        Grid.SetRow(titleBorder, 0);
        panelGrid.Children.Add(titleBorder);

        Grid userGrid = new Grid();
        Grid.SetRow(userGrid, 1);
        panelGrid.Children.Add(userGrid);

        userGrid.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Auto)); // Label
        userGrid.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Auto)); // textbox
        userGrid.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Auto)); // Button
        userGrid.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Auto)); // textblock
        userGrid.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Star)); // White space
        userGrid.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Auto)); // NT button

        var nominaLabel = new Label
        {
            Content = "Codigo del operador:",
            Margin = new Thickness(5,0,5,0),
        };
        Grid.SetColumn(nominaLabel, 0);
        userGrid.Children.Add(nominaLabel);


        Binding nominaCommandBinding = new Binding("GetOperatorCommand")
        {
            Mode = BindingMode.OneWay,
        };
        Binding nominaTextBinding = new Binding($"{bindingPropertyName}User.Nomina")
        {
            Mode = BindingMode.TwoWay,
        };
        Binding userBinding = new Binding($"{bindingPropertyName}User")
        {
            Mode = BindingMode.TwoWay,
        };
        Binding ntCommandBinding = new Binding($"ToggleNoTrabajo{bindingPropertyName}Command")
        {
            Mode = BindingMode.OneWay,
        };

        var nominaInput = new TextBox
        {
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            Margin = new Thickness(5,0,5,0),
            // KeyBindings =
            // {
            //     new KeyBinding
            //     {
            //         Gesture = new Avalonia.Input.KeyGesture(Avalonia.Input.Key.Enter),
            //     }
            // }
        };
        var bind = nominaInput.Bind(KeyBinding.CommandProperty, nominaCommandBinding);
        nominaInput.Bind(TextBox.TextProperty, nominaTextBinding);


        // Trying to make work the key binding.

        // var keyBinding = new KeyBinding
        // {
        //     Gesture = new Avalonia.Input.KeyGesture(Avalonia.Input.Key.Enter),
        // };
        // keyBinding.Bind(KeyBinding.CommandProperty, nominaCommandBinding);
        // keyBinding.Bind(KeyBinding.CommandParameterProperty, userBinding);
        // nominaInput.KeyBindings.Add(keyBinding);
        // my old implementation on 11 02, this triggers the command that I created but in order to get to the vm logic seams like quite a workaround
        // nominaInput.KeyBindings.Add(new KeyBinding
        // {
        //     Gesture = new Avalonia.Input.KeyGesture(Avalonia.Input.Key.Enter),
        //     CommandParameter = "test",
        //     Command = new MyCommand(),
        //     // Command = nominaInput.DataContext is L625BalanceoInspeccionViewModel vm ? vm.GetOperatorCommand : null,
        // });
        // This does not work, seems like the binding is not working for some reason, maybe because the command is in the DataContext of the parent viewmodel and not the textbox, will have to investigate more on this
        // nominaInput.KeyBindings.First().Bind(KeyBinding.CommandProperty, nominaCommandBinding);

        Grid.SetColumn(nominaInput, 1);
        userGrid.Children.Add(nominaInput);
        
        var nominaButton = new Button
        {
            Content = "Aceptar",
            Margin = new Thickness(5,0,5,0),
        };
        nominaButton.Classes.Add("NominaButton");
        nominaButton.Bind(Button.CommandProperty, nominaCommandBinding);
        nominaButton.Bind(Button.CommandParameterProperty, userBinding);
        Grid.SetColumn(nominaButton, 2);
        userGrid.Children.Add(nominaButton);

        var userNameTextBlock = new TextBlock
        {
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            Margin = new Thickness(10,0,0,0),
        };
        userNameTextBlock.Bind(TextBlock.TextProperty, new Binding($"{bindingPropertyName}User.Name")
        {
            Mode = BindingMode.OneWay,
        });
        Grid.SetColumn(userNameTextBlock,3);
        userGrid.Children.Add(userNameTextBlock);

        var ntButton = new Button
        {
            Content = "Marcar como No Trabajo",
            // CommandParameter = _bindingPropertyName,
            // CommandParameter = new NoTrabajoParams
            // {
            //     ScreenName = _bindingPropertyName,
            //     Phase = "Start",
            // },
            Margin = new Thickness(5,0,5,0),
        };
        
        ntButton.Bind(Button.CommandProperty, ntCommandBinding);
        Grid.SetColumn(ntButton, 5);
        userGrid.Children.Add(ntButton);

        // ScrollViewer

        var scrollViewer = new ScrollViewer
        {
            Content = dcpGrid,
        };
        Grid.SetRow(scrollViewer, 2);
        panelGrid.Children.Add(scrollViewer);

        // Button for submitting
        // var submitButtonBinding = new Binding($"Save{bindingPropertyName}Command");
        var submitButtonBinding = new Binding($"Save{bindingPropertyName}Command");
        var submitButton = new Button
        {
            Content = "Registrar",
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            Margin = new Thickness(5),
            Padding = new Thickness(20,10,20,10),
            FontSize = 24,
            CommandParameter = ScreenNames.Balanceo, // Harcoded for now, will need to make it change depending on the screen.
        };
        submitButton.Bind(Button.CommandProperty, submitButtonBinding);

        Grid.SetRow(submitButton, 3);
        panelGrid.Children.Add(submitButton);

        content.Children.Add(panelGrid);

        var tabItem = new TabItem
        {
            Header = header,
            Content = content,
        };


        return tabItem;
    }

    public static void TestEnum(ScreenNames screenName)
    {
        Console.WriteLine("Testin Enum: " + screenName);
        Console.WriteLine("Testin Enum.ToStrin(): " + screenName.ToString());
        Console.WriteLine("Testin Enum.GetType().Name: " + screenName.GetType().Name);
    }
    // public class MyCommand : ICommand
    // {
    //     public event EventHandler? CanExecuteChanged;

    //     public bool CanExecute(object? parameter)
    //     {
    //         return true;
    //         // throw new NotImplementedException();
    //     }

    //     public void Execute(object? parameter)
    //     {
    //         Console.WriteLine("Command Executed:");
    //     }
    // }
}