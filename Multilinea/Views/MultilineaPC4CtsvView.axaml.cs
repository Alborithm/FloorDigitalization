using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Multilinea.Views;

public partial class MultilineaPC4CtsvView : UserControl
{
    public MultilineaPC4CtsvView()
    {
        InitializeComponent();
        DataContext = new MultilineaPC4CtsvViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("CTSV 100A", 
            "Multilinea | CTSV | PPT-010 | 100A ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op100aDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("CTSV 110A", 
            "Multilinea | CTSV | PMR-019 | 110A ",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(op110aDcps, "Second")));
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

    private List<Dcp> op100aDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn43", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n43",
            Description = "Espesor de pintura entre ",
            BoldDescription = "2.5 a 5",
            Gage = "ETG",
            Sample = "1",
            InspectFrequency = "INICIO, MITAD Y FINAL DE TURNO ",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn46", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN\n46",
            Description = "VISCOSIDAD  ",
            BoldDescription = "32 - 38 SEC.",
            Gage = "ZAHN (LAB)",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO ",
            IsCheckBox = false,
        },
    };

    private List<Dcp> op110aDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp56_57", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "56\n57",
            Description = "3 DIGITOS - JULIAN DATE\n1 DIGITO - TURNO\n4 DIGITOS - ULTIMOS 4 NUMEROS DE PARTE DE CLIENTE\nXXX - X -XXXX",
            Gage = "Visual\nSCANNER",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp156_79", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "156\n79",
            Description = "CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDADA DE ACUERDO A AYUDA VISUAL (AV-1155) ",
            Gage = "VISUAL\nPara verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = true,
        },
    };

}