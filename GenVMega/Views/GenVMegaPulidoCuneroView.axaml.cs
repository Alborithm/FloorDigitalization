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

public partial class GenVMegaPulidoCuneroView : UserControl
{
    public GenVMegaPulidoCuneroView()
    {
        InitializeComponent();
        DataContext = new GenVMegaPulidoCuneroViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Cuñero", 
            "Gen V Mega | Cuñero",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(cuneroDcps, "First", "Gage\nG-6387-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Pulido", 
            "Gen V Mega | Pulido",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(pulidoDcps, "Second", "Gage\nG-6387-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Prelavadora", 
            "Gen V Mega | Prelavadora",
            RecordNumber.Third,
            DcpControlCreator.CreateGridPrelavadora(prelavadoraDcps, "Third", new Dictionary<int, string>
            {
                {1, "Prelavadora"},
            })));
    }

    private List<Dcp> cuneroDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp47",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "47",
            Description = "Ancho de cuñero 4.83 ± 0.03 mm",
            Gage = "40",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp50_48",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "50\n48",
            Description = "Distancia 40.82 ± .01m Posición verdadera de cuñero \n | ⊕ | 0.03 | Ⓜ | A | Ⓜ | B |",
            Gage = "41",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp36",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "36",
            Description = "Diametro interior MIN 37.600 - MAX 37.625",
            Gage = "G-1012-36",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn_77",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n77",
            Description = "Condicion del cuñero: \n 1. Posición correcta entre los dos brazos de la maza \n 2. Solo un cuñero \n3. Cuñero sin rebaba",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Cada hora",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp77_161",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "77\n161",
            Description = "Condición visual de acuerdo a la ayuda visual (AV-1154) y porosidad de acuerdo a ayuda visual (AV-1155) ",
            Gage = "Visual\nPara verificar piezas sospechosas de poros uar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "Cada hora",
            IsCheckBox = true,
        },
    };

    private List<Dcp> pulidoDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp19",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "19",
            Description = "Distancia minima de bruñido 21.25 MIN",
            Gage = "G-1012-31",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp20",inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "20",
            Description = "Rugosidad del area de sello ",
            BoldDescription = "Ra MIN 0.25 - MAX 0.8",
            Gage = "RDC-006",
            Sample = "1",
            InspectFrequency = "Cada hora",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn_10", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n10",
            Description = "Verificar la presencia de bruñido en toda el area de sello ",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Cada hora",
            IsCheckBox = true,
        },
    };

    private List<LavadoraDcp> prelavadoraDcps = new List<LavadoraDcp>()
    {
        new LavadoraDcp(code: "Alcalinidad", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Alcalinidad total",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "7-10",
        },
        new LavadoraDcp(code: "Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Temperatura",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "40°C - 55°C",
        },
        new LavadoraDcp(code: "Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Nivel de tanque",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Gage = "NA",
            Sample = "NA",
            Parametro = "dentro del rango marcado por la linea verde",
        },
    };
}