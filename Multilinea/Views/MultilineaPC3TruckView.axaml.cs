using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Multilinea.Views;

public partial class MultilineaPC3TruckView : UserControl
{
    public MultilineaPC3TruckView()
    {
        InitializeComponent();
        DataContext = new MultilineaPC3TruckViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 060A", 
            "Multilinea | Truck | PPL-018 | 060A ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op60aDcps, "First")));
        // tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 040A", 
        //     "Multilinea | Truck | PBR-017 | 040A ",
        //     RecordNumber.Second,
        //     DcpControlCreator.CreateGrid(op40aDcps, "Second")));
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

    private List<Dcp> op60aDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp89", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "89",
            Description = "VERIFICAR PRESENCIA DE PULIDO ",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp99", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "99",
            Description = "RUGOSIDAD DE DIAMETRO EXTERIOR 0.6 - 0.25 Ra \nMedir en dos puntos  ",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "CADA 20 PIEZAS ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp113", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "113",
            Description = "DISTANCIA DE PULIDO 21.25 Min",
            Gage = "G-1020-28",
            Sample = "1",
            InspectFrequency = "CADA 20 PIEZAS",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp23", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "23",
            Description = "NO SE PERMITE POROSIDAD VISUAL EN EL DIÁMETRO DEL SELLO, EL ÁREA DE LAS RANURAS Y EL DIÁMETRO INTERNO LA POROSIDAD ES PERMISIBLE EN OTRAS SUPERFICIES MECANIZADAS SI MENOS DE Ø1,5 mm Y MENOS DE 1,0 mm DE PROFUNDIDAD",
            Gage = "VISUAL Para verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp34_62", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "34\n62",
            Description = "LAS REBABAS, LOS BORDES AFILADOS Y LOS MATERIALES EXTRAÑOS RESULTANTES DE LAS BUENAS PRÁCTICAS DE FABRICACIÓN SON ACEPTABLES SIEMPRE QUE NO SEAN PERJUICIOS PARA EL FUNCIONAMIENTO DEL ENSAMBLAJE O LA MANIPULACIÓN SEGURA SEGÚN LO DETERMINE LA INGENIERÍA DEL MOTOR ",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
    };

}