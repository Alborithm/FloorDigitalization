using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Multilinea.Views;

public partial class MultilineaPC2CtsvView : UserControl
{
    public MultilineaPC2CtsvView()
    {
        InitializeComponent();
        DataContext = new MultilineaPC2CtsvViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 040A", 
            "Multilinea | Ctsv | PTN-077 | 040A ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op40aDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 050A", 
            "Multilinea | Ctsv | PBR-017 | 050A ",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(op50aDcps, "Second")));
        // tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 010W", 
        //     "Multilinea | Ctsv | PTN-117 | 010W ",
        //     RecordNumber.Third,
        //     DcpControlCreator.CreateGrid(op10wDcps, "Third")));
        // tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 020W", 
        //     "Multilinea | Ctsv | PTN-117 | 020W ",
        //     RecordNumber.Forth,
        //     DcpControlCreator.CreateGrid(op20wDcps, "Forth")));
        // tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ctsv 010A", 
        //     "Multilinea | Ctsv | PPE-037 | 010A ",
        //     RecordNumber.Fifth,
        //     DcpControlCreator.CreateGrid(op10aDcps, "Fifth")));
    }

    // TODO replace with the Multilinea 10H CTSV Data

    private List<Dcp> op40aDcps = new List<Dcp>()
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
        new Dcp(code: "Dcp12", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "12",
            Description = "LOCALIZACION DE LA 4TA RANURA 100.212 ",
            BoldDescription = "± 0.10 ",
            PostDescription = "mm\n►◄",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp13", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "13",
            Description = "RUN OUT AXIAL DE LA 4TA RANURA",
            BoldDescription = "| ↗ | 0.25 | A |",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp14", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "14",
            Description = "LOCALIZACION DE LA 7MA RANURA 61.992 ",
            BoldDescription = "± 0.25",
            PostDescription = "mm \n►◄",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp15", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "15",
            Description = "LOCALIZACION A LA 2DA RANURA 34.332 ",
            BoldDescription = "± 0.25",
            PostDescription = "mm \n►◄",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp16", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "16",
            Description = "RUN OUT AXIAL DE LA 7MA RANURA ",
            BoldDescription = "| ↗ | 0.25 | A |",
            PostDescription = "\n►◄",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp17", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "17",
            Description = "RUN OUT AXIAL A LA 2DA RANURA ",
            BoldDescription = "| ↗ | 0.25 | A |",
            PostDescription = "\n►◄",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp18", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "18",
            Description = "ALTURA 24.680 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm",
            Gage = "G-6397-13-1",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp20", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "20",
            Description = "DIAMETRO DE LA SEGUNDA RANURA 187.99 ",
            BoldDescription = "± 0.30 ",
            PostDescription = "mm",
            Gage = "G-6425-12",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp21", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "21",
            Description = "RUN OUT RADIAL A LA 7MA RANURA",
            BoldDescription = "| ↗ | 0.25 | A |",
            PostDescription = "\n►◄",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp24", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "24",
            Description = "DIAMETRO DE BACKFACE 56.0 ± 0.25 mm",
            Gage = "G-6392-82",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp23", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "23",
            Description = "DIAMETRO EXTERIOR DE LA NARIZ 48.30 ± 0.15 mm",
            Gage = "G-1020-18",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp27", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "27",
            Description = "RUN OUT RADIALD E LA 4TA RANURA",
            BoldDescription = "| ↗ | 0.25 | A |",
            PostDescription = "\n►◄",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp29", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "29",
            Description = "RUGOSIDAD Ra",
            BoldDescription = "2.5",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "INICIO MITAD Y FINAL DE TURNO ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp31", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "31",
            Description = "ALTURA DE BACKFACE 35.29 ",
            BoldDescription = "± 0.25",
            PostDescription = "mm",
            Gage = "G-6397-73",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp30", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "30",
            Description = "RUN OUT RADIAL DE BACKFACE ",
            BoldDescription = "| ↗ | 0.125 | A |",
            Gage = "G-6397-73",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp40_1", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "40",
            Description = "DIAMETRO INTERIOR 37.6125 ± 0.0125 mm\n►◄",
            Gage = "G-1019-23",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp40_2", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "40",
            Description = "DIAMETRO INTERIOR ",
            BoldDescription = "37.6125 ± 0.0125 ",
            PostDescription = "mm \n ►◄",
            Gage = "G-6366-09C",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp41", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "41",
            Description = "RUGOSIDAD DE DIAMETRO INTERIOR ",
            BoldDescription = "1.25 - 2.5 ",
            PostDescription = "Ra",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "CADA 20 PIEZAS ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp42", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "42",
            Description = "ALTURA ",
            BoldDescription = "22.5 a 23.0",
            PostDescription = "mm",
            Gage = "G-6397-13",
            Sample = "1",
            InspectFrequency = "INICIO MITAD Y FINAL DE TURNO ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp43", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "43",
            Description = "ALTURA ",
            BoldDescription = "25.1 a 25.6",
            PostDescription = "mm",
            Gage = "G-6397-13",
            Sample = "1",
            InspectFrequency = "INICIO MITAD Y FINAL DE TURNO ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp45", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "45",
            Description = "DIAMETRO CAJERA 37.875 ± 0.125 mm",
            Gage = "G-6366-12",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp46", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "46",
            Description = "DIAMETRO DE SELLO 54.065 ",
            BoldDescription = "± 0.065",
            Gage = "G-1020-24",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp47", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "47",
            Description = "RUN OUT RADIAL DE DIAMETRO EXTERIOR ",
            BoldDescription = "| ↗ | 0.025 | A |",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp155", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "155",
            Description = "RUN OUT DE MAMELON ",
            BoldDescription = "| ↗ | 0.05 | A |",
            Gage = "G-6397-54",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp79_156", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "78\n156",
            Description = "CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDADA DE ACUERDO A AYUDA VISUAL (AV-1155) ",
            Gage = "VISUAL\nPara verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn1", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN",
            Description = "LIBRE DE FILOS Y REBABAS EN LA CARA DEL ANILLO (AV-1154 CTSV)",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn2", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN",
            Description = "PRESENCIA DE RANURAS (POKA YOKE) ",
            Gage = "PY-215",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
        },
    };

    private List<Dcp> op50aDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp37", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "37",
            Description = "Ancho de cuñero 4.83 ± 0.003 mm",
            Gage = "G-1020-38",
            Sample = "1",
            InspectFrequency = "CADA 20 PIEZAS ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp51_38", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "51\n38",
            Description = "Profundidad de cuñero 40.82 ± 0.1 mm Posición verdadera de cuñero | ⊕ | 0.03 | A | B |",
            Gage = "G-1020-34",
            Sample = "1",
            InspectFrequency = "CADA 20 PIEZAS",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp40", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "40",
            Description = "DIAMETRO INTERIOR 37.6125 ± 0.0125 mm\n►◄",
            Gage = "G-1019-23",
            Sample = "1",
            InspectFrequency = "CADA HORA",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp79_156", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "79\n156",
            Description = "FILOS EN LOS BORES Y CUALQUIER SUPERFICIE INTERIOR MAQUINADA CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDADA DE ACUERDO A AYUDA VISUAL (AV-1155) ",
            Gage = "VISUAL\nPara verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };
}