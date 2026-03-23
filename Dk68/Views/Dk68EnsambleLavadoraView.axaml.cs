using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Dk68.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;
using Avalonia.Platform;

namespace FloorDigitalization.Dk68.Views;

public partial class Dk68EnsambleLavadoraView : UserControl
{
    public Dk68EnsambleLavadoraView()
    {
        InitializeComponent();
        DataContext = new Dk68EnsambleLavadoraViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Ensamble", 
            "DK68 | Ensamble PPE-022 | 20A",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(ensambleDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Fosfatizadora/Lavadora", 
            "DK68 | PVL-002 | 10A",
            RecordNumber.Second,
            DcpControlCreator.CreateGridPrelavadora(lavadoraDcps, "Second",  new Dictionary<int, string>
            {
                { 1, "Prelavadora"}
            })));
        
    }

    private List<Dcp> ensambleDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp30",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "30",
            Description = "RUN OUT",
            BoldDescription = "↗ | 0.35 | A | B",
            Gage = "G-1021-01",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp21",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "21",
            Description = "RUN OUT",
            BoldDescription = "↗ | 0.35 | A | B",
            Gage = "G-1021-01",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = false,
        },
        new Dcp(code: "Dcp19",inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "19",
            Description = "DISTANCIA 63",
            BoldDescription = "+/- 0.35",
            Gage = "G-1021-01",
            Sample = "1",
            InspectFrequency = "CADA 10 PIEZAS",
            IsCheckBox = false,
        },
        new Dcp(code: "DcpSn30",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n30",
            Description = "ALIENACION DEL ANILLO",
            Gage = "VISUAL\nNota: referente a la AV-1259",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp73",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "73",
            Description = "EL HULE NO DEBERA SOBRESALIR O ESTAR HUNDIDO MAS DE 2.0",
            Gage = "VISUAL\nNota: Piezas dudosas usar G-1021-07",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        }
    };

    private List<LavadoraDcp> lavadoraDcps = new List<LavadoraDcp>()
    {
        new LavadoraDcp(code: "Alcalinidad", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "ALCALINIDAD TOTAL",
            Gage = "NA",
            Sample = "1",
            InspectFrequency = "CADA TURNO",
            IsCheckBox = false,
            Parametro = "7 - 10"
        },
        new LavadoraDcp(code: "Temperatura", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "TEMPERATURA",
            Gage = "NA",
            Sample = "1",
            InspectFrequency = "CADA TURNO",
            IsCheckBox = false,
            Parametro = "40°C - 55°C"
        },
        new LavadoraDcp(code: "Nivel", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "NA",
            Description = "NIVEL DE TANQUE",
            Gage = "NA",
            Sample = "1",
            InspectFrequency = "CADA TURNO",
            IsCheckBox = true,
            Parametro = "DENTRO DEL RANGO MARCADO POR LA LINEA VERDE"
        },
    };
}