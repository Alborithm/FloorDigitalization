using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using CsvHelper;
using FloorDigitalization.Models;
using FloorDigitalization.Enums;
using FloorDigitalization.L625.ViewModels;
using Avalonia.Controls.Documents;
using Avalonia.Input.TextInput;
using FloorDigitalization.Duramax.Models;

namespace FloorDigitalization.Helpers;

public static class MyCsvHelper
{
    private static readonly string routeLocal = "C:\\IT\\ControlCalidad\\NuevosDatos";
    // L625 Postmaquinado
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn28\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - L625";
    // L625 Balanceo Inspeccion
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn29\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - L625";

    // ---------------Gen V Principal -------------

    // GenV Principal anillos
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn19.MUVIQ\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Principal";
    // GenV Principal Mazas Ensamble 
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn26\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Principal";
    // GenV Principal Postmaquinado Pulido Cunero
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn15\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Principal";
    // GenV Principal Balanceo Pintura Lavadora
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn27\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Principal";


    // -------------- Gen V Mega ------------------
    // Mega Postmaquinado Pared
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn11\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega";

    // Mega Postmaquinado Pasillo
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn8.DAYCO\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega";
    
    // Mega Anillos Pasillo
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn17.MUVIQ\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega";
    // Mega Anillos Pared
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn16.MUVIQ\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega";
    // Mega Mazas Ensamble Pasillo
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn21\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega";

    // Mega Mazas Ensamble PARED
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn20\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega";

    // MEGA Pulido Cunero 
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn22\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega";

    // Mega Balanceo Pintura
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn23\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega";


    // --------------- MINI -----------------

    // MINI Cunero Pulido Balanceo
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn25\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mini";
    // MINI Mazas Ensamble
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn24\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mini";
    // MINI Anillos
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn18.MUVIQ\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mini";
    // MINI Postmaquinado
    // private static readonly string routeShared = "C:\\Users\\slp.wkstn14\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mini";



    // Personal 
    private static readonly string routeShared = "C:\\Users\\gerardo.albor\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - Documentos\\Calidad\\ControlCalidad\\Test";

    // ------------- L625 ---------------
    private static readonly List<PhaseFieldMap> _fieldMaps625Cunero = new()
    {
        new() { BaseName = "Dcp28",         StartHasValue = true, MidHasValue = false,  EndHasValue = false },
        new() { BaseName = "Dcp32",         StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp6566",       StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
    };

    private static readonly List<PhaseFieldMap> _fieldMaps625Ensamble = new()
    {
        new() { BaseName = "DcpSn01",      StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "DcpSn02",      StartHasValue = true, MidHasValue = true,  EndHasValue = true  },
        new() { BaseName = "Dcp64",        StartHasValue = true, MidHasValue = true,  EndHasValue = true  },
        new() { BaseName = "Dcp67",        StartHasValue = true, MidHasValue = true,  EndHasValue = true  },
        new() { BaseName = "DcpSn32",      StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "DcpSn18_1",    StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "DcpSn18_2",    StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "DcpSn17",      StartHasValue = true, MidHasValue = true,  EndHasValue = true  },
        new() { BaseName = "DcpSn03",      StartHasValue = true, MidHasValue = true,  EndHasValue = true  },
    };

    private static readonly List<PhaseFieldMap> _fieldMaps625Postmaquinado = new()
    {
        new() { BaseName = "DcpSn01",         StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Dcp1s58",         StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp3",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp4",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp7",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp9",            StartHasValue = true, MidHasValue = false,  EndHasValue = false  },
        new() { BaseName = "Dcp13",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp15",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp34_V_1",       StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp34_V_2",       StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp34_A",         StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp136",          StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "DcpSn19",         StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "DcpSn20",         StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp6566",         StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
    };

    private static readonly List<PhaseFieldMap> _fieldMaps625Pulido = new()
    {
        new() { BaseName = "Dcp14",         StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp19Ra",       StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp19Rz",       StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "DcpSn22",       StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
    };

    private static readonly List<PhaseFieldMap> _fieldMaps625Balanceo = new()
    {
        new() { BaseName = "Dcp60",         StartHasValue = true, MidHasValue = false,  EndHasValue = false },
        new() { BaseName = "Dcp30",         StartHasValue = true, MidHasValue = false,  EndHasValue = false },
        new() { BaseName = "Dcp31",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp33",         StartHasValue = true, MidHasValue = false,  EndHasValue = false },
        new() { BaseName = "Dcp65_66",      StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp35",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMaps625Inspeccion = new()
    {
        new() { BaseName = "Dcp34",         StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp64",         StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "DcpSn23",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp67",         StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp53",         StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp54",         StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp65",         StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp66",         StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "DcpSn_1",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "DcpSn_2",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
    };

    // ------------- Gen V Principal ---------------

    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalAnillos = new ()
    {
        new() { BaseName = "DcpSn01",       StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "Dcp133",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp134",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp8_1",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp8_2",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp11_1",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp11_2",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp11_3",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp130",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp160",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp132_1",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp132_2",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp10_1",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp10_2",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp10_3",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp131",        StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "Dcp77_161",     StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "DcpSn02",       StartHasValue = true, MidHasValue = false, EndHasValue = false },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalEnsamble = new ()
    {
        new() { BaseName = "Dcp76",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalMazas = new ()
    {
        new() { BaseName = "DcpSn01",       StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "DcpSn02",       StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "Dcp174_1",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp174_2",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp172",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp173",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp42_Ip",      StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "Dcp25_Ip",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp77_161",     StartHasValue = true, MidHasValue = true,  EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalPostmaquinado = new()
    {
        new() { BaseName = "DcpSn01",         StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Dcp1",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp2",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp4",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp5",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp9a",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp9b",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp12",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp16",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp38",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp6",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp7",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp18",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp22",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp24",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp25",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp26",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp20ip",         StartHasValue = true, MidHasValue = false,  EndHasValue = false  },
        new() { BaseName = "Dcp42",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalPulido = new()
    {
        new() { BaseName = "DcpSn01",         StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Dcp36A",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp36B_1",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp36B_2",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp36B_3",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp19",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp20_1",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp20_2",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp15",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSn_10",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp77_161",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalCunero = new()
    {
        new() { BaseName = "Dcp47",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp50_48",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSN_77",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalPlv017 = new()
    {
        new() { BaseName = "Concentracion",            StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Ph",                       StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Temperatura",              StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalPlv002 = new()
    {
        new() { BaseName = "Tina1Concentracion",            StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina1Ph",                       StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina1Temperatura",              StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1Presion",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Concentracion",            StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina2Ph",                       StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina2Temperatura",              StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Presion",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Concentracion",            StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina3Ph",                       StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina3Temperatura",              StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Presion",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalBalanceo = new()
    {
        new() { BaseName = "Dcp71",            StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Dcp3",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp53",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp54",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    // This one has a special case wit DCP SN 34 where it can be saved any time
    private static readonly List<PhaseFieldMap> _fieldMapsGenVPrincipalPintura = new()
    {
        new() { BaseName = "DcpSn_31_1",       StartHasValue = true, MidHasValue = false,   EndHasValue = true },
        new() { BaseName = "DcpSn_31_2",       StartHasValue = true, MidHasValue = false,   EndHasValue = true },
        new() { BaseName = "DcpSn_31_3",       StartHasValue = true, MidHasValue = false,   EndHasValue = true },
        new() { BaseName = "DcpSn_34",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp77",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp65_67",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    // ------------- MEGA ---------------
    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaPostmaquinado = new()
    {
        new() { BaseName = "DcpSn01",         StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Dcp1",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp2",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp4",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp5",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp9a",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp9b",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp36a",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp36b_1",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp36b_2",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp36b_3",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp12",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp15",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp16",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp38",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp24",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp20ip",         StartHasValue = true, MidHasValue = false,  EndHasValue = false  },
        new() { BaseName = "Dcp22",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp25",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp26",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp42",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp6",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp7",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "DcpSn02",           StartHasValue = true, MidHasValue = false,   EndHasValue = false  },
    };


    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaMazas = new ()
    {
        new() { BaseName = "DcpSn01",       StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "DcpSn02",       StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "Dcp174_1",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp174_2",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp172",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp173",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp42_Ip",      StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "Dcp77_161",     StartHasValue = true, MidHasValue = true,  EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaEnsamble = new ()
    {
        new() { BaseName = "Dcp76",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaAnillos = new ()
    {
        new() { BaseName = "DcpSn01",       StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "Dcp133",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp134",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp8_1",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp8_2",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp11_1",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp11_2",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp130",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp160",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp132_1",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp132_2",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp10_1",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp10_2",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp10_3",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp131",        StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "Dcp77_161",     StartHasValue = true, MidHasValue = true,  EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaCunero = new()
    {
        new() { BaseName = "Dcp47",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp50_48",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp36",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSN_77",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp77_161",        StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaPulido = new()
    {
        new() { BaseName = "Dcp19",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp20_1",          StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp20_2",          StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSN_10",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaPrelavadora = new()
    {
        new() { BaseName = "Alcalinidad",       StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Temperatura",       StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Nivel",             StartHasValue = true, MidHasValue = false,   EndHasValue = false },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaPlv025 = new()
    {
        new() { BaseName = "Concentracion",            StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Ph",                       StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Temperatura",              StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaPlv028 = new()
    {
        new() { BaseName = "Tina1Concentracion",            StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina1Ph",                       StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina1Temperatura",              StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1Presion",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Concentracion",            StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina2Ph",                       StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina2Temperatura",              StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Presion",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Concentracion",            StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina3Ph",                       StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina3Temperatura",              StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Presion",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaBalanceo = new()
    {
        new() { BaseName = "Dcp71",            StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Dcp3",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp53",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp54",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    // This one has a special case wit DCP SN 34 where it can be saved any time
    private static readonly List<PhaseFieldMap> _fieldMapsGenVMegaPintura = new()
    {
        new() { BaseName = "DcpSn_31_1",       StartHasValue = true, MidHasValue = false,   EndHasValue = true },
        new() { BaseName = "DcpSn_31_2",       StartHasValue = true, MidHasValue = false,   EndHasValue = true },
        new() { BaseName = "DcpSn_31_3",       StartHasValue = true, MidHasValue = false,   EndHasValue = true },
        new() { BaseName = "DcpSn_34",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp77",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp65_67",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    // --------------- MINI LINEA -----------------
    private static readonly List<PhaseFieldMap> _fieldMapsGenVMiniAnillos = new ()
    {
        new() { BaseName = "DcpSn01",       StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "Dcp133",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp134",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp8_1",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp8_2",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp11_1",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp11_2",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp130",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp160",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp132_1",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp132_2",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp10_1",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp10_2",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp10_3",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp131",        StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "DcpSn02",       StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "Dcp77_161",     StartHasValue = true, MidHasValue = true,  EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMiniMazas = new ()
    {
        new() { BaseName = "DcpSn01",       StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "DcpSn02",       StartHasValue = true, MidHasValue = true,  EndHasValue = false },
        new() { BaseName = "Dcp174_1",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp174_2",      StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp172",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp173",        StartHasValue = true, MidHasValue = true,  EndHasValue = true },
        new() { BaseName = "Dcp42_Ip",      StartHasValue = true, MidHasValue = false, EndHasValue = false },
        new() { BaseName = "Dcp77_161",     StartHasValue = true, MidHasValue = true,  EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMiniEnsamble = new ()
    {
        new() { BaseName = "Dcp76",       StartHasValue = true, MidHasValue = true,  EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMiniPostmaquinado = new()
    {
        new() { BaseName = "DcpSn01",         StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Dcp1",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp2",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp4",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp5",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp9a",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp9b",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp36a",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp36b_1",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp36b_2",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp36b_3",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp12",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp15",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp16",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp38",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp6",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp7",            StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp20ip",         StartHasValue = true, MidHasValue = false,  EndHasValue = false  },
        new() { BaseName = "Dcp18",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp22",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp24",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp25",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp26",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
        new() { BaseName = "Dcp42",           StartHasValue = true, MidHasValue = true,   EndHasValue = true  },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMiniCunero = new()
    {
        new() { BaseName = "Dcp47",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp50_48",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp36",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSN_77",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp77_161",        StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMiniPulido = new()
    {
        new() { BaseName = "Dcp19",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp20_1",          StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp20_2",          StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSN_10",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    private static readonly List<PhaseFieldMap> _fieldMapsGenVMiniBalanceo = new()
    {
        new() { BaseName = "Dcp71",            StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Dcp3",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp53",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp54",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };

    // --------------- Dk68 -----------------
    private static readonly List<PhaseFieldMap> _fieldMapsDk68Prelavadora = new()
    {
        new() { BaseName = "Alcalinidad",      StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Temperatura",      StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Nivel",            StartHasValue = true, MidHasValue = false,   EndHasValue = false },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsDk68Ensamble = new()
    {
        new() { BaseName = "Dcp30",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp21",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp19",            StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "DcpSn30",          StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp73",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsDk68Muesca = new()
    {
        new() { BaseName = "Dcp50",            StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Dcp54",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp55",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsDk68Balanceo = new()
    {
        new() { BaseName = "Dcp2_1",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp2_2",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp1",              StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp3",              StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "DcpSn28",           StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp16",             StartHasValue = true, MidHasValue = true,   EndHasValue = false },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsDk68Pintado = new()
    {
        new() { BaseName = "DcpSn23",           StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp66",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSn27",           StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Dcp65",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsDk68Estampado = new()
    {
        new() { BaseName = "Dcp52",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp71",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp53",             StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Dcp58",             StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Dcp57",             StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "DcpSn2_9",          StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsDk68Inspeccion = new()
    {
        new() { BaseName = "Dcp52",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp71",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp73",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp66",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp148",            StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp65",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSn",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSn28",           StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp80",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp72",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp44",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSn2_28",         StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp30",             StartHasValue = true, MidHasValue = false,   EndHasValue = false },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsDk68Epc = new()
    {
        new() { BaseName = "Dcp52",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp73",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp68",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp82",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSn",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "DcpSn28",           StartHasValue = true, MidHasValue = true,   EndHasValue = true },
        new() { BaseName = "Dcp72",             StartHasValue = true, MidHasValue = true,   EndHasValue = true },
    };
    private static readonly List<PhaseFieldMap> _fieldMapsDk68Op50A = new()
    {
        new() { BaseName = "PrelavadoraAlcalinidad",        StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "PrelavadoraTemperatura",        StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "PrelavadoraNivel",         StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1AcidezTotal",              StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina1AcidezLibre",              StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina1Presion",                  StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1Temperatura",              StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina1Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Presion",                  StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina2Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Concentracion",            StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina3Ph",                       StartHasValue = true, MidHasValue = true,   EndHasValue = false },
        new() { BaseName = "Tina3Presion",                  StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Limpieza",                 StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina3Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina4Presion",                  StartHasValue = true, MidHasValue = false,   EndHasValue = false },
        new() { BaseName = "Tina4Nivel",                    StartHasValue = true, MidHasValue = false,   EndHasValue = false },
    };

    public static void WriteRecord(
        CsvWriter csv,
        User user,
        object obj,
        ShiftPhase phase,
        bool noWork = false)
    {
        if (csv is null) throw new ArgumentNullException(nameof(csv));
        if (user is null) throw new ArgumentNullException(nameof(user));
        if (obj is null) throw new ArgumentNullException(nameof(obj));

        // Common fields
        csv.WriteField(user.Name);
        csv.WriteField(user.Date);
        csv.WriteField(user.Shift);
        csv.WriteField(user.Nomina);
        csv.WriteField(DateTime.Now);
        csv.WriteField(phase.ToString()); // "Start", "Mid", "End"

        var objType = obj.GetType();

        List<PhaseFieldMap> _fieldMaps;
        if (objType == typeof(L625.Models.Cunero)) _fieldMaps = _fieldMaps625Cunero;
        else if (objType == typeof(L625.Models.Ensamble)) _fieldMaps = _fieldMaps625Ensamble;
        else if (objType == typeof(L625.Models.Postmaquinado)) _fieldMaps = _fieldMaps625Postmaquinado;
        else if (objType == typeof(L625.Models.Pulido)) _fieldMaps = _fieldMaps625Pulido;
        else if (objType == typeof(L625.Models.Balanceo)) _fieldMaps = _fieldMaps625Balanceo;
        else if (objType == typeof(L625.Models.Inspeccion)) _fieldMaps = _fieldMaps625Inspeccion;
        else if (objType == typeof(GenVPrincipal.Models.Anillos)) _fieldMaps = _fieldMapsGenVPrincipalAnillos;
        else if (objType == typeof(GenVPrincipal.Models.Ensamble)) _fieldMaps = _fieldMapsGenVPrincipalEnsamble;
        else if (objType == typeof(GenVPrincipal.Models.Mazas)) _fieldMaps = _fieldMapsGenVPrincipalMazas;
        else if (objType == typeof(GenVPrincipal.Models.Postmaquinado)) _fieldMaps = _fieldMapsGenVPrincipalPostmaquinado;
        else if (objType == typeof(GenVPrincipal.Models.Pulido)) _fieldMaps = _fieldMapsGenVPrincipalPulido;
        else if (objType == typeof(GenVPrincipal.Models.Cunero)) _fieldMaps = _fieldMapsGenVPrincipalCunero;
        else if (objType == typeof(GenVPrincipal.Models.Balanceo)) _fieldMaps = _fieldMapsGenVPrincipalBalanceo;
        else if (objType == typeof(GenVPrincipal.Models.Plv017)) _fieldMaps = _fieldMapsGenVPrincipalPlv017;
        else if (objType == typeof(GenVPrincipal.Models.Plv002)) _fieldMaps = _fieldMapsGenVPrincipalPlv002;
        else if (objType == typeof(GenVMega.Models.Postmaquinado)) _fieldMaps = _fieldMapsGenVMegaPostmaquinado;
        else if (objType == typeof(GenVMega.Models.Mazas)) _fieldMaps = _fieldMapsGenVMegaMazas;
        else if (objType == typeof(GenVMega.Models.Ensamble)) _fieldMaps = _fieldMapsGenVMegaEnsamble;
        else if (objType == typeof(GenVMega.Models.Anillos)) _fieldMaps = _fieldMapsGenVMegaAnillos;
        else if (objType == typeof(GenVMega.Models.Cunero)) _fieldMaps = _fieldMapsGenVMegaCunero;
        else if (objType == typeof(GenVMega.Models.Pulido)) _fieldMaps = _fieldMapsGenVMegaPulido;
        else if (objType == typeof(GenVMega.Models.Prelavadora)) _fieldMaps = _fieldMapsGenVMegaPrelavadora;
        else if (objType == typeof(GenVMega.Models.Balanceo)) _fieldMaps = _fieldMapsGenVMegaBalanceo;
        else if (objType == typeof(GenVMega.Models.Plv025)) _fieldMaps = _fieldMapsGenVMegaPlv025;
        else if (objType == typeof(GenVMega.Models.Plv028)) _fieldMaps = _fieldMapsGenVMegaPlv028;
        else if (objType == typeof(GenVMini.Models.Anillos)) _fieldMaps = _fieldMapsGenVMiniAnillos;
        else if (objType == typeof(GenVMini.Models.Mazas)) _fieldMaps = _fieldMapsGenVMiniMazas;
        else if (objType == typeof(GenVMini.Models.Ensamble)) _fieldMaps = _fieldMapsGenVMiniEnsamble;
        else if (objType == typeof(GenVMini.Models.Postmaquinado)) _fieldMaps = _fieldMapsGenVMiniPostmaquinado;
        else if (objType == typeof(GenVMini.Models.Balanceo)) _fieldMaps = _fieldMapsGenVMiniBalanceo;
        else if (objType == typeof(GenVMini.Models.Pulido)) _fieldMaps = _fieldMapsGenVMiniPulido;
        else if (objType == typeof(GenVMini.Models.Cunero)) _fieldMaps = _fieldMapsGenVMiniCunero;
        else if (objType == typeof(Dk68.Models.Ensamble)) _fieldMaps = _fieldMapsDk68Ensamble;
        else if (objType == typeof(Dk68.Models.Muesca)) _fieldMaps = _fieldMapsDk68Muesca;
        else if (objType == typeof(Dk68.Models.Balanceo)) _fieldMaps = _fieldMapsDk68Balanceo;
        else if (objType == typeof(Dk68.Models.Pintado)) _fieldMaps = _fieldMapsDk68Pintado;
        else if (objType == typeof(Dk68.Models.Estampado)) _fieldMaps = _fieldMapsDk68Estampado;
        else if (objType == typeof(Dk68.Models.Inspeccion)) _fieldMaps = _fieldMapsDk68Inspeccion;
        else if (objType == typeof(Dk68.Models.Epc)) _fieldMaps = _fieldMapsDk68Epc;
        else if (objType == typeof(Dk68.Models.Prelavadora)) _fieldMaps = _fieldMapsDk68Prelavadora;
        else if (objType == typeof(Dk68.Models.Op50A)) _fieldMaps = _fieldMapsDk68Op50A;
        else if (objType == typeof(GenVPrincipal.Models.Pintura))
        {
            PinturaSaveRecord(user, obj, phase, csv);
            return;
        }
        else if (objType == typeof(Duramax.Models.Estampado)) _fieldMaps = Duramax.Models.Estampado.FieldMaps();
        else if (objType == typeof(Duramax.Models.Op10W20W)) _fieldMaps = Duramax.Models.Op10W20W.FieldMaps();
        else if (objType == typeof(Duramax.Models.Op30WCara1)) _fieldMaps = Duramax.Models.Op30WCara1.FieldMaps();
        else if (objType == typeof(Duramax.Models.Op30WCara2)) _fieldMaps = Duramax.Models.Op30WCara2.FieldMaps();
        else if (objType == typeof(Duramax.Models.Balanceo40W)) _fieldMaps = Duramax.Models.Balanceo40W.FieldMaps();
        else throw new NotImplementedException();

        // Dynamic DCP fields
        foreach (var map in _fieldMaps)
        {
            bool hasValue = phase switch
            {
                ShiftPhase.Start => map.StartHasValue,
                ShiftPhase.Mid => map.MidHasValue,
                ShiftPhase.End => map.EndHasValue,
                _ => false
            };

            if (!hasValue)
            {
                csv.WriteField("NA");
                continue;
            }

            var propName = map.BaseName + phase; // e.g. "DcpSn01Start"

            var prop = objType.GetProperty(
                propName,
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

            if (prop == null)
            {
                // Fallback if property not found
                csv.WriteField("NA");
            }
            else
            {
                var value = prop.GetValue(obj);
                if(noWork)
                {
                    csv.WriteField("NT");
                }
                else if (value!.GetType() == typeof(bool))
                {
                    csv.WriteField((bool)value ? "OK" : "NOK");
                }
                else
                {
                    csv.WriteField(value);
                }
            }
        }

        csv.NextRecord();
    }

    public static void SaveRecordLocal(string fileName, User user, Object equipment, ShiftPhase phase, bool noWork = false)
    {
        using (var writer = new StreamWriter($"{routeLocal}\\{fileName}.csv", append: true))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            WriteRecord(csv, user, equipment, phase: phase, noWork);
        }

    }

    public static void SaveRecordSharepoint(string fileName, User user, Object equipment, ShiftPhase phase, bool noWork = false)
    {
        using (var writer = new StreamWriter($"{routeShared}\\{fileName}.csv", append: true))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            WriteRecord(csv, user, equipment, phase: phase, noWork);
        }
    }

    public static void SaveRecord(OperationNames path, string fileName, User user, Object equipment, ShiftPhase phase, bool noWork = false)
    {
        using (var writer = new StreamWriter($"{FolderPaths.GetPath(path)}\\{fileName}.csv", append: true))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            WriteRecord(csv, user, equipment, phase: phase, noWork);
        }
    }

    public static void SaveNTRecordLocal(string fileName, User user, Object equipment, ShiftPhase phase)
    {
        using (var writer = new StreamWriter($"{routeLocal}\\{fileName}.csv", append: true))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            WriteRecord(csv, user, equipment, phase: phase, noWork: true);
        }
    }

    // Own implementation for pintura since I have to store DCP 34 every time with NA or value if there is one
    public static void PinturaSaveRecord(User user, Object obj, ShiftPhase phase, CsvWriter csv)
    {
        // string route =  disk == Disk.Local ? routeLocal : routeShared;
        // using (var writer = new StreamWriter($"{route}\\Pintura.csv", append: true))
            
        {
            if (csv is null) throw new ArgumentNullException(nameof(csv));
            if (user is null) throw new ArgumentNullException(nameof(user));
            if (obj is null) throw new ArgumentNullException(nameof(obj));

            // Common fields
            csv.WriteField(user.Name);
            csv.WriteField(user.Date);
            csv.WriteField(user.Shift);
            csv.WriteField(user.Nomina);
            csv.WriteField(DateTime.Now);
            csv.WriteField(phase.ToString()); // "Start", "Mid", "End"

            var objType = obj.GetType();

            List<PhaseFieldMap> _fieldMaps = _fieldMapsGenVPrincipalPintura;

            // Dynamic DCP fields
            foreach (var map in _fieldMaps)
            {
                if(map.BaseName == "DcpSn_34")
                {
                    var dcpSn_34 =  objType.GetProperty(
                        map.BaseName + "Any",
                        BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

                    decimal? value = (decimal?)dcpSn_34!.GetValue(obj);
                    if(value == null)
                    {
                        csv.WriteField("NA");
                    }
                    else
                    {
                        csv.WriteField(value);
                    }

                    continue;
                }
                bool hasValue = phase switch
                {
                    ShiftPhase.Start => map.StartHasValue,
                    ShiftPhase.Mid => map.MidHasValue,
                    ShiftPhase.End => map.EndHasValue,
                    _ => false
                };

                if (!hasValue)
                {
                    csv.WriteField("NA");
                    continue;
                }

                var propName = map.BaseName + phase; // e.g. "DcpSn01Start"

                var prop = objType.GetProperty(
                    propName,
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

                if (prop == null)
                {
                    // Fallback if property not found
                    csv.WriteField("NA");
                }
                else
                {
                    var value = prop.GetValue(obj);
                    if (value!.GetType() == typeof(bool))
                    {
                        csv.WriteField((bool)value ? "OK" : "NOK");
                    }
                    else
                    {
                        csv.WriteField(value);
                    }
                }
            }

            csv.NextRecord();
        }
    }
}