using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Duramax.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Duramax.Views;

public partial class Duramax30W40WView : UserControl
{
    public Duramax30W40WView()
    {
        InitializeComponent();
        DataContext = new Duramax30W40WViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PCM-065 Cara 1", 
            "Duramax | PCM-065 | 30W Cara 1",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op30WCara1Dcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PCM-065 Cara 2", 
            "Duramax | PCM-065 | 30W Cara 2",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(op30WCara2Dcps, "Second")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PCM-066 Cara 1", 
            "Duramax | PCM-066 | 30W Cara 1",
            RecordNumber.Third,
            DcpControlCreator.CreateGrid(op30WCara1Dcps, "Third")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PCM-066 Cara 2", 
            "Duramax | PCM-066 | 30W Cara 2",
            RecordNumber.Forth,
            DcpControlCreator.CreateGrid(op30WCara2Dcps, "Forth")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PBL-035", 
            "Duramax | PBL-035 | 40W",
            RecordNumber.Fifth,
            DcpControlCreator.CreateGrid(op40WDcps, "Fifth")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PBL-014", 
            "Duramax | PBL-014 | 40W",
            RecordNumber.Sixth,
            DcpControlCreator.CreateGrid(op40WDcps, "Sixth")));
        
    }

    private List<Dcp> op30WCara1Dcps = new List<Dcp>()
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
        new Dcp(code: "Dcp1", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1",
            Description = "DISTANCIA ENTRE LA PRIMER RANURA A LA CUARTA RANURA. 10.95 ",
            BoldDescription = "±0.25",
            PostDescription = "\nPQC2",
            Gage = "G-1005-15",
            Sample = "1",
            InspectFrequency = "CADA 10 ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp2", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "2",
            Description = "DISTANCIA 21.9 ",
            BoldDescription = "±0.5",
            Gage = "G-1005-15",
            Sample = "1",
            InspectFrequency = "CADA 10 ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp13BIp", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "13 B\nIP",
            Description = "DIAMETRO INTERIOR SUPERIOR ",
            BoldDescription = "\nMAX Ø 154.865\nMIN Ø 154.665",
            PostDescription = "\nKPCI/KPC2 ",
            Gage = "G-1005-17",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp21", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "21",
            Description = "DIAMETRO DE BARRENOS 3X 11.0 ±0.25 ",
            Gage = "G-1005-08",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp22", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "22",
            Description = "POSICION VERDADERA DE BARRENOS\n| ⊕ | 0.1 | Ⓜ | A | B | Ⓜ |",
            Gage = "G-1005-07",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp31", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "31",
            Description = "DISTANCIA 8.95 ± 0.15",
            Gage = "G-1005-18",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp42A", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "42A",
            Description = "",
            BoldDescription = "RUN OUT RADIAL\nPQC4\n| ↗ | 0.25 | A | B |",
            Gage = "G-1005-15",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp43A", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "43A",
            Description = "",
            BoldDescription = "RUN OUT AXIAL\nPQC5\n| ↗ | 0.25 | C | D |",
            Gage = "G-1005-15",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp78", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "78",
            Description = "",
            BoldDescription = "PERFIL\nPQC1\n| ⌓ | 0.1 | A | x3",
            Gage = "G-1005-16",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp23", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "23",
            Description = "MAQUINADO DE BARRENOS LIBRE FILOS EN ESQUINAS",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp26", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "26",
            Description = "SPOT FACE DEBE ESTAR LIBRE DE REBABAS ALREDEDOR DEL AGUJERO",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp74_80", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "74\n80",
            Description = "CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDAD DE ACUERDO A AYUDA VISUAL (AV-1155 / AV-727)",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> op30WCara2Dcps = new List<Dcp>()
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
        new Dcp(code: "Dcp1", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1",
            Description = "DISTANCIA ENTRE LA PRIMER RANURA A LA CUARTA RANURA. 10.95 ",
            BoldDescription = "±0.25",
            PostDescription = "\nPQC2",
            Gage = "G-1005-15",
            Sample = "1",
            InspectFrequency = "CADA 10 ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp2", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "2",
            Description = "DISTANCIA 21.9 ",
            BoldDescription = "±0.5",
            Gage = "G-1005-15",
            Sample = "1",
            InspectFrequency = "CADA 10 ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp3", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "3",
            Description = "",
            BoldDescription = "PERFIL\nPQC3\n| ⌓ | 0.1 | A | x3",
            Gage = "G-1005-16",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp13BIp", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "13 B\nIP",
            Description = "DIAMETRO INTERIOR SUPERIOR ",
            BoldDescription = "\nMAX Ø 154.865\nMIN Ø 154.665",
            PostDescription = "\nKPCI/KPC2 ",
            Gage = "G-1005-17",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp30", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "30",
            Description = "DISTANCIA 8.95 ± 0.15 ",
            Gage = "G-1005-18",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp42B", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "42B",
            Description = "",
            BoldDescription = "RUN OUT RADIAL\nPQC4\n| ↗ | 0.25 | A | B |",
            Gage = "G-1005-15",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp43B", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "43B",
            Description = "",
            BoldDescription = "RUN OUT AXIAL\nPQC5\n| ↗ | 0.25 | C | D |",
            Gage = "G-1005-15",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp79", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "79",
            Description = "POSICION VERDADERA DE BARRENOS\n| ⊕ | Ø 0.1 | Ⓜ | C | D | Ⓜ |",
            Gage = "G-1005-07",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp26", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "26",
            Description = "SPOT FACE DEBE ESTAR LIBRE DE REBABAS ALREDEDOR DEL AGUJERO",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp74_80", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "74\n80",
            Description = "CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDAD DE ACUERDO A AYUDA VISUAL (AV-1155 / AV-727)",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> op40WDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp16", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "16",
            Description = "DIAMETRO DE BARRENOS DE BALANCEO Ø 4.25 MAX ",
            Gage = "G-1005-11",
            Sample = "1",
            InspectFrequency = "CADA HORA ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp17", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "17",
            Description = "PROFUNDIDAD DE BARRENOS DE BALANCEO 15.95 MAX ",
            Gage = "G-1005-23",
            Sample = "1",
            InspectFrequency = "CADA HORA ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp18", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "18",
            Description = "DISTANCIA ENTRE BARRENOS DE BALANCEO 3.0 mm MAX ENTRE BARRENOS ",
            Gage = "G-1005-12",
            Sample = "1",
            InspectFrequency = "CADA HORA",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp19", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "19",
            Description = "DIAMETRO Ø  161.65 ± 0.25 ",
            Gage = "G-1005-14",
            Sample = "1",
            InspectFrequency = "CADA HORA",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp75", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "75",
            Description = "PESO  DE  BALANCEO ",
            BoldDescription = "MAX 10 gr-cm ",
            Gage = "PLC CONTROL",
            Sample = "1",
            InspectFrequency = "INSPECCION 100%",
            IsCheckBox = false,
        },
    };


}