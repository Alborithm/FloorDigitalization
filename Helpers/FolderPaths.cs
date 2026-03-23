using System.Collections.Generic;
using FloorDigitalization.Enums;

namespace FloorDigitalization.Helpers;

public static class FolderPaths
{

    public static Dictionary<OperationNames, string> Routes = new ()
    {
        [OperationNames.RouteLocal] = "C:\\IT\\ControlCalidad\\NuevosDatos",
        [OperationNames.L625Postmaquinado] = "C:\\Users\\slp.wkstn28\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - L625",
        [OperationNames.L625BalanceoInspeccion] = "C:\\Users\\slp.wkstn29\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - L625",
        [OperationNames.GenVPrincipalAnillos] = "C:\\Users\\slp.wkstn19.MUVIQ\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Principal",
        [OperationNames.GenVPrincipalMazasEnsamble] = "C:\\Users\\slp.wkstn26\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Principal",
        [OperationNames.GenVPrincipalPostmaquinadoPulidoCunero] = "C:\\Users\\slp.wkstn15\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Principal",
        [OperationNames.GenVPrincipalBalanceoPinturaLavadora] = "C:\\Users\\slp.wkstn27\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Principal",
        [OperationNames.GenVMegaPostmaquinadoPared] = "C:\\Users\\slp.wkstn11\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega",
        [OperationNames.GenVMegaPostmaquinadoPasillo] = "C:\\Users\\slp.wkstn8.DAYCO\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega",
        [OperationNames.GenVMegaAnillosPasillo] = "C:\\Users\\slp.wkstn17.MUVIQ\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega",
        [OperationNames.GenVMegaAnillosPared] = "C:\\Users\\slp.wkstn16.MUVIQ\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega",
        [OperationNames.GenVMegaMazasEnsamblePasillo] = "C:\\Users\\slp.wkstn21\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega",
        [OperationNames.GenVMegaMazasEnsamblePared] = "C:\\Users\\slp.wkstn20\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega",
        [OperationNames.GenVMegaPulidoCunero] = "C:\\Users\\slp.wkstn22\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega",
        [OperationNames.GenVMegaBalanceoPintura] = "C:\\Users\\slp.wkstn23\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mega",
        [OperationNames.GenVMiniAnillos] = "C:\\Users\\slp.wkstn18.MUVIQ\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mini",
        [OperationNames.GenVMiniMazasEnsamble] = "C:\\Users\\slp.wkstn24\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mini",
        [OperationNames.GenVMiniPostmaquinado] = "C:\\Users\\slp.wkstn14\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mini",
        [OperationNames.GenVMiniPulidoCuneroBalanceo] = "C:\\Users\\slp.wkstn25\\MUVIQ S.R.L\\SLP Floor Digitalization - GenV Mini",
        [OperationNames.Dk68EnsambleLavadora] = "C:\\Users\\gerardo.albor\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - Documentos\\Calidad\\ControlCalidad\\Test",
        [OperationNames.DebugPc] = "C:\\Users\\gerardo.albor\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - Documentos\\Calidad\\ControlCalidad\\Test",

    };

    public static string GetPath(OperationNames folderPathName)
    {
        if(Routes.TryGetValue(folderPathName, out var path))
        {
            return path;
        }
        return "C:\\IT\\ControlCalidad\\NuevosDatos\\FailedToGetPath";
    }
}