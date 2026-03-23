using System;
using System.Linq;
using System.Reflection;
using FloorDigitalization.Enums;
using FloorDigitalization.Models;

namespace FloorDigitalization.Helpers;

public static class DataValidation
{
    /// <summary>
    /// Validates the needed data depending on the phase of the shift
    /// </summary>
    /// <param name="model"></param>
    /// <param name="shiftPhase"></param>
    /// <returns></returns>
    public static bool Validate(object model, ShiftPhase shiftPhase)
    {
        if (shiftPhase == ShiftPhase.None)
            return false;

        var startPropValues = model
                .GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.Name.Contains(shiftPhase.ToString(), StringComparison.OrdinalIgnoreCase) && p.CanRead)
                .Select(p => new
                {
                    p.Name,
                    Value = p.GetValue(model)
                })
                .ToList();


        bool result = startPropValues.All(x =>
        {
            if (x.Value is bool b)
                return b;                 // must be true

            if (x.Value is decimal d)
                return true;              // any decimal as long as not null

            return false;                 // any other type or null = invalid
        });

        return result;
    }

    // public static bool CanSaveDcp(object dcpObject, User user, ShiftPhase shiftPhase)
    // {
    //     // Vaidate if this is the logic we need
        
    //     if (user.Nomina == 0 || user.Nomina == null)
    //         return false; 

    //     if (NoWorkActivatedForCurrentPhase(ScreenNames.Balanceo))
    //         return true;
        
    //     if (Balanceo.HasErrors)
    //         return false;

    //     switch (shiftPhase)
    //     {
    //         case ShiftPhase.Start:
    //             return DataValidation.Validate(dcpObject, ShiftPhase.Start);
    //         case ShiftPhase.Mid:
    //             return DataValidation.Validate(dcpObject, ShiftPhase.Mid);
    //         case ShiftPhase.End:
    //             return DataValidation.Validate(dcpObject, ShiftPhase.End);
    //         default:
    //             return false;
    //     }
    // }
}