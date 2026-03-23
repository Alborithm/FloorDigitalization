using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.GenVPrincipal.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.GenVPrincipal.Views;

public partial class GenVPrincipalPostmaqCuneroPulidoView : UserControl
{
    public GenVPrincipalPostmaqCuneroPulidoView()
    {
        InitializeComponent();
        DataContext = new GenVPrincipalPostmaqCuneroPulidoViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        // Change description of the gage to G-1019-XX
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Postmaquinado", 
            "Gen V Principal  | Postmaquinado",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(postmaquinadoDcps, "First", "Gage")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Cuñero", 
            "Gen V Principal | Cuñero",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(cuneroDcps, "Second", "Gage")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Pulido", 
            "Gen V Principal | Pulido",
            RecordNumber.Third,
            DcpControlCreator.CreateGrid(pulidoDcps, "Third", "Gage")));
    }

    private List<Dcp> postmaquinadoDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01", inputPerTurn:1, start: true, mid: true, end: false)
        {
            Code = "SN01",
            Description = "Calibrar los gages",
            Gage = "De acuerdo a instructivo",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true
        },
        new Dcp(code: "Dcp1", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "1",
            Description = "LOCALIZACIÓN DE RANURAS 3ra ranura (maquinado de 6 ranuras) 98.112 ",
            BoldDescription = "± .250 mm",
            Gage = "20 ►◄",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp2", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "2",
            Description = "RUN OUT AXIAL en 3ra ranura (maquinado de 6 ranuras) ",
            BoldDescription = "± .250 mm",
            Gage = "20 ►◄",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp4", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "4",
            Description = "LOCALIZACIÓN DE RANURAS 2da ranura (maquinado de 4 ranuras) 65.812 ",
            BoldDescription = "± 0.250 mm",
            Gage = "20 ►◄",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp5", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "5",
            Description = "RUN OUT AXIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "↗ | 0.25 | A",
            Gage = "20 ►◄",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp9a", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "9a",
            Description = "RUN OUT RADIAL en 3ra ranura (maquinado de 6 ranuras) ",
            BoldDescription = "►◄ ↗ | 0.25 | A",
            Gage = "20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp9b", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "9b",
            Description = "RUN OUT RADIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "►◄ ↗ | 0.25 | A",
            Gage = "20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp12", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "12",
            Description = "Diámetro de back face 56.0 ± 0.25 mm",
            Gage = "22",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = true
        },
        new Dcp(code: "Dcp16", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "16",
            Description = "Run out de diámetro de sello ",
            BoldDescription = "↗ | 0.025 | A",
            Gage = "20",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp38", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "38",
            Description = "Rugosidad diámetro interior ",
            BoldDescription = "1.25 MIN 2.50 MAX",
            Gage = "RDC-002",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp6", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "6",
            Description = "Altura del mamelon a la cara del anillo 53.28 ",
            BoldDescription = "± 0.25 mm",
            Gage = "19",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp7", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "7",
            Description = "Perfil del anillo ",
            BoldDescription = "⌓ | 0.6 | A | B",
            Gage = "19",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp18", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "18",
            Description = "Diámetro de nariz 48.30 ± 0.15 mm ",
            Gage = "24",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true
        },
        new Dcp(code: "Dcp22", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "22",
            Description = "Perpendicularidad de sello ",
            BoldDescription = "⟂ | 0.05 | A",
            Gage = "20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp24", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "24",
            Description = "Run out del back face ",
            BoldDescription = "↗ | 0.125 | A",
            Gage = "25",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp25", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "25",
            Description = "Altura del back face a la cara del mamelon 31.79 ",
            BoldDescription = "± 0.25 mm",
            Gage = "25",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp26", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "26",
            Description = "Altura total 118.27 ",
            BoldDescription = "± 0.25 mm",
            Gage = "G-1019-36",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp20ip", inputPerTurn:1, start: true, mid: false, end: false)
        {
            Code = "20 IP",
            Description = "Rugosidad en area de sello ",
            BoldDescription = "2.0 MAX",
            Gage = "RDC-002",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp42", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "42",
            Description = "Diametro de la cajera 37.875 ± 0.125 mm ",
            Gage = "29",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true
        },
    };

    private List<Dcp> cuneroDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp47", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "47",
            Description = "Ancho de cuñero 4.89 ± 0.03 mm",
            Gage = "32",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true
        },
        new Dcp(code: "Dcp50_48", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "50\n48",
            Description = "Distancia 40.82 ± .01m Posición verdadera de cuñero \n | ⊕ | 0.03 | Ⓜ | A | Ⓜ | B |",
            Gage = "33",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true
        },
        new Dcp(code: "DcpSn_77", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "SN\n77",
            Description = "Condicion del cuñero: \n 1. Posición correcta entre los dos brazos de la maza \n 2. Solo un cuñero \n Cuñero sin rebaba",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true
        },
    };

    private List<Dcp> pulidoDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01", inputPerTurn:1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "Calibrar los gages",
            Gage = "De acuerdo a instructivo",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true
        },
        new Dcp(code: "Dcp36a", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "36A",
            Description = "Diametro interior MIN 37.600 - MAX 37.625",
            Gage = "36",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true
        },
        new Dcp(code: "Dcp36b", inputPerTurn:3, start: true, mid: true, end: true)
        {
            Code = "36B",
            Description = "Diametro interior ",
            BoldDescription = "MIN 37.600 - MAX 37.625",
            Gage = "38",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp19", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "19",
            Description = "Distancia minima de bruñido 21.25 MIN",
            Gage = "31",
            Sample = "1",
            InspectFrequency = "Cada 60 piezas",
            IsCheckBox = true
        },
        new Dcp(code: "Dcp20", inputPerTurn:2, start: true, mid: true, end: true)
        {
            Code = "20",
            Description = "Rugosidad del area de sello ",
            BoldDescription = "Ra MIN 0.25 - MAX 0.8",
            Gage = "RDC-002",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false
        },
        new Dcp(code: "Dcp15", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "15",
            Description = "Diametro exterior 54.065 ",
            BoldDescription = "±0.065 mm",
            Gage = "30",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false
        },
        new Dcp(code: "DcpSn_10", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "SN\n10",
            Description = "Verificar la presencia de bruñido en toda el area de sello ",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true
        },
        new Dcp(code: "Dcp77_161", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "77\n161",
            Description = "Condición visual de acuerdo a la ayuda visual (AV-1154) y porosidad de acuerdo a ayuda visual (AV-1155) ",
            Gage = "Visual\nPara verificar piezas sospechosas de poros uar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true
        },
    };

}