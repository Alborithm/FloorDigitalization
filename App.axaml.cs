using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Views;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Core;
using FloorDigitalization.GenVPrincipal.ViewModels;
using FloorDigitalization.GenVMega.ViewModels;
using FloorDigitalization.GenVMini.ViewModels;
using FloorDigitalization.L625.ViewModels;
using FloorDigitalization.Dk68.ViewModels;
using FloorDigitalization.Duramax.ViewModels;
using FloorDigitalization.Multilinea.ViewModels;

namespace FloorDigitalization;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // If you use CommunityToolkit, line below is needed to remove Avalonia data validation.
        // Without this line you will get duplicate validations from both Avalonia and CT
        BindingPlugins.DataValidators.RemoveAt(0);

        //Add logging
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        
        var collection = new ServiceCollection();
        collection.AddSingleton<MainWindowViewModel>();
        collection.AddTransient<L625PostmaqViewModel>();
        collection.AddTransient<L625BalanceoInspeccionViewModel>();
        collection.AddTransient<GenVPrincipalAnillosViewModel>();
        collection.AddTransient<GenVPrincipalMazasEnsambleViewModel>();
        collection.AddTransient<GenVPrincipalPostmaqCuneroPulidoViewModel>();
        collection.AddTransient<GenVPrincipalBalanceoPinturaViewModel>();
        collection.AddTransient<GenVMegaPostmaqViewModel>();
        collection.AddTransient<GenVMegaMazasEnsambleViewModel>();
        collection.AddTransient<GenVMegaAnillosViewModel>();
        collection.AddTransient<GenVMegaPulidoCuneroViewModel>();
        collection.AddTransient<GenVMegaBalanceoPinturaViewModel>();
        collection.AddTransient<GenVMiniAnillosViewModel>();
        collection.AddTransient<GenVMiniMazasEnsambleViewModel>();
        collection.AddTransient<GenVMiniPostmaqViewModel>();
        collection.AddTransient<GenVMiniPulidoCuneroBalanceoViewModel>();
        collection.AddTransient<Dk68EnsambleLavadoraViewModel>();
        collection.AddTransient<Dk68MuescaBalanceoLavadoraViewModel>();
        collection.AddTransient<Dk68PintadoEstampadoInspeccionViewModel>();
        collection.AddTransient<Dk68EpcViewModel>();
        collection.AddTransient<Duramax10w20w25wViewModel>();
        collection.AddTransient<Duramax30W40WViewModel>();
        collection.AddTransient<MultilineaPC1ViewModel>();

        var services = collection.BuildServiceProvider();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();
            desktop.MainWindow = new MainWindow
            {
                DataContext = services.GetRequiredService<MainWindowViewModel>()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}