using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Multilinea.Views;

public partial class MultilineaPC3CtsvView : UserControl
{
    public MultilineaPC3CtsvView()
    {
        InitializeComponent();
        DataContext = new MultilineaPC3CtsvViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("CTSV 060A", 
            "Multilinea | CTSV | PBL-XXX | 060A ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op60aDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("CTSV 070A", 
            "Multilinea | CTSV | PPL-018 | 070A ",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(op70aDcps, "Second")));
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
        new Dcp(code: "Dcp52", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "52",
            Description = "Localizacion de barrenos de balanceo 166.0  +/- 0.25 mm ",
            Gage = "G-6397-57",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp73", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "73",
            Description = "EL DAMPER ENSAMBLADO DEBERA ESTAR EN BALANCEO ESTATICO DENTRO DE ",
            BoldDescription = "0.18 kg. Mm. ",
            PostDescription = "(0.25 oz.in.)",
            Gage = "PLC CONTROL ",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp55", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "55",
            Description = "Diametro de barrenos de balanceo Ø 13.0 MAX ",
            Gage = "G-6392-36",
            Sample = "1",
            InspectFrequency = "CADA HORA",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp54", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "54",
            Description = "Profundidad de barrenos de balanceo \n10 MAX\n\nNota: medir en barrenos centrales",
            Gage = "G-6392-36",
            Sample = "1",
            InspectFrequency = "CADA HORA",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp53", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "53",
            Description = "Distancia entre barrenos 3.0 MIN",
            Gage = "G-1020-31",
            Sample = "1",
            InspectFrequency = "CADA HORA",
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
    
    private List<Dcp> op70aDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn50", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n50",
            Description = "Verificar la presencia de bruñido en toda el area de sello ",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp158", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "158",
            Description = "Distancia minima de pulido 21.25 ± 0.25 mm",
            Gage = "G-1020-28",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp39", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "39",
            Description = "Rugosidad del area de sello",
            BoldDescription = "\nRa 0.6\n0.25",
            PostDescription = "\n\nNota: medir en dos puntos",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = false,
        },
    };

}