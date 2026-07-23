using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.NewPenta.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;
using FloorDigitalization.Static;

namespace FloorDigitalization.NewPenta.Views;

public partial class NewPentaAnillosView : UserControl
{
    public NewPentaAnillosView()
    {
        InitializeComponent();
        DataContext = new NewPentaAnillosViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        // TODO: Fix the descriptions below
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Anillos PTN-116", 
            "New Penta | Anillos PTN-116 | 10W / 20W",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(anillosDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Anillos PTN-086", 
            "New Penta | Anillos PTN-086 | 10W / 20W",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(anillosDcps, "Second")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Anillos PTN-109", 
            "New Penta | Anillos PTN-109 | 10W / 20W",
            RecordNumber.Third,
            DcpControlCreator.CreateGrid(anillosDcps, "Third")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Anillos PTN-103", 
            "New Penta | Anillos PTN-103 | 10W / 20W",
            RecordNumber.Forth,
            DcpControlCreator.CreateGrid(anillosDcps, "Forth")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Anillos PTN-106", 
            "New Penta | Anillos PTN-106 | 10W / 20W",
            RecordNumber.Fifth,
            DcpControlCreator.CreateGrid(anillosDcps, "Fifth")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Anillos PTN-115", 
            "New Penta | Anillos PTN-115 | 10W / 20W",
            RecordNumber.Sixth,
            DcpControlCreator.CreateGrid(anillosDcps, "Sixth")));
    }

    private List<Dcp> anillosDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN",
            Description = "CALIBRAR LOS GAGES ",
            Gage = "DE ACUERDO A INSTRUCTIVO",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp20", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "20",
            Description = "DIÁMETRO EXTERIOR MENOR Ø 152.50 ",
            BoldDescription = "± 0.25",
            Gage = "G-1017-18",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp24", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "24",
            Description = "DISTANCIA DE ANILLO A LA 5TA RANURA 18.84 ",
            BoldDescription = "± 0.10",
            Gage = "G-1017-18",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp31", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "31",
            Description = "DIÁMETRO DE RANURAS SOBRE PERNOS Ø 149.02 ",
            BoldDescription = "± 0.6",
            Gage = "G-1017-21",
            Sample = "1",
            InspectFrequency = "CADA  30",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp32", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "32",
            Description = "DIÁMETRO EXTERIOR MAYOR Ø 160.89 ",
            BoldDescription = "± 0.15",
            Gage = "G-1017-18",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp21", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "21",
            Description = "DIÁMETRO INTERIOR Ø 121.365 ",
            BoldDescription = "± 0.065",
            Gage = "G-1017-22",
            Sample = "1",
            InspectFrequency = "CADA 5",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp26", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "26",
            Description = "RUN OUT  AXIAL | ↗ | 0.1 | A |",
            Gage = "G-1017-23",
            Sample = "1",
            InspectFrequency = "CADA  30",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn02", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN",
            Description = "RUN OUT RADIAL ",
            BoldDescription = "| ↗ | 0.25 | A |",
            Gage = "G-1017-23",
            Sample = "1",
            InspectFrequency = "CADA 30",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp29", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "29",
            Description = "ALTURA TOTAL DE ANILLO 35 ",
            BoldDescription = "± 0.25",
            Gage = "G-1017-24",
            Sample = "1",
            InspectFrequency = "CADA 30",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp30", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "30",
            Description = "PARALELISMO | // | 0.1 | B |",
            Gage = "G-1017-24",
            Sample = "1",
            InspectFrequency = "CADA  30",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp22", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "22",
            Description = "RUGOSIDAD DE DIÁMETRO INTERIOR ",
            BoldDescription = "Ra 5.0 - 7.0",
            Gage = "RDC-007 (penta viejo)",
            Sample = "1",
            InspectFrequency = "INICIO / MITAD/ FINAL DE TURNO",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp121_85", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "121\n85",
            Description = "CONDICION VISUAL DE ACUERDO A LA AYUDA VISUAL (AV-1154) Y POROSIDAD DE ACUERDO A AYUDA VISUAL (AV-1155)",
            Gage = "Visual\nPara verificar piezas sospechosas de poros usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = true,
        },
    };
}