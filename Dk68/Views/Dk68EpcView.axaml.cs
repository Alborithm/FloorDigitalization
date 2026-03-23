using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using FloorDigitalization.Enums;
using FloorDigitalization.Dk68.ViewModels;
using FloorDigitalization.Helpers.Dcps;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.Dk68.Views;

public partial class Dk68EpcView : UserControl
{
    public Dk68EpcView()
    {
        InitializeComponent();
        DataContext = new Dk68EpcViewModel();
        var tabControl = this.FindControl<TabControl>("MainTabControl");
        tabControl!.Items.Add(DcpControlCreator.CreateTabItem("EPC", 
            "DK68 | EPC ",
            RecordNumber.First,
            DcpControlCreator.CreateGrid(epcDcps, "First")));
        
    }

    private List<Dcp> epcDcps = new List<Dcp>()
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
        new Dcp(code: "Dcp73",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "73",
            Description = "EL HULE NO DEBERA SOBRESALIR O ESTAR HUNDIDO MAS DE 2.0",
            Gage = "VISUAL\nNota: Piezas dudosas usar el G-1021-07 ",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp68",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "68",
            Description = "NO SE PERMITE PINTURA EN AREAS MAQUINADAS, LOS BARRENOS DE BALANCEO Y LA MUESCA DE TIEMPO PUEDEN IR PARCIALMENTE PINTADA",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
        new Dcp(code: "Dcp82",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "82",
            Description = "LA PIEZA DEBE DE IR LIBRE DE REBABA, FILOS QUE PUEDAN DETRIMENTAR EL ENSAMBLE SATISFACTORIO, EL MANEJO SEGURO O LA FUNCION DE LA PARTE",
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
        new Dcp(code: "Dcp72",inputPerTurn: 1, start: true, mid: true, end: true)
        {
            Code = "72",
            Description = "POROSIDAD PERMITIDA EN ZONAS MAQUINADAS MENORES DE 1.5  DIAMETRO Y 1 PROFUNDIDAD",
            Gage = "VISUAL",
            Sample = "1",
            InspectFrequency = "100%",
            IsCheckBox = true,
        },
    };
}