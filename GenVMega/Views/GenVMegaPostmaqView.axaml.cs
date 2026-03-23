using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.GenVMega.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;
using FloorDigitalization.Static;

namespace FloorDigitalization.GenVMega.Views;

public partial class GenVMegaPostmaqView : UserControl
{
    public GenVMegaPostmaqView()
    {
        
        InitializeComponent();
        DataContext = new GenVMegaPostmaqViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem(StaticFields.isPared ? "Postmaquinado 139" : "Postmaquinado 138", 
            StaticFields.isPared ? "Gen V Mega | Postmaquinado 139 Pared" : "Gen V Mega | Postmaquinado 138 Pasillo",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(postmaquinado1Dcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem(StaticFields.isPared ? "Postmaquinado 142" : "Postmaquinado 141", 
            StaticFields.isPared ? "Gen V Mega | Postmaquinado 142 Pared" : "Gen V Mega | Postmaquinado 141 Pasillo", 
            RecordNumber.Second, 
            DcpControlCreator.CreateGrid(postmaquinado2Dcps, "Second")));
    }

    private List<Dcp> postmaquinado1Dcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01",inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN01",
            Description = "Calibrar los gages",
            Gage = "De acuerdo a instructivo",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp1",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1",
            Description = "LOCALIZACIÓN DE RANURAS 3ra ranura (maquinado de 6 ranuras) 98.112 ",
            BoldDescription = "± .250 mm",
            Gage = "►◄ G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp2",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "2",
            Description = "RUN OUT AXIAL en 3ra ranura (maquinado de 6 ranuras) ",
            BoldDescription = "↗ | 0.25 | A",
            Gage = "►◄ G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp4",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "4",
            Description = "LOCALIZACIÓN DE RANURAS 2da ranura (maquinado de 4 ranuras) 65.812 ±",
            BoldDescription = "± 0.250 mm",
            Gage = "►◄ G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp5",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "5",
            Description = "RUN OUT AXIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "↗ | 0.25 | A",
            Gage = "►◄ G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp9a",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "9A",
            Description = "RUN OUT RADIAL en 5ta ranura (maquinado de 6 ranuras) ",
            BoldDescription = "►◄ ↗ | 0.25 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp9b",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "9B",
            Description = "RUN OUT RADIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "►◄ ↗ | 0.25 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp36a",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "36A",
            Description = "Diámetro interior MIN 37.600 - MAX 37.625 ",
            Gage = "►◄ G-1012-36",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp36b", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "36B",
            Description = "Diámetro interior ",
            BoldDescription = "MIN 37.600 - MAX 37.625 ",
            Gage = "►◄ 51",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp12", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "12",
            Description = "Diámetro de back face 56.0 ± 0.25 mm",
            Gage = "52",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp15", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "15",
            Description = "Diámetro de sello 54.065 ",
            BoldDescription = "± 0.065 mm",
            Gage = "32",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp16", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "16",
            Description = "Run out de diámetro de sello ",
            BoldDescription = "↗ | 0.025 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp38", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "38",
            Description = "Rugosidad diámetro interior ",
            BoldDescription = "1.25 MIN 2.50 MAX",
            Gage = "RDC-006",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp24", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "24",
            Description = "Run out del back face ",
            BoldDescription = "↗ | 0.125 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp20ip", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "20 IP",
            Description = "Rugosidad en area de sello 2.0 MAX",
            Gage = "RDC-006",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp22", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "22",
            Description = "Perpendicularidad de sello ",
            BoldDescription = "⟂ | 0.05 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp25", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "25",
            Description = "Altura del back face a la cara del mamelon 31.79 ",
            BoldDescription = "± 0.25 mm",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp26", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "26",
            Description = "Altura total 118.27 ",
            BoldDescription = "± 0.25 mm",
            Gage = "09",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp42", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "42",
            Description = "Diametro de la cajera 37.875 ± 0.125 mm ",
            Gage = "18",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp6", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "6",
            Description = "Altura del mamelon a la cara del anillo 53.28 ",
            BoldDescription = "± 0.25 mm",
            Gage = "102",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp7", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "7",
            Description = "Perfil del anillo ",
            BoldDescription = "⌓ | 0.6 | A | B",
            Gage = "102",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn02", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN",
            Description = "Verificación de poka yoke de presencia de ranuras",
            Gage = "PY-209",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = true,
        }
    };
    private List<Dcp> postmaquinado2Dcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01",inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN01",
            Description = "Calibrar los gages",
            Gage = "De acuerdo a instructivo",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp1",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1",
            Description = "LOCALIZACIÓN DE RANURAS 3ra ranura (maquinado de 6 ranuras) 98.112 ",
            BoldDescription = "± .250 mm",
            Gage = "►◄ G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp2",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "2",
            Description = "RUN OUT AXIAL en 3ra ranura (maquinado de 6 ranuras) ",
            BoldDescription = "↗ | 0.25 | A",
            Gage = "►◄ G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp4",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "4",
            Description = "LOCALIZACIÓN DE RANURAS 2da ranura (maquinado de 4 ranuras) 65.812 ±",
            BoldDescription = "± 0.250 mm",
            Gage = "►◄ G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp5",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "5",
            Description = "RUN OUT AXIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "↗ | 0.25 | A",
            Gage = "►◄ G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp9a",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "9A",
            Description = "RUN OUT RADIAL en 5ta ranura (maquinado de 6 ranuras) ",
            BoldDescription = "►◄ ↗ | 0.25 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp9b",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "9B",
            Description = "RUN OUT RADIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "►◄ ↗ | 0.25 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp36a",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "36A",
            Description = "Diámetro interior MIN 37.600 - MAX 37.625 ",
            Gage = "►◄ G-1012-36",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp36b", inputPerTurn: 3, start: true, mid: true, end: true)
        {
            Code = "36B",
            Description = "Diámetro interior ",
            BoldDescription = "MIN 37.600 - MAX 37.625 ",
            Gage = "►◄ 51",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp12", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "12",
            Description = "Diámetro de back face 56.0 ± 0.25 mm",
            Gage = "52",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp15", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "15",
            Description = "Diámetro de sello 54.065 ",
            BoldDescription = "± 0.065 mm",
            Gage = "32",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp16", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "16",
            Description = "Run out de diámetro de sello ",
            BoldDescription = "↗ | 0.025 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp38", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "38",
            Description = "Rugosidad diámetro interior ",
            BoldDescription = "1.25 MIN 2.50 MAX",
            Gage = "RDC-005",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp24", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "24",
            Description = "Run out del back face ",
            BoldDescription = "↗ | 0.125 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp20ip", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "20 IP",
            Description = "Rugosidad en area de sello 2.0 MAX",
            Gage = "RDC-005",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp22", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "22",
            Description = "Perpendicularidad de sello ",
            BoldDescription = "⟂ | 0.05 | A",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp25", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "25",
            Description = "Altura del back face a la cara del mamelon 31.79 ",
            BoldDescription = "± 0.25 mm",
            Gage = "G-1012-20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp26", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "26",
            Description = "Altura total 118.27 ",
            BoldDescription = "± 0.25 mm",
            Gage = "09",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp42", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "42",
            Description = "Diametro de la cajera 37.875 ± 0.125 mm ",
            Gage = "18",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp6", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "6",
            Description = "Altura del mamelon a la cara del anillo 53.28 ",
            BoldDescription = "± 0.25 mm",
            Gage = "102",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp7", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "7",
            Description = "Perfil del anillo ",
            BoldDescription = "⌓ | 0.6 | A | B",
            Gage = "102",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn02", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN",
            Description = "Verificación de poka yoke de presencia de ranuras",
            Gage = "PY-209",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = true,
        }
    };
}