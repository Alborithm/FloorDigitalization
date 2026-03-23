using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.GenVPrincipal.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.GenVPrincipal.Views;

public partial class GenVPrincipalMazasEnsambleView : UserControl
{
    public GenVPrincipalMazasEnsambleView()
    {
        InitializeComponent();
        DataContext = new GenVPrincipalMazasEnsambleViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        // Change description of the gage to G-1019-XX
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Mazas", 
            "Gen V Principal  | Mazas",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(mazasDcps, "First", "Gage\nG-1012-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ensamble", 
            "Gen V Principal | Ensamble",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(ensambleDcps, "Second", "Gage\nG-1019-XX")));
    }

    private List<Dcp> mazasDcps = new List<Dcp>()
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
        new Dcp(code: "DcpSn02", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "Espesor de pared de maza 4.50 ± 0.8 ",
            Gage = "03",
            Sample = "1",
            InspectFrequency = "Cada 50 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp174", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "174",
            Description = "Diámetro exterior de sine lock 2 x Ø 157.1 ",
            BoldDescription = "± 0.10 mm",
            Gage = "17",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp172", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "172",
            Description = "Localización del sine 33.93 ",
            BoldDescription = "± 0.05 mm",
            Gage = "17",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp173", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "173",
            Description = "Altura total de sine lock 65.0 ",
            BoldDescription = "± 0.25 mm",
            Gage = "17",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp42_Ip", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "42\nIP",
            Description = "Diámetro interior en proceso 35.5 ",
            BoldDescription = "± 0.25 mm",
            Gage = "40",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp25_Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "25\nIP",
            Description = "Altura de back face en proceso 36 ",
            BoldDescription = "± 0.5 mm",
            Gage = "G-1012-41",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp77_161", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "77\n161",
            Description = "Condición visual de acuerdo a la ayuda visual (AV-1154) y porosidad de acuerdo a ayuda visual (AV-1155) ",
            Gage = "Visual\nPara verificar piezas sospechosas de poros usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> ensambleDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp76", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "76",
            Description = "El hule no debera sobresalir mas de 2.5 o estar hundido mas de 3.0 ",
            Gage = "Visual\nNota: Piezas dudosas usar gage 16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true,
        },
    };
}