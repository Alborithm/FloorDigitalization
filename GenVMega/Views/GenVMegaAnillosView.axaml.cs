using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.GenVMega.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;
using FloorDigitalization.Static;

namespace FloorDigitalization.GenVMega.Views;

public partial class GenVMegaAnillosView : UserControl
{
    public GenVMegaAnillosView()
    {
        InitializeComponent();
        DataContext = new GenVMegaAnillosViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem(StaticFields.isPared ? "Anillos 131" : "Anillos 128", 
            StaticFields.isPared ? "Gen V Mega | Anillos 131 Pared" : "Gen V Mega | Anillos 128 Pasillo",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(anillosDcps, "First","Gage\nG-6387-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem(StaticFields.isPared ? "Anillos 132" : "Anillos 144", 
            StaticFields.isPared ? "Gen V Mega | Anillos 132 Pared" : "Gen V Mega | Anillos 144 Pasillo", 
            RecordNumber.Second, 
            DcpControlCreator.CreateGrid(anillosDcps, "Second","Gage\nG-6387-XX")));
    }

    private List<Dcp> anillosDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "Calibrar los gages ",
            Gage = "De acuerdo a instructivo",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp133", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "133",
            Description = "Localización a la cuarta ranura 12.39 ",
            BoldDescription = "± 0.15 mm",
            Gage = "23",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp134", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "134",
            Description = "Localización a la novena ranura 44.84 ",
            BoldDescription = "± 0.15 mm",
            Gage = "23",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp8", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "8",
            Description = "Diámetro exterior de ranuras 2x 192.56 ",
            BoldDescription = "± 0.30 mm",
            Gage = "19",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp11", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "11",
            Description = "Run out radial ",
            BoldDescription = "↗ | 0.35 | A | B ",
            Gage = "23",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp130", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "130",
            Description = "Altura total de anillo 65.0 ",
            BoldDescription = "± 0.25 mm",
            Gage = "17",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp160", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "160",
            Description = "Localización del Sine 33.92 ",
            BoldDescription = "± 0.05 mm",
            Gage = "21",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp132", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "132",
            Description = "Diámetro interior 2x 171 ",
            BoldDescription = "± 0.05 mm",
            Gage = "20",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp10", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "10",
            Description = "Diámetro exterior de anillo 3x197.56 ",
            BoldDescription = "± 0.25",
            Gage = "17",
            Sample = "1",
            InspectFrequency = "Cada 30 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp131", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "131",
            Description = "Run out de la cara del anillo ",
            BoldDescription = "↗ | 0.1 | A ",
            Gage = "23",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp77_161", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "77\n161",
            Description = "Condicion visual de acuerdo a la ayuda visual (AV-1154) y porosidad de acuerdo a ayuda visual (AV-1155)",
            Gage = "Visual\nPara verificar piezas sospechosas de poros usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };
}