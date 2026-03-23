using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.GenVMini.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.GenVMini.Views;

public partial class GenVMiniAnillosView : UserControl
{
    public GenVMiniAnillosView()
    {
        InitializeComponent();
        DataContext = new GenVMiniAnillosViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        // Change description of the gage to G-1019-XX
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Anillos PTN-111", 
            "Gen V Mini | Anillos PTN-111",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(anillosDcps, "First", "Gage\nG-1019-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Anillos PTN-112", 
            "Gen V Mini | Anillos PTN-112",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(anillosDcps, "Second", "Gage\nG-1019-XX")));
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
            Description = "Localización a la cuarta ranura 14.54 ",
            BoldDescription = "± 0.15 mm",
            Gage = "11",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp134", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "134",
            Description = "Localización a la novena ranura 46.84 ",
            BoldDescription = "± 0.15 mm",
            Gage = "11",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp8", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "8",
            Description = "Diámetro exterior de ranuras 2x 192.56 ",
            BoldDescription = "± 0.30 mm",
            Gage = "09",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp11", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "11",
            Description = "Run out radial ",
            BoldDescription = "↗ | 0.35 | A | B ",
            Gage = "12",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp130", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "130",
            Description = "Altura total de anillo 65.0 ",
            BoldDescription = "± 0.25 mm",
            Gage = "10",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp160", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "160",
            Description = "Localización del Sine 33.92 ",
            BoldDescription = "± 0.05 mm",
            Gage = "14",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp132", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "132",
            Description = "Diámetro interior 2x 171 ",
            BoldDescription = "± 0.05 mm",
            Gage = "13",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp10", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "10",
            Description = "Diámetro exterior de anillo 3x197.56 ",
            BoldDescription = "± 0.25",
            Gage = "10",
            Sample = "1",
            InspectFrequency = "Cada 30 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp131", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "131",
            Description = "Run out de la cara del anillo ",
            BoldDescription = "↗ | 0.1 | A ",
            Gage = "12",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn02", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN",
            Description = "Presencia de ranuras",
            Gage = "PY-209",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = true,
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