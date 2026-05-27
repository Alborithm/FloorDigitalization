using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Multilinea.Views;

public partial class MultilineaPC2TruckView : UserControl
{
    public MultilineaPC2TruckView()
    {
        InitializeComponent();
        DataContext = new MultilineaPC2TruckViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 030A", 
            "Multilinea | Truck | PTN-077 | 030A ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op30aDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 040A", 
            "Multilinea | Truck | PBR-017 | 040A ",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(op40aDcps, "Second")));
        // tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 010W", 
        //     "Multilinea | Truck | PTN-117 | 010W ",
        //     RecordNumber.Third,
        //     DcpControlCreator.CreateGrid(op10wDcps, "Third")));
        // tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 020W", 
        //     "Multilinea | Truck | PTN-117 | 020W ",
        //     RecordNumber.Forth,
        //     DcpControlCreator.CreateGrid(op20wDcps, "Forth")));
        // tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 010A", 
        //     "Multilinea | Truck | PPE-037 | 010A ",
        //     RecordNumber.Fifth,
        //     DcpControlCreator.CreateGrid(op10aDcps, "Fifth")));
    }

    // TODO replace with the Multilinea 10H CTSV Data

    private List<Dcp> op30aDcps = new List<Dcp>()
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
        new Dcp(code: "DcpSn80", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN\n80",
            Description = "RUGOSIDAD AREA DE SELLO 0.9-1.5 Ra ",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "INICIO Y MITAD DE TURNO ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp49", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "49",
            Description = "LOCALIZACIÓN DE MAZA 5ª RANURA 112.352 ± 0.100 mm \n►◄",
            Gage = "G-1020-19",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp50", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "50",
            Description = "RUN OUT RADIAL MAZA 5ª RANURA | ↗ | 0.25 | A | \n►◄",
            Gage = "G-1020-19",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp51", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "51",
            Description = "LOCALIZACION ANILLO  3ª RANURA 69.422 ± 0.25 mm \n►◄",
            Gage = "G-1020-19",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp52", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "52",
            Description = "RUN OUT RADIAL ANILLO  3ª RANURA | ↗ | 0.25 | A | \n►◄ ",
            Gage = "G-1020-19",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp58", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "58",
            Description = "DIAMETRO 187.99 ± 0.30 mm ",
            Gage = "G-6425-12",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp60", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "60",
            Description = "RUN OUT AXIAL ANILLO | ↗ | 0.35 | A | ",
            Gage = "G-1020-19",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp61", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "61",
            Description = "RUN OUT AXIAL ANILLO 3ª RANURA | ↗ | 0.25 | A | \n►◄ ",
            Gage = "G-1020-19",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp66", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "66",
            Description = "ALTURA DE BACK FACE 35.29 ± 0.25 mm ",
            Gage = "G-1020-22",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp67", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "67",
            Description = "BACK FACE RUN OUT | ↗ | 0.125 | A |",
            Gage = "G-1020-22",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp72", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "72",
            Description = "BACKFACE DIAMETRO 56 ± 0.25 mm",
            Gage = "G-1020-21",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp73", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "73",
            Description = "RUN OUT RADIAL ANILLO  5ª RANURA  | ↗ | 0.25 | A | \n►◄ ",
            Gage = "G-1020-19",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp87", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "87",
            Description = "DIAMETRO INTERIOR 37.6125 ± 0.0125 mm \n►◄ ",
            Gage = "G-6366-09\nColumna ",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
    };

    private List<Dcp> op40aDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp68", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "68",
            Description = "POSICION VERDADERA | ⊕ | 0.03 | Ⓜ | A | Ⓜ | B |",
            Gage = "G-6400-34",
            Sample = "1",
            InspectFrequency = "INICIO Y MITAD DE TURNO ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp69", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "69",
            Description = "ANCHO DE CUÑERO 4.825  ±  0.025 mm ",
            Gage = "G-1020-38",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp86", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "86",
            Description = "DISTANCIA 40.82 ± 0.1 mm ",
            Gage = "G-6400-34",
            Sample = "1",
            InspectFrequency = "CADA 20 PIEZAS",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp87", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "87",
            Description = "DIAMETRO INTERIOR 37.6125 ± 0.0125 mm \n►◄",
            Gage = "G-6366-09",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp23", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "23",
            Description = "NO SE PERMITE POROSIDAD VISUAL EN EL DIÁMETRO DEL SELLO, EL ÁREA DE LAS RANURAS Y EL DIÁMETRO INTERNO LA POROSIDAD ES PERMISIBLE EN OTRAS SUPERFICIES MECANIZADAS SI MENOS DE Ø1,5 mm Y MENOS DE 1,0 mm DE PROFUNDIDAD",
            Gage = "VISUAL Para verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp34", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "34",
            Description = "LAS REBABAS, LOS BORDES AFILADOS Y LOS MATERIALES EXTRAÑOS RESULTANTES DE LAS BUENAS PRÁCTICAS DE FABRICACIÓN SON ACEPTABLES SIEMPRE QUE NO SEAN PERJUICIOS PARA EL FUNCIONAMIENTO DEL ENSAMBLAJE O LA MANIPULACIÓN SEGURA SEGÚN LO DETERMINE LA INGENIERÍA DEL MOTOR",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },

    };
}