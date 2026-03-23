using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Dk68.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Dk68.Views;

public partial class Dk68MuescaBalanceoLavadoraView : UserControl
{
    public Dk68MuescaBalanceoLavadoraView()
    {
        InitializeComponent();
        DataContext = new Dk68MuescaBalanceoLavadoraViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Muesca", 
            "DK68 | Muesca PCM-062 | 30A",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(muescaDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Balanceo PBL-038", 
            "DK68 | Balanceo PBL-038 | 40A",
            RecordNumber.Second,
            DcpControlCreator.CreateGrid(balanceoDcps, "Second")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Balanceo PBL-023", 
            "DK68 | Balanceo PBL-023 | 40A",
            RecordNumber.Third,
            DcpControlCreator.CreateGrid(balanceoDcps, "Third")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PVL-006", 
            "DK68 | Lavadora PVL-006 | 50A",
            RecordNumber.Forth,
            DcpControlCreator.CreateGridPrelavadora(lavadoraDcps, "Forth", new Dictionary<int, string>
            {
                {1, "Prelavadora"},
                {5, "Tina 1"},
                {14, "Tina 2"},
                {17, "Tina 3"},
                {25, "Tina 4"},
            })));
    }

    private List<Dcp> muescaDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp50",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "50",
            Description = "DISTANCIA ",
            BoldDescription = "2+/-0.5",
            Gage = "CMM-001",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp54",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "54",
            Description = "ANGULO DE MUESCA 55.5 ",
            BoldDescription = "+/-3",
            Gage = "G-1021-06",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp55",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "55",
            Description = "ANCHO DE LA MUESCA 1.5+/-.25",
            Gage = "G-1021-05",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = true,
        },
    };

    private List<Dcp> balanceoDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp2_1",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "2",
            Description = "DIAMETRO DE BARRENOS 12 MAX ",
            Gage = "G-1021-03",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp2_2",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "2",
            Description = "PROFUNDIDAD 8 MAX ",
            Gage = "G-1021-03",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp1",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "1",
            Description = "LOCALIZACION DE BARRENOS DE BALANCEO 14+/-1 ",
            Gage = "G-1021-02",
            Sample = "1",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp3",inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "3",
            Description = "DISTANCIA ENTRE BARRENOS ",
            BoldDescription = "3 MIN",
            Gage = "VERNIER",
            Sample = "1",
            InspectFrequency = "CADA HORA",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn28",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n28",
            Description = "PRESENCIA DE BARRENOS DE BALANCEO ",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp16",inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "16",
            Description = "EL DAMPER ENSAMBLADO DEBERA ESTAR EN BALANCEO ESTATICO 74.35 KG*MM ",
            BoldDescription = "+/- 0.18 KG*MM",
            Gage = "PBL-023",
            Sample = "1",
            InspectFrequency = "INICIO Y MITAD DE TURNO",
            IsCheckBox = false,
        },
    };

    private List<LavadoraDcp> lavadoraDcps = new List<LavadoraDcp>()
    {
        new LavadoraDcp(code: "PrelavadoraAlcalinidad",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "ALCALINIDAD TOTAL",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
            Parametro = "7 - 10",
        },
        new LavadoraDcp(code: "PrelavadoraTemperatura",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "TEMPERATURA",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
            Parametro = "40°C - 55°C",
        },
        new LavadoraDcp(code: "PrelavadoraNivel",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "NIVEL DE TANQUE ",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
            Parametro = "DENTRO DEL RANGO MARCADO POR LA LINEA VERDE",
        },
        new LavadoraDcp(code: "Tina1AcidezTotal",inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "ACIDEZ TOTAL (Bonderite MFE 2557)",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO Y MITAD DE TURNO",
            IsCheckBox = false,
            Parametro = "15 - 17 PUNTOS\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Tina1AcidezLibre",inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "ACIDEZ LIBRE",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO Y MITAD DE TURNO",
            IsCheckBox = false,
            Parametro = "0 - 0.3 (COLOR VERDE OK)\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Tina1Presion",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "PRESIÓN DE ESPREO",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
            Parametro = "10 - 30 PSI",
        },
        new LavadoraDcp(code: "Tina1Temperatura",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "TEMPERATURA",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
            Parametro = "50°C - 60°C",
        },
        new LavadoraDcp(code: "Tina1Limpieza",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "LIMPIEZA DE TANQUE",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
            Parametro = "DESNATAR",
        },
        new LavadoraDcp(code: "Tina1Nivel",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "NIVEL DE TANQUE",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
            Parametro = "DENTRO DEL RANGO MARCADO POR LA LINEA VERDE",
        },
        new LavadoraDcp(code: "Tina2Presion",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "PRESIÓN DE ESPREO",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
            Parametro = "10 - 30 PSI",
        },
        new LavadoraDcp(code: "Tina2Nivel",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "NIVEL DE TANQUE",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
            Parametro = "DENTRO DEL RANGO MARCADO POR LA LINEA VERDE",
        },
        new LavadoraDcp(code: "Tina3Concentracion",inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "CONCENTRACION Bonderite MPT 99X)",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO Y MITAD DE TURNO",
            IsCheckBox = false,
            Parametro = "7.0 - 9.0",
        },
        new LavadoraDcp(code: "Tina3Ph",inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "PH",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO Y MITAD DE TURNO",
            IsCheckBox = false,
            Parametro = "4.5 - 5.5",
        },
        new LavadoraDcp(code: "Tina3Presion",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "PRESIÓN DE ESPREO",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
            Parametro = "10 - 30 PSI",
        },
        new LavadoraDcp(code: "Tina3Limpieza",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "LIMPIEZA DE TANQUE ",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
            Parametro = "DESNATAR ",
        },
        new LavadoraDcp(code: "Tina3Nivel",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "NIVEL DE TANQUE",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
            Parametro = "DENTRO DEL RANGO MARCADO POR LA LINEA VERDE",
        },
        new LavadoraDcp(code: "Tina4Presion",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "PRESIÓN DE ESPREO",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = false,
            Parametro = "10 - 30 PSI",
        },
        new LavadoraDcp(code: "Tina4Nivel",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "NIVEL DE TANQUE",
            Gage = "NA",
            Sample = "NA",
            InspectFrequency = "INICIO DE TURNO",
            IsCheckBox = true,
            Parametro = "DENTRO DEL RANGO MARCADO POR LA LINEA VERDE",
        },
    };
}