using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.GenVMini.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.GenVMini.Views;

public partial class GenVMiniPulidoCuneroBalanceoView : UserControl
{
    public GenVMiniPulidoCuneroBalanceoView()
    {
        InitializeComponent();
        DataContext = new GenVMiniPulidoCuneroBalanceoViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        // Change description of the gage to G-1019-XX
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Cuñero", 
            "Gen V Mini  | Cuñero",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(cuneroDcps, "First", "Gage\nG-1019-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Pulido", 
            "Gen V Mini | Pulido",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(pulidoDcps, "Second", "Gage\nG-1019-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Balanceo PBL-030", 
            "Gen V Mini | Balanceo PBL-030",
            RecordNumber.Third,
            DcpControlCreator.CreateGrid(balanceoDcps, "Third", "Gage\nG-1012-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Balanceo PBL-039", 
            "Gen V Mini | Balanceo PBL-039",
            RecordNumber.Forth,
            DcpControlCreator.CreateGrid(balanceoDcps, "Forth", "Gage\nG-1012-XX")));
    }

    private List<Dcp> cuneroDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp47", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "47",
            Description = "Ancho de cuñero 4.83 ± 0.03 mm",
            Gage = "26",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true
        },
        new Dcp(code: "Dcp50_48", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "50\n48",
            Description = "Distancia 40.82 ± .01m Posición verdadera de cuñero \n | ⊕ | 0.03 | Ⓜ | A | Ⓜ | B |",
            Gage = "27",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp36", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "36",
            Description = "Diametro interior MIN 37.600 - MAX 37.625",
            Gage = "G-1012-36",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn_77", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n77",
            Description = "Condicion del cuñero: \n 1. Posición correcta entre los dos brazos de la maza \n 2. Solo un cuñero \n3. Cuñero sin rebaba",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp77_161", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "77\n161",
            Description = "Condición visual de acuerdo a la ayuda visual (AV-1154) y porosidad de acuerdo a ayuda visual (AV-1155) ",
            Gage = "Visual\nPara verificar piezas sospechosas de poros uar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> pulidoDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp19", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "19",
            Description = "Distancia minima de bruñido 21.25 MIN",
            Gage = "28",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp20", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "20",
            Description = "Rugosidad del area de sello ",
            BoldDescription = "Ra MIN 0.25 - MAX 0.8",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn_10", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n10",
            Description = "Verificar la presencia de bruñido en toda el area de sello ",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> balanceoDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp71", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "71",
            Description = "El damper ensamblado debera estar en balanceo estatico maximo",
            BoldDescription = "180 gr. mm.",
            Gage = "PLC Control",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp3", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "3",
            Description = "Localización de barrenos de balanceo 81.96 ± 0.25 mm",
            Gage = "29",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp53", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "53",
            Description = "Diametro de barrenos de balanceo Ø 8.0 MAX",
            Gage = "30",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp54", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "54",
            Description = "Profundidad de barrenos de balanceo 8.0 MAX",
            Gage = "30",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        }
    };

}