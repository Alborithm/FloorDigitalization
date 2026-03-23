using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;
using FloorDigitalization.L625.ViewModels;

namespace FloorDigitalization.L625.Views;

public partial class L625PostmaqView : UserControl
{
    public L625PostmaqView()
    {
        InitializeComponent();
        DataContext = new L625PostmaqViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ensamble", 
            "L625 | Ensamble",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(ensambleDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Postmaquinado", 
            "L625 | Postmaquinado",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(postmaquinadoDcps, "Second")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Pulido", 
            "L625 | Pulido",
            RecordNumber.Third,
            DcpControlCreator.CreateGrid(pulidoDcps, "Third")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Cuñero", 
            "L625 | Cuñero",
            RecordNumber.Forth,
            DcpControlCreator.CreateGrid(cuneroDcps, "Forth")));
    }

    private List<Dcp> ensambleDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "Calibrar los gages ",
            Gage = "De acuerdo a instructivo",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn02", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN",
            Description = "Localización 18.65 ",
            BoldDescription = "± 0.25 mm",
            Gage = "G-1015-25",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp64", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "64",
            Description = "El hule no debe exceder una protuberancia mayor a 2.0 mm o un hundimiento mayor a 2.0 mm",
            Gage = "Visual\nNota: parar piezas sospechosas usar gage G-1015-03",
            Sample = "1",
            InspectFrequency = "Inspeccpión 100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp67", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "67",
            Description = "Los componentes deben estar libres de rebabas o residuos que afecten la función o apariencia del ensamble",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inspeccpión 100%",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn32", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN 32",
            Description = "Presencia de ventana en maza (Poka Yoke)",
            Gage = "PY-244",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn18_1", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN 18",
            Description = "Espesor de la pintura E-Coat GMW 14671 16-22 μm Anillo",
            Gage = "ETG (Ecoat)",
            Sample = "1",
            InspectFrequency = "Inspección 1 pieza por contenedor de proveedor",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn18_2", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN 18",
            Description = "Espesor de la pintura E-Coat GMW 14671 16-22 μm Maza",
            Gage = "ETG (Ecoat)",
            Sample = "1",
            InspectFrequency = "Inspección 1 pieza por contenedor de proveedor",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn17", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN 17",
            Description = "La pieza debe estar pintada en todas las zonas. Libre de grumos de pintura",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn03", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN",
            Description = "El aceite debe estar libre de contaminaciones",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> postmaquinadoDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn01", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "SN",
            Description = "Calibrar los gages ",
            Gage = "De acuerdo a instructivo",
            Sample = "1",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp1s58", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1",
            Description = "Localización de raunuras 25.75 ",
            BoldDescription = "±0.25mm",
            PostDescription = "\n▶◀",
            Gage = "G-1015-08",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp3", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "3",
            Description = "Diametro de nariz de sello 50.0 ",
            BoldDescription = "±0.05mm",
            PostDescription = "\n▶◀",
            Gage = "G-1015-10",
            Sample = "1",
            InspectFrequency = "Cada 15 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp4", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "4",
            Description = "Run Out radial de la nariz de sello ",
            BoldDescription = "↗ | .025 | A",
            Gage = "G-1015-08",
            Sample = "1",
            InspectFrequency = "Cada 30 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp7", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "7",
            Description = "Rugosidad de diametro interior ",
            BoldDescription = "2.5 Ra MAX",
            Gage = "RDC-011",
            Sample = "1",
            InspectFrequency = "Cada hora",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp9", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "9",
            Description = "Paralelismo ",
            BoldDescription = "// | 0.15 | B",
            Gage = "G-1015-11",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp13", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "13",
            Description = "Run out radial diametro exterior ",
            BoldDescription = "↗ | 0.5 | A",
            Gage = "G-1015-08",
            Sample = "1",
            InspectFrequency = "Cada 30 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp15", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "15",
            Description = "Altura de back face 35.10 ",
            BoldDescription = "±0.15 mm",
            Gage = "G-1015-11",
            Sample = "1",
            InspectFrequency = "Cada 15 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp34_V", inputPerTurn: 2, start: true, mid: true, end: true)
        {
            Code = "34V",
            Description = "Diametro interior ",
            BoldDescription = "MIN 33.0175 - MAX 33.0425",
            PostDescription = "\n▶◀",
            Gage = "G-1015-12",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp34_A", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "34A",
            Description = "Diametro interior Ø 33.03 ± 0.0125 mm\n▶◀",
            Gage = "G-1015-13",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp136", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "136",
            Description = "Perpendicularidad ",
            BoldDescription = "⟂ | 0.05 | A",
            Gage = "G-1015-08",
            Sample = "1",
            InspectFrequency = "Cada 30 piezas",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn19", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n19",
            Description = "Run out radial ",
            BoldDescription = "↗ | 0.25 | A",
            PostDescription = "\n▶◀",
            Gage = "G-1015-08",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn20", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n20",
            Description = "Run out axial ",
            BoldDescription = "↗ | 0.25 | B",
            PostDescription = "\n▶◀",
            Gage = "G-1015-08",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp6566", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "65\n66",
            Description = "Condiciones visuales de acuerdo a las ayudas visuales (AV-1154) Porosidad de acuerdo a ayuda visual (AV-1155) ",
            Gage = "Visual\npara verificar piezas sospechosas de poros usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> pulidoDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp14", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "14",
            Description = "Distancia minima de pulido ± 0.25 mm",
            Gage = "G-1015-15",
            Sample = "1",
            InspectFrequency = "Cada 15 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp19Ra", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "19RA",
            Description = "Rugosidad de diametro exterior Ra ",
            BoldDescription = "0.25 - 0.80",
            Gage = "RDC-011",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp19Rz", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "19RZ",
            Description = "Rugosidad de diametro exterior Rz ",
            BoldDescription = "1.5 - 6.0",
            Gage = "RDC-011",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn22", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n22",
            Description = "Verificar la presencia de bruñido en diametro exterior",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> cuneroDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp28", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "28",
            Description = "Ancho de cuñero 4.83 ± 0.03 mm",
            Gage = "G-1015-17",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp32", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "32",
            Description = "Distancia de cuñero 36.36 ± 0.10 mm",
            Gage = "G-1015-18",
            Sample = "1",
            InspectFrequency = "Cada 15 piezas",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp6566", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "65\n66",
            Description = "Condición visual de acuerdo a la ayuda visual (AV-1154) y porosidad de acuerdo a ayuda visual (AV-1155)",
            Gage = "Visual\npara verificar piezas sospechosas de poros usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };
}