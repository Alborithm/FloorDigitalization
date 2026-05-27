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
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 010W", 
            "Multilinea | Truck | PTN-117 | 010W ",
            RecordNumber.Third,
            DcpControlCreator.CreateGrid(op10wDcps, "Third")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 020W", 
            "Multilinea | Truck | PTN-117 | 020W ",
            RecordNumber.Forth,
            DcpControlCreator.CreateGrid(op20wDcps, "Forth")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Truck 010A", 
            "Multilinea | Truck | PPE-037 | 010A ",
            RecordNumber.Fifth,
            DcpControlCreator.CreateGrid(op10aDcps, "Fifth")));
    }

    // TODO replace with the Multilinea 10H CTSV Data

    private List<Dcp> op10hDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "CALIBRAR LOS GAGES ",
            Gage = "DE ACUERDO A INSTRUCTIVO",
            Sample = "1",
            InspectFrequency = "INICIO Y MITAD DE TURNO ",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp57Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "57IP",
            Description = "Diametro exterior de mamelon 55.6 ",
            BoldDescription = "± 0.2 mm ",
            Gage = "G-1004-25",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp87Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "87IP",
            Description = "Diametro interior 36.10 ± 0.15 mm",
            Gage = "G-1020-03",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp119", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "119",
            Description = "Diametro exterior 2x 157.00 ",
            BoldDescription = "± 0.10 mm ",
            Gage = "G-1020-01-A",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp66Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "66IP",
            Description = "Altura back face a mamelon ",
            BoldDescription = "38.29 ± 0.40 mm",
            Gage = "G-6397-13",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp95Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "95IP",
            Description = "Altura ",
            BoldDescription = "22.75 ± 0.25 mm ",
            Gage = "G-6397-13",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp96Ip", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "96IP",
            Description = "Altura ",
            BoldDescription = "25.35 ± 0.25 mm",
            Gage = "G-6397-13",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
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

    private List<Dcp> op10wDcps = new List<Dcp>()
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
        new Dcp(code: "DcpSn20", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n20",
            Description = "Diametro exterior 199.50 ",
            BoldDescription = "± 0.25 mm",
            Gage = "G-1020-11",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn81", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN\n81",
            Description = "52.3 ",
            BoldDescription = "± 0.25 mm",
            Gage = "CALIPER",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
        },
    };

    private List<Dcp> op20wDcps = new List<Dcp>()
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
        new Dcp(code: "Dcp131Ip", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "131IP",
            Description = "Altura\n51.05",
            BoldDescription = "± 0.25 mm",
            Gage = "G-1020-33",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp135", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "135",
            Description = "Diamtero interior\n2x168.40 ",
            BoldDescription = "± 0.15 mm",
            Gage = "G-6397-47",
            Sample = "1",
            InspectFrequency = "Cada 10 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp139", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "139",
            Description = "Rugosidad\n",
            BoldDescription = "4.0 - 6.5 Ra",
            Gage = "RDC-010",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp142", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "142",
            Description = "Distancia\n",
            BoldDescription = "25.0 ± 0.1 mm",
            Gage = "CMM-001",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp23", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "23",
            Description = "No se permite porosidad visual en el diámetro de sello, el área de las ranuras y el diámetro interno\nLa porosidad es permisible en otras superficies mecanizadas si menos de Ø 1.5 mm y menos de 1.00 mm de profundidad",
            Gage = "Visual\nPara verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp34", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "34",
            Description = "Las rebabas, los bordes afilados y los materiales extraños resultantes de las buenas prácticas de fabricación son aceptables siempre que no sean prejuicios para el funcionamiento del ensamblaje o la manipulación segura según lo determine la ingeniería del motor",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> op10aDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp22", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "22",
            Description = "El hule no puede sobresalir mas de 2 mm ni estar empotrado mas de 2 mm de las superficies metalicas adyacentes. ",
            Gage = "Visual\nEn caso de duda usar gage G-6400-20",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn33", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN33",
            Description = "Altura 98.805",
            BoldDescription = "± 0.4",
            Gage = "G-1012-25-2",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp23", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "23",
            Description = "No se permite porosidad visual en el diametro del sello. el área de las ranuras y el diámetro interno\n la porosidad es permisible en otras superficies mecanizadas si menos de Ø1.5 mm y menos de 1.0 mm de profuncidad",
            Gage = "Visual\nPara verificar piezas usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp34", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "34",
            Description = "Las rebabas, los bordes afilados y los materiales extraños resultantes de las buenas prácticas de fabricación son aceptables siempre que no sean prejuicios para el funcionamiento del ensamblaje o la manipulación segura según lo determine la ingeniería del motor",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };
}