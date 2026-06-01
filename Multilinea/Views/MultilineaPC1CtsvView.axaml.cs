using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Multilinea.Views;

public partial class MultilineaPC1CtsvView : UserControl
{
    public MultilineaPC1CtsvView()
    {
        InitializeComponent();
        DataContext = new MultilineaPC1CtsvViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 010W", 
            "Multilinea | Ctsv | PTN-117 | 010W ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op10wDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 020W", 
            "Multilinea | Ctsv | PTN-117 | 020W ",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(op20wDcps, "Second")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 010H", 
            "Multilinea | Ctsv | PTN-107 | 010H ",
            RecordNumber.Third,
            DcpControlCreator.CreateGrid(op10hDcps, "Third")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 020H", 
            "Multilinea | Ctsv | PTN-107 | 020H ",
            RecordNumber.Forth,
            DcpControlCreator.CreateGrid(op20hDcps, "Forth")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 020A", 
            "Multilinea | Ctsv | PPE-037 | 020A ",
            RecordNumber.Fifth,
            DcpControlCreator.CreateGrid(op20aDcps, "Fifth")));
    }

    // TODO replace with the Multilinea 10H CTSV Data

    private List<Dcp> op10wDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "CALIBRAR LOS GAGES ",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "INICIO Y MITAD DE TURNO ",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn51", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN\n51",
            Description = "CONCENTRICIDAD DEL ANILLO  ",
            BoldDescription = "| ◎ | 0.15 | A |",
            Gage = "CMM-001",
            Sample = "1",
            InspectFrequency = "CADA CAMBIO DE MODELO ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp119", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "87IP",
            Description = "DIAMTETRO EXTERNO DE ANILLO 194.070 ",
            BoldDescription = "± 0.25 mm",
            Gage = "G-1020-11",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        }
    };

    private List<Dcp> op20wDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "CALIBRACION DE GAGES",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "INICIO  Y MITAD DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp116", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "116",
            Description = "ALTURA TOTAL DE ANILLO 54.58 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm",
            Gage = "G-1020-33",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp118", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "118",
            Description = "ANILLO ID 161.3 ",
            BoldDescription = "± 0.08",
            PostDescription = "mm",
            Gage = "G-6397-47",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp127", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "127",
            Description = "LOCALIZACION DE SINE 21.28 ",
            BoldDescription = "± 0.05 ",
            PostDescription = "mm",
            Gage = "G-6397-50",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp79_156", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "79\n156",
            Description = "CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDADA DE ACUERDO A AYUDA VISUAL (AV-1155) ",
            Gage = "VISUAL\nPara verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> op10hDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "CALIBRACION DE GAGES",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "INICIO  Y MITAD DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp151", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "151",
            Description = "DIAMETRO EXTERIOR DE SINE LOCK 2x 149.40 ",
            BoldDescription = "± 0.18 ",
            PostDescription = "mm ",
            Gage = "G-6397-40",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp22Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "22IP",
            Description = "DIAMETRO EXTERIOR DE SELLO 57.00 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm",
            Gage = "G-1004-25",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp31Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "31IP",
            Description = "ALTURA DE BACK FACE 38.29 ",
            BoldDescription = "± 0.40 ",
            PostDescription = "mm",
            Gage = "G-6397-40",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp40Ip_1", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "40IP",
            Description = "NARIZ ID 36.1 ± 0.15 mm ",
            Gage = "G-1020-03",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp40Ip_2", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "40IP",
            Description = "NARIZ ID 36.1 ± 0.15 mm ",
            Gage = "G-1020-45",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp42Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "42IP",
            Description = "ALTURA DE MAMELON 22.75 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm ",
            Gage = "G-6397-13",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn4", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN4",
            Description = "ALTURA DE SINE LOCK 46.548 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm ",
            Gage = "G-6397-40",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
    };

    private List<Dcp> op20hDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "CALIBRACION DE GAGES",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "INICIO  Y MITAD DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn25", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN25",
            Description = "LIBERACION DE PESO EN MAZA 2500 gr.mm MAX.",
            Gage = "REFERENCIA AV-1125",
            Sample = "1",
            InspectFrequency = "INICIO,  MITAD Y FINAL DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp11Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "11IP",
            Description = "ALTURA TOTAL DE MAZA 121.595 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm",
            Gage = "G-6397-40",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp12Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "12IP",
            Description = "LOCALIZACION A LA 4TA RANURA 21.278 ",
            BoldDescription = "± 0.10",
            Gage = "G-6397-40",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp25", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "25",
            Description = "DIAMETRO DE LA 4TA RANURA 205.96 ",
            BoldDescription = "± 0.3 ",
            PostDescription = "mm",
            Gage = "G-6397-03",
            Sample = "1",
            InspectFrequency = "INSPECCION CADA 10 PZ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp26", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "26",
            Description = "DIAMETRO 211.95 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm",
            Gage = "G-6392-02",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp79_156", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "79\n156",
            Description = "CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDADA DE ACUERDO A AYUDA VISUAL (AV-1155) ",
            Gage = "VISUAL\nPara verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> op20aDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn15", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "SN15",
            Description = "ALTURA DE ANILLO ",
            BoldDescription = "± 0.10 ",
            PostDescription = "mm NOTA: MEDIR ALTURA EN 3 SECCIONES, (EN CADA UNO DE LOS BRAZOS DE LA MASA) ",
            Gage = "G-6397-06",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp78", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN78",
            Description = "PROTUBERANCIA DE HULE NO DEBE EXCEDER LOS 2MM O ESTAR HUNDIDO A MAS DE 2MM EN BASE A SUPERFICIES METALICAS",
            Gage = "VISUAL G-6401-00",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp79_156", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "79\n156",
            Description = "CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDADA DE ACUERDO A AYUDA VISUAL (AV-1155) ",
            Gage = "VISUAL\nPara verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };
}