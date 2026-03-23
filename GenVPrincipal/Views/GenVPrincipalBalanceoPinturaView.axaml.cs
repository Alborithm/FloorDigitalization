using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.GenVPrincipal.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.GenVPrincipal.Views;

public partial class GenVPrincipalBalanceoPinturaView : UserControl
{
    public GenVPrincipalBalanceoPinturaView()
    {
        InitializeComponent();
        DataContext = new GenVPrincipalBalanceoPinturaViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        // Change description of the gage to G-1019-XX
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Balanceo", 
            "Gen V Principal | Balanceo",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(balanceoDcps, "First", "Gage\nG-1012-XX")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PLV-017", 
            "Gen V Principal | Prelavadora PLV-017",
            RecordNumber.Second,
            DcpControlCreator.CreateGridPrelavadora(plv017Dcps, "Second", new Dictionary<int, string>
            {
                {1, "Prelavadora"},
            })));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PLV-002", 
            "Gen V Principal | PLV-002",
            RecordNumber.Third,
            DcpControlCreator.CreateGridPrelavadora(plv002Dcps, "Third", new Dictionary<int, string>
            {
                {1, "Tina 1"},
                {10, "Tina 2"},
                {19, "Tina 3"},
            })));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Pintura", 
            "Gen V Principal | Pintura",
            RecordNumber.Forth,
            DcpControlCreator.CreateGrid(pinturaDcps, "Forth", "Gage\nG-1012-XX")));
    }

    private List<Dcp> balanceoDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp71", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "71",
            Description = "El damper ensamblado debera estar en balanceo estatico maximo ",
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
            Gage = "34",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp53", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "53",
            Description = "Diametro de barrenos de balanceo Ø 8.0 MAX",
            Gage = "35",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp54", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "54",
            Description = "Profundidad de barrenos de balanceo 8.0 MAX",
            Gage = "35",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        }
    };

    private List<LavadoraDcp> plv017Dcps = new List<LavadoraDcp>()
    {
        new LavadoraDcp(code: "Concentracion", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "Concentración",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "20 - 30 gotas\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Ph", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "PH",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Mayor o igual a 9\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Temperatura",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "40°C - 55°C",
        },
        new LavadoraDcp(code: "Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Nivel de tanque",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Dentro del rango marcado por la linea verde",
        },
        new LavadoraDcp(code: "Limpieza", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Limpieza de tanque",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Desnatar",
        }
    };

    private List<LavadoraDcp> plv002Dcps = new List<LavadoraDcp>()
    {
        new LavadoraDcp(code: "Tina1Concentracion", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "Concentración",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "20 - 30 gotas\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Tina1Ph", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "PH",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Mayor o igual a 9\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Tina1Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Temperatura",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "50°C - 60°C",
        },
        new LavadoraDcp(code: "Tina1Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Nivel de tanque",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Dentro del rango marcado por la linea verde",
        },
        new LavadoraDcp(code: "Tina1Presion", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Presión de espreo",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "10-30 psi",
        },
        new LavadoraDcp(code: "Tina1Limpieza", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Limpieza de tanque",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Desnatar",
        },
        new LavadoraDcp(code: "Tina2Concentracion", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "Concentración",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "20 - 30 gotas\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Tina2Ph", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "PH",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Mayor o igual a 9\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Tina2Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Temperatura",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "50°C - 60°C",
        },
        new LavadoraDcp(code: "Tina2Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Nivel de tanque",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Dentro del rango marcado por la linea verde",
        },
        new LavadoraDcp(code: "Tina2Presion", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Presión de espreo",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "10-30 psi",
        },
        new LavadoraDcp(code: "Tina2Limpieza", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Limpieza de tanque",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Desnatar",
        },
        new LavadoraDcp(code: "Tina3Concentracion", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "Concentración",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "20 - 30 gotas\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Tina3Ph", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Code = "NA",
            Description = "PH",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Mayor o igual a 9\n(Registrar cada 4 horas)",
        },
        new LavadoraDcp(code: "Tina3Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Temperatura",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "50°C - 60°C",
        },
        new LavadoraDcp(code: "Tina3Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Nivel de tanque",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Dentro del rango marcado por la linea verde",
        },
        new LavadoraDcp(code: "Tina3Presion", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Presión de espreo",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Gage = "NA",
            Sample = "NA",
            Parametro = "10-30 psi",
        },
        new LavadoraDcp(code: "Tina3Limpieza", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "Limpieza de tanque",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Gage = "NA",
            Sample = "NA",
            Parametro = "Desnatar",
        },
    };

    private List<Dcp> pinturaDcps = new List<Dcp>()
    {
        new Dcp(code: "DcpSn_31", inputPerTurn: 3, start: true, mid: false, end: true)
        {
            Code = "SN\n31",
            Description = "Espesor de pintura de 2.0 a 5.0 mills\n*Cara de anillo\n*Cinturon\n*Area de casting",
            Gage = "ETG",
            Sample = "1",
            InspectFrequency = "Inicio y final de turno",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn_34", inputPerTurn: 1, start: false, mid: false, end: false)
        {
            Code = "SN\n34",
            Description = "Viscosidad ",
            BoldDescription = "32 - 38 SEC.",
            Gage = "ZAHN (Lab)",
            Sample = "1",
            InspectFrequency = "Cada que se rellene el tambo",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp77", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "77",
            Description = "Piezas sin hojuelas desprendibles de pintura",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp65_67", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "65\n67",
            Description = "No se permitepintura en esta zona (zonas maquinadas) ranuras completamente pintadas",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "100 %",
            IsCheckBox = true,
        },
    };
    
}