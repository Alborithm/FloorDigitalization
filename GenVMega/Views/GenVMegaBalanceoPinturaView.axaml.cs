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

public partial class GenVMegaBalanceoPinturaView : UserControl
{
    public GenVMegaBalanceoPinturaView()
    {
        InitializeComponent();
        DataContext = new GenVMegaBalanceoPinturaViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Balanceo 034", 
            "Gen V Mega | Balanceo 034",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(balanceoDcps, "First","Gage\nG-6387-XX CONFIRM GAGE")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Balanceo 055", 
            "Gen V Mega | Balanceo 055", 
            RecordNumber.Second, 
            DcpControlCreator.CreateGrid(balanceoDcps, "Second","Gage\nG-6387-XX CONFIRM GAGE")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PLV 025", 
            "Gen V Mega | PLV 025", 
            RecordNumber.Third, 
            DcpControlCreator.CreateGridPrelavadora(plv025Dcps, "Third", new Dictionary<int,string>
            {
                {1, "Prelavadora"}
            })));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("PLV 028", 
            "Gen V Mega | PLV 028", 
            RecordNumber.Forth, 
            DcpControlCreator.CreateGridPrelavadora(plv028Dcps, "Forth", new Dictionary<int,string>
            {
                {1, "Tina 1"},
                {10, "Tina 2"},
                {19, "Tina 3"}
            })));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Pintura", 
            "Gen V Mega | Pintura", 
            RecordNumber.Fifth, 
            DcpControlCreator.CreateGrid(pinturaDcps, "Fifth","Gage\nG-6387-XX CONFIRM GAGE")));
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
            Gage = "46",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp53", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "53",
            Description = "Diametro de barrenos de balanceo Ø 8.0 MAX",
            Gage = "47",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp54", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "54",
            Description = "Profundidad de barrenos de balanceo 8.0 MAX",
            Gage = "49",
            Sample = "1",
            InspectFrequency = "Inicio, mitad y final de turno",
            IsCheckBox = true,
        },
    };

    private List<LavadoraDcp> plv025Dcps = new List<LavadoraDcp>()
    {
        new LavadoraDcp(code: "Concentracion", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Description = "Concentración",
            Parametro = "20 - 30 gotas\n(Registrar cada 4 horas)",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Ph", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Description = "PH",
            Parametro = "Mayor o igual a 9\n(Registrat cada 4 horas)",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Temperatura",
            Parametro = "40°C - 55°C",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Nivel de tanque",
            Parametro = "Dentro del rango marcado por la linea verde",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Limpieza", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Limpieza de tanque",
            Parametro = "Desnatar",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Code = "",
            Gage = "",
            Sample = ""
        },
    };

    private List<LavadoraDcp> plv028Dcps = new List<LavadoraDcp>()
    {
        new LavadoraDcp(code: "Tina1Concentracion", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Description = "Concentración",
            Parametro = "20 - 30 gotas\n(Registrar cada 4 horas)",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina1Ph", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Description = "PH",
            Parametro = "Mayor o igual a 9\n(Registrat cada 4 horas)",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina1Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Temperatura",
            Parametro = "50°C - 60°C",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina1Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Nivel de tanque",
            Parametro = "Dentro del rango marcado por la linea verde",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina1Presion", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Presión de espreo",
            Parametro = "10-30 psi",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina1Limpieza", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Limpieza de tanque",
            Parametro = "Desnatar",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina2Concentracion", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Description = "Concentración",
            Parametro = "20 - 30 gotas\n(Registrar cada 4 horas)",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina2Ph", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Description = "PH",
            Parametro = "Mayor o igual a 9\n(Registrat cada 4 horas)",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina2Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Temperatura",
            Parametro = "50°C - 60°C",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina2Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Nivel de tanque",
            Parametro = "Dentro del rango marcado por la linea verde",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina2Presion", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Presión de espreo",
            Parametro = "10-30 psi",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina2Limpieza", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Limpieza de tanque",
            Parametro = "Desnatar",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina3Concentracion", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Description = "Concentración",
            Parametro = "20 - 30 gotas\n(Registrar cada 4 horas)",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina3Ph", inputPerTurn: 1, start: true, mid: true, end: false)
        {
            Description = "PH",
            Parametro = "Mayor o igual a 9\n(Registrat cada 4 horas)",
            InspectFrequency = "Inicio y mitad de turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina3Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Temperatura",
            Parametro = "50°C - 60°C",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina3Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Nivel de tanque",
            Parametro = "Dentro del rango marcado por la linea verde",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina3Presion", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Presión de espreo",
            Parametro = "10-30 psi",
            InspectFrequency = "Cada turno",
            IsCheckBox = false,
            Code = "",
            Gage = "",
            Sample = ""
        },
        new LavadoraDcp(code: "Tina3Limpieza", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Description = "Limpieza de tanque",
            Parametro = "Desnatar",
            InspectFrequency = "Cada turno",
            IsCheckBox = true,
            Code = "",
            Gage = "",
            Sample = ""
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
        new Dcp(code: "DcpSn_34", inputPerTurn: 1, start: true, mid: false, end: false)
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