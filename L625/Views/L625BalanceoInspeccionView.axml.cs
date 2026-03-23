using System.Collections.Generic;
using Avalonia.Controls;
using FloorDigitalization.Enums;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;
using FloorDigitalization.L625.ViewModels;


namespace FloorDigitalization.L625.Views;

public partial class L625BalanceoInspeccionView : UserControl
{
    public L625BalanceoInspeccionView()
    {
        InitializeComponent();
        DataContext = new L625BalanceoInspeccionViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Balanceo/Estampado", "L625 | PBL024 - PMR052", RecordNumber.First, DcpControlCreator.CreateGrid(balanceoDcps, "First")));
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("Inspección", "L625 | Inspección GP-12", RecordNumber.Second, DcpControlCreator.CreateGrid(inspeccionDcps, "Second")));
    }

    private List<Dcp> balanceoDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp60", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "60",
            Description = "Peso ",
            BoldDescription = "N 180 g/mm",
            Gage = "PLC Control",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = false,
            ParentName = "Balanceo",
        },
        new Dcp("Dcp30", inputPerTurn: 1, start: true, mid: false, end: false)
        {
            Code = "30",
            Description = "Diametro de barrenos de balanceo Ø 6.0 MAX",
            Gage = "G-1015-19",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = true,
            ParentName = "Balanceo",
        },
        new Dcp("Dcp31", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "31",
            Description = "Profundidad de barrenos de balanceo 2.5 MAX",
            Gage = "G-1015-19",
            Sample = "1",
            InspectFrequency = "Cada 30 piezas",
            IsCheckBox = true,
            ParentName = "Balanceo",
        },
        new Dcp("Dcp33", inputPerTurn: 1, start:true, mid: false, end: false)
        {
            Code = "33",
            Description = "Localización de barrenos de balanceo R 80.6 ± 1.0 mm",
            Gage = "G-1015-19",
            Sample = "1",
            InspectFrequency = "Inicio de turno",
            IsCheckBox = true,
            ParentName = "Balanceo",
        },
        new Dcp("Dcp65_66", inputPerTurn: 1, start:true, mid: true, end: true)
        {
            Code = "65\n66",
            Description = "Condición visual de acuerdo a la ayuda visual (AV-1154) y porosidad de acuerdo a ayuda visual (AV-1155)",
            Gage = "Visual\nPara verificar piezas sospechosas de poros usar la plantilla F-2133-D",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Balanceo",
        },
        new Dcp("Dcp35", inputPerTurn: 1, start:true, mid: true, end: true)
        {
            Code = "35",
            Description = "2D code\n" + 
                "2 Digitos codigo de manufactura\n" +
                "2 Digitos el año\n" +
                "3 Digitos fecha juliana\n" +
                "1 Digito número de linea\n" +
                "4 Digitos número de pieza consecutiva\n" + 
                "8 Digitos número de parte",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Balanceo",
        },
    };

    private List<Dcp> inspeccionDcps = new List<Dcp>()
    {
        new Dcp(code: "Dcp34", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "34",
            Description = "Diametro interior Ø 33.03 ± 0.0125 mm\n▶◀",
            Gage = "G-1015-13",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        },
        new Dcp(code: "Dcp64", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "64",
            Description = "El hule no debe esceder una protuberancia mayor a 2.0 mm o un hundimiento mayor a 2.0 mm",
            Gage = "Visual Nota: para piezas sospechosas usar gage G-1015-03",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        },
        new Dcp(code: "DcpSn23", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN\n23",
            Description = "Aplicar anti-oxidante en areas maquinadas libres de pintura",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        },
        new Dcp(code: "Dcp67", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "67",
            Description = "Las piezas entregadas para el ensamblaje deben estar limpias y libres de residuos, material abrasivo y productos de corrosión que afecten adversamente la función o la apariencia",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        },
        new Dcp(code: "Dcp53", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "53",
            Description = "No se permite pintura en esta zona (zonas maquinadas) ranuras completamente pintadas",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        },
        new Dcp(code: "Dcp54", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "54",
            Description = "Barrenos libres de pintura",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        },
        new Dcp(code: "Dcp65", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "65",
            Description = "No se permite porosidad visual en el diámetro del sello. Se permite porosidad en otras superficies emcanizadas si miden menos de Ø 1,5mm y menos de 1,0mm de profundidad",
            Gage = "Visual\nPara verificar piezas sospechosas de poros usar la plantilla F-2133-D (Use la ayuda visual AV-1155 de referencia)",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        },
        new Dcp(code: "Dcp66", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "66",
            Description = "Las parted deben estar libres de rebabas, filos y falta de material, lo cual podria afectar un ensamble satisfactorio, un manejo seguro de la pieza o la funcionalidad de la misma",
            Gage = "Visual\n(Use la ayuda visual AV-1154 de referencia)",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        },
        new Dcp(code: "DcpSn_1", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN",
            Description = "Charolas libres de algún residuo (rebabas, residuos de pintura, etc.) que puedan provocar que el sello se contamine",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Inspección 100%",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        },
        new Dcp(code: "DcpSn_2", inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "SN",
            Description = "Verificar presencia de un solo cuñero libre de rebabas y golpes",
            Gage = "Visual",
            Sample = "1",
            InspectFrequency = "Al inicio de pallet",
            IsCheckBox = true,
            ParentName = "Inspeccion",
        }
    };
}