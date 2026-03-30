using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Multilinea.Views;

public partial class MultilineaPC1View : UserControl
{
    public MultilineaPC1View()
    {
        InitializeComponent();
        DataContext = new MultilineaPC1ViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 010H", 
            "Multilinea | Truck | PTN-107 | 010H ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(op10hDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 020H", 
            "Multilinea | Truck | PTN-107 | 020H ",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(op20hDcps, "Second")));
    }

    // TODO replace with the Multilinea 10H CTSV Data

    private List<Dcp> op10hDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN",
            Description = "CALIBRAR LOS GAGES ",
            Gage = "DE ACUERDO A INSTRUCTIVO",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp1Ip1", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1IP",
            Description = "DISTANCIA A LAS RANURAS 16.87 ",
            BoldDescription = "± 0.15 ",
            PostDescription = "\nCARA#1",
            Gage = "G-1005-20",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp1Ip2", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1IP",
            Description = "DISTANCIA A LAS RANURAS 16.87 ",
            BoldDescription = "± 0.15 ",
            PostDescription = "\nCARA#2",
            Gage = "G-1005-20",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp6", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "6",
            Description = "DIAMETRO EXTERIOR DE LA CARA DEL ANILLO Ø 185.9 ",
            BoldDescription = "± 0.25 ",
            Gage = "G-1005-02",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp7", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "7",
            Description = "DIAMETRO EXTERIOR DE RANURAS Ø 180.99 ",
            BoldDescription = "± 0.4 ",
            Gage = "G-1005-13",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp94", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "94",
            Description = "PERFIL ",
            BoldDescription = "⌓ | 0.6 | E | F ",
            Gage = "G-1005-21",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp101", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "101",
            Description = "ALTURA TOTAL 37.3 ",
            BoldDescription = "± 0.20",
            Gage = "G-1005-02",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp102Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "102IP",
            Description = "PARALELISMO ",
            BoldDescription = "// | 0.1 | E | F",
            Gage = "G-1005-02",
            Sample = "1",
            InspectFrequency = "CADA 10",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp60", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "60",
            Description = "SIN BORDES AFILADOS ENTRE LOS PUNTOS J Y K ",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "INSPECCIÓN AL 100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> op20hDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "Calibración de Gages",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn85", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN85",
            Description = "Liberación de peso en maza ",
            BoldDescription = "3000 ",
            PostDescription = "gr.mm MAX",
            Gage = "Referencia AV-1125",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp48Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "48IP",
            Description = "Altura total 136.835 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm",
            Gage = "G-1020-01-A",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp74", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "74",
            Description = "Diametro 187.990 ",
            BoldDescription = "± 0.30 ",
            PostDescription = "mm",
            Gage = "G-6375-06",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp76", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "76",
            Description = "Diametro 192.790 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm",
            Gage = "G-1020-10",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn5", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN5",
            Description = "Localización 27.043 ",
            BoldDescription = "± 0.1 ",
            PostDescription = "mm",
            Gage = "G-1020-01-A",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn21", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN21",
            Description = "Altura 44.405 ",
            BoldDescription = "± 0.25 ",
            PostDescription = "mm",
            Gage = "G-1020-01-A",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn78", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN78",
            Description = "Espesor de la maza 10.5 ± 0.5 mm ",
            Gage = "G-1020-35",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp23", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "23",
            Description = "No se permite porosidad visual en el diámetro del sello, el área de las ranuras y el diámetro interno. La porosidad es permisible en otras superficies mecanizadas si menos de Ø1.5mm y menos de Ø1.0mm de profundidad",
            Gage = "Visual\nPara verificar piezas usar la plantlla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp34", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "34",
            Description = "Las rebabas, los bordes afilados y los materiales extraños resultantes de las buenas prácticas de fabricación son aceptables siempre que no sean perjuicios para el funcionamiento del ensamble o la manipulación segura según lo determine la ingeniería del motor",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

}