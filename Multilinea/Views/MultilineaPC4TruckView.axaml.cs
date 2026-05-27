using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Multilinea.Views;

public partial class MultilineaPC4TruckView : UserControl
{
    public MultilineaPC4TruckView()
    {
        InitializeComponent();
        DataContext = new MultilineaPC4TruckViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 090A", 
            "Multilinea | Truck | PMR-019 | 090A ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op90aDcps, "First")));
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

    private List<Dcp> op90aDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn74", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n74",
            Description = "FECHA JULIAN 3 DIGITOS (XXX) ",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn75", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n75",
            Description = "SELLO DE CAMBIO 1 DÍGITO (X) TURNO EN EL QUE SE ESTA ESTAMPANDO  ",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp82_85", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "82\n85",
            Description = "ÚLTIMOS CUATRO DÍGITOS DEL NÚMERO DE PIEZA ( 0108 )",
            Gage = "2D SCANNER ",
            Sample = "1",
            InspectFrequency = "100% ",
            IsCheckBox = false,
        },
    };

}