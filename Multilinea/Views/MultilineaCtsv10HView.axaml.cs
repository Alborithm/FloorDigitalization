using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Multilinea.Views;

public partial class MultilineaCtsv10HView : UserControl
{
    public MultilineaCtsv10HView()
    {
        InitializeComponent();
        DataContext = new MultilineaCtsv10HViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("CTSV 010H", 
            "Multilinea | CTSV | PTN-117 | 010H ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op10w20wDcps, "First")));
    }

    // TODO replace with the Multilinea 10H CTSV DAta

    private List<Dcp> op10w20wDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN",
            Description = "CALIBRAR LOS GAGES ",
            Gage = "DE ACUERDO A INSTRUCTIVO",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp1Ip1", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1IP",
            Description = "DISTANCIA A LAS RANURAS 16.87 ",
            BoldDescription = "± 0.15 ",
            PostDescription = "\nCARA#1",
            Gage = "G-1005-20",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp1Ip2", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1IP",
            Description = "DISTANCIA A LAS RANURAS 16.87 ",
            BoldDescription = "± 0.15 ",
            PostDescription = "\nCARA#2",
            Gage = "G-1005-20",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp6", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "6",
            Description = "DIAMETRO EXTERIOR DE LA CARA DEL ANILLO Ø 185.9 ",
            BoldDescription = "± 0.25 ",
            Gage = "G-1005-02",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp7", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "7",
            Description = "DIAMETRO EXTERIOR DE RANURAS Ø 180.99 ",
            BoldDescription = "± 0.4 ",
            Gage = "G-1005-13",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp94", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "94",
            Description = "PERFIL ",
            BoldDescription = "⌓ | 0.6 | E | F ",
            Gage = "G-1005-21",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp101", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "101",
            Description = "ALTURA TOTAL 37.3 ",
            BoldDescription = "± 0.20",
            Gage = "G-1005-02",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp102Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "102IP",
            Description = "PARALELISMO ",
            BoldDescription = "// | 0.1 | E | F",
            Gage = "G-1005-02",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp60", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "60",
            Description = "SIN BORDES AFILADOS ENTRE LOS PUNTOS J Y K ",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> estampadoDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp24", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "24",
            Description = @"Estampado Legible
ESTAMPADO:
12692644 + DÍA JULIANO+ AÑO+ TURNO
NO DEBE DE ESTAR CERCA DE BARRENOS DE BALANCEO  12692644+XXX+A+T
ESCRIBIR NUMERO EN EL RECUADRO ",
            BoldDescription = "\n12692644 NUMERO DE PARTE / XXX DIA JULIANO/ X AÑO / X TURNO",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp74_80", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "74\n80",
            Description = "CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDAD DE ACUERDO A AYUDA VISUAL (AV-1155 / AV-727)",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN",
            Description = "PRESENCIA DE RAUNRAS",
            Gage = "PY 241",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
        },
    };

}