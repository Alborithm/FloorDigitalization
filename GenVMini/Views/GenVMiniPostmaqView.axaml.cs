using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.GenVMini.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.GenVMini.Views;

public partial class GenVMiniPostmaqView : UserControl
{
    public GenVMiniPostmaqView()
    {
        InitializeComponent();
        DataContext = new GenVMiniPostmaqViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Postmaquinado 101", 
            "Gen V Mini | Postmaquinado 101",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(postmaq101Dcps, "First", "Gage\nG-1019-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Postmaquinado 113", 
            "Gen V Mini | Postmaquinado 113",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(postmaq113Dcps, "Second", "Gage\nG-1019-XX")));
    }

    private List<Dcp> postmaq101Dcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01", inputPerTurn:1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "Calibrar los gages",
            Gage = "De acuerdo a instructivo",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp1", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "1",
            Description = "LOCALIZACIÓN DE RANURAS 3ra ranura (maquinado de 6 ranuras) 98.112 ",
            BoldDescription = "± .250 mm\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp2", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "2",
            Description = "RUN OUT AXIAL en 3ra ranura (maquinado de 6 ranuras) ",
            BoldDescription = "↗ | 0.25 | A\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp4", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "4",
            Description = "LOCALIZACIÓN DE RANURAS 2da ranura (maquinado de 4 ranuras) 65.812 ",
            BoldDescription = "± 0.250 mm\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp5", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "5",
            Description = "RUN OUT AXIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "↗ | 0.25 | A\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp9a", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "9A",
            Description = "RUN OUT RADIAL en 5ta ranura (maquinado de 6 ranuras) ",
            BoldDescription = "↗ | 0.25 | A\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp9b", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "9B",
            Description = "RUN OUT RADIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "↗ | 0.25 | A\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp36a", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "36A",
            Description = "Diámetro interior MIN 37.600 - MAX 37.625 \n►◄",
            Gage = "G-1012-36",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp36b", inputPerTurn:3, start: true, mid: true, end: true)
        {
            Code = "36B",
            Description = "Diámetro interior ",
            BoldDescription = "MIN 37.600 - MAX 37.625\n►◄",
            Gage = "22",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp12", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "12",
            Description = "Diámetro de back face 56.0 ± 0.25 mm",
            Gage = "35",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = true,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp15", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "15",
            Description = "Diámetro de sello 54.065 ",
            BoldDescription = "± 0.065 mm",
            Gage = "18",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp16", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "16",
            Description = "Run out de diámetro de sello ",
            BoldDescription = "↗ | 0.025 | A",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp38", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "38",
            Description = "Rugosidad diámetro interior ",
            BoldDescription = "1.25 MIN 2.50 MAX",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp6", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "6",
            Description = "Altura del mamelon a la cara del anillo 53.28 ",
            BoldDescription = "± 0.25 mm",
            Gage = "17",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp7", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "7",
            Description = "Perfil del anillo ",
            BoldDescription = "⌓ | 0.6 | A | B",
            Gage = "17",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp20ip", inputPerTurn:1, start: true, mid: false, end: false)
        {
            Code = "20 IP",
            Description = "Rugosidad en area de sello 2.0 MAX",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp18", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "18",
            Description = "Diametro de nariz 48.30 ± 0.15 mm",
            Gage = "19",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp22", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "22",
            Description = "Perpendicularidad de sello ",
            BoldDescription = "⟂ | 0.05 | A",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp24", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "24",
            Description = "Run out del back face ",
            BoldDescription = "↗ | 0.125 | A",
            Gage = "20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp25", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "25",
            Description = "Altura del back face a la cara del mamelon 31.79 ",
            BoldDescription = "± 0.25 mm",
            Gage = "20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp26", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "26",
            Description = "Altura total 118.27 ",
            BoldDescription = "± 0.25 mm",
            Gage = "21",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado1"
        },
        new Dcp(code: "Dcp42", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "42",
            Description = "Diametro de la cajera 37.875 ± 0.125 mm ",
            Gage = "25",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
            ParentName = "Postmaquinado1"
        }
    };

    private List<Dcp> postmaq113Dcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01", inputPerTurn:1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "Calibrar los gages",
            Gage = "De acuerdo a instructivo",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp1", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "1",
            Description = "LOCALIZACIÓN DE RANURAS 3ra ranura (maquinado de 6 ranuras) 98.112 ",
            BoldDescription = "± .250 mm\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp2", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "2",
            Description = "RUN OUT AXIAL en 3ra ranura (maquinado de 6 ranuras) ",
            BoldDescription = "↗ | 0.25 | A\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp4", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "4",
            Description = "LOCALIZACIÓN DE RANURAS 2da ranura (maquinado de 4 ranuras) 65.812 ",
            BoldDescription = "± 0.250 mm\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp5", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "5",
            Description = "RUN OUT AXIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "↗ | 0.25 | A\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp9a", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "9A",
            Description = "RUN OUT RADIAL en 5ta ranura (maquinado de 6 ranuras) ",
            BoldDescription = "↗ | 0.25 | A\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp9b", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "9B",
            Description = "RUN OUT RADIAL en 2da ranura (maquinado de 4 ranuras) ",
            BoldDescription = "↗ | 0.25 | A\n►◄",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp36a", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "36A",
            Description = "Diámetro interior MIN 37.600 - MAX 37.625 \n►◄",
            Gage = "G-1012-36",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp36b", inputPerTurn:3, start: true, mid: true, end: true)
        {
            Code = "36B",
            Description = "Diámetro interior ",
            BoldDescription = "MIN 37.600 - MAX 37.625\n►◄",
            Gage = "22",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp12", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "12",
            Description = "Diámetro de back face 56.0 ± 0.25 mm",
            Gage = "35",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = true,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp15", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "15",
            Description = "Diámetro de sello 54.065 ",
            BoldDescription = "± 0.065 mm",
            Gage = "18",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp16", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "16",
            Description = "Run out de diámetro de sello ",
            BoldDescription = "↗ | 0.025 | A",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp38", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "38",
            Description = "Rugosidad diámetro interior ",
            BoldDescription = "1.25 MIN 2.50 MAX",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "Cada 20 piezas",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp6", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "6",
            Description = "Altura del mamelon a la cara del anillo 53.28 ",
            BoldDescription = "± 0.25 mm",
            Gage = "17",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp7", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "7",
            Description = "Perfil del anillo ",
            BoldDescription = "⌓ | 0.6 | A | B",
            Gage = "17",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp20ip", inputPerTurn:1, start: true, mid: false, end: false)
        {
            Code = "20 IP",
            Description = "Rugosidad en area de sello 2.0 MAX",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp18", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "18",
            Description = "Diametro de nariz 48.30 ± 0.15 mm",
            Gage = "19",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp22", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "22",
            Description = "Perpendicularidad de sello ",
            BoldDescription = "⟂ | 0.05 | A",
            Gage = "16",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp24", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "24",
            Description = "Run out del back face ",
            BoldDescription = "↗ | 0.125 | A",
            Gage = "20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp25", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "25",
            Description = "Altura del back face a la cara del mamelon 31.79 ",
            BoldDescription = "± 0.25 mm",
            Gage = "20",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp26", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "26",
            Description = "Altura total 118.27 ",
            BoldDescription = "± 0.25 mm",
            Gage = "21",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
            ParentName = "Postmaquinado2"
        },
        new Dcp(code: "Dcp42", inputPerTurn:1, start: true, mid: true, end: true)
        {
            Code = "42",
            Description = "Diametro de la cajera 37.875 ± 0.125 mm ",
            Gage = "25",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
            ParentName = "Postmaquinado2"
        }
    };
}