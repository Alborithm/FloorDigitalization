using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Dk68.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Dk68.Views;

public partial class Dk68PintadoEstampadoInspeccionView : UserControl
{
    public Dk68PintadoEstampadoInspeccionView()
    {
        InitializeComponent();
        DataContext = new Dk68PintadoEstampadoInspeccionViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Pintado", 
            "DK68 | Pintado PPT-03 | 60A",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(pintadoDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Estampado", 
            "DK68 | Estampado PMR-050 | 70A",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(estampadoDcps, "Second")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Inspección", 
            "DK68 | Inspeccion Final Empaque | 80A",
            RecordNumber.Third,
            DcpControlCreator.CreateGrid(inspeccionDcps, "Third")));
        
    }

    private List<Dcp> pintadoDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn23", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n23",
            Description = "ESPESOR DE PINTURA DE ",
            BoldDescription = "2.0 A 5.0 MILLS",
            Gage = "ETG",
            Sample = "1",
            InspectFrequency = "INICIO, MITAD  Y FINAL DE TURNO ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp66", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "66",
            Description = "BARRENOS DE BALANCEO Y MUESCA DE TIEMPO PUEDEN IR PARCIALMENTE PINTADOS ",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "INICIO, MITAD  Y FINAL DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn27", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "SN\n27",
            Description = "VISCOSIDAD",
            BoldDescription = "32 - 38 SEC.",
            Gage = "ZAHN (LAB)",
            Sample = "1",
            InspectFrequency = "CADA QUE SE RELLENE EL TAMBO ",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp65", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "65",
            Description = "NO SE PERMITE PINTURA EN ESTA ZONA (Zonas maquinadas) RANURAS COMPLETAMENTE PINTADAS",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> estampadoDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp52",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "52",
            Description = @"ESTAMPADO 2D DEBE CONTENER
PROGRAMA ID :8
TIPO DE COMPONENTE: E
SITIO DE MANUFACTURA: 44 
AÑO: 24
FECHA JULIANA: XXX
CODIGO DE LINEA: 8
SECUENCIA: 0001 
NUMERO DE PARTE: 12723441",
            Gage = "LECTOR 2D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp71",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "71",
            Description = "FECHA JULIANA EN ESTAMPADO DE LA CARA DEL BACK FACE",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp53",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "53",
            Description = "DISTANCIA 5.7",
            Gage = "PLANTILLA",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp58",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "58",
            Description = "DISTANCIA SEGÚN LA MEDIA DEL CENTRO DE LA PIEZA\n20",
            Gage = "PLANTILLA",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp57",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "57",
            Description = "ANCHO 6.08",
            Gage = "PLANTILLA",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn2_9",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN2\n9",
            Description = "POSICION DEL ESTAMPADO 90°",
            Gage = "VISUAL\nAYUDA VISUAL 1229",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };

    private List<Dcp> inspeccionDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp52",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "52",
            Description = @"ESTAMPADO 2D DEBE CONTENER 
PROGRAMA ID :8
TIPO DE COMPONENTE: E
SITIO DE MANUFACTURA: 44 
AÑO: 24
FECHA JULIANA: XXX
CODIGO DE LINEA: 8
SECUENCIA: 0001 
NUMERO DE PARTE: 12723441",
            Gage = "LECTOR 2D",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp71",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "71",
            Description = "FECHA JULIANA EN ESTAMPADO DE LA CARA DEL BACK FACE",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp73",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "73",
            Description = "EL HULE NO DEBERA SOBRESALIR O ESTAR HUNDIDO MAS DE 2.0",
            Gage = "VISUAL\nNota: Piezas dudosas usar el G-1021-07 ",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp66",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "66",
            Description = "NO SE PERMITE PINTURA EN AREAS MAQUINADAS, LOS BARRENOS DE BALANCEO Y LA MUESCA DE TIEMPO PUEDEN IR PARCIALMENTE PINTADA",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp148",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "148",
            Description = "LA PIEZA DEBE DE IR LIBRE DE REBABA, FILOS QUE PUEDAN DETRIMENTAR EL ENSAMBLE SATISFACTORIO, EL MANEJO SEGURO O LA FUNCION DE LA PARTE",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp65",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "65",
            Description = "NO SE PERMITE PINTURA EN ESTA ZONA (Zonas maquinadas) RANURAS COMPLETAMENTE PINTADAS",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN",
            Description = "PRESENCIA DE MUESCA",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn28",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n28",
            Description = "PRESENCIA DE BARRENOS DE BALANCEO",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp80",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "80",
            Description = "PARTE LIMPIA, LIBRE DE REBABA, OXIDO, CORROSION QUE PUEDA AFECTAR AL ENSAMBLE O FUNCIONAMIENTO",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp72",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "72",
            Description = "POROSIDAD PERMITIDA EN ZONAS MAQUINADAS MENORES DE 1.5  DIAMETRO Y 1 PROFUNDIDAD",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp44",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "44",
            Description = "DIAMETRO\n4X 11.5+/-0.1",
            Gage = "G-1021-04",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "DcpSn2_9",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN2\n9",
            Description = "POSICION DEL ESTAMPADO\n90°",
            Gage = "VISUAL\nAYUDA VISUAL 1229",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp30", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "30",
            Description = "DIAMETRO INTERIOR ",
            BoldDescription = "17.06+/-0.015",
            Gage = "CMM-002",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
        },
    };
}