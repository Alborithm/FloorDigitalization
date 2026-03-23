using System;
using System.Collections.Generic;
using System.Reflection;
using CsvHelper;
using FloorDigitalization.Helpers;
using FloorDigitalization.Models;
using FloorDigitalization.L625.Models;
using FloorDigitalization.Enums;

namespace FloorDigitalization.Helpers;

public static class EnsambleCsvHelper
{
    private static readonly List<PhaseFieldMap> _fieldMaps = new()
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

    public static void WriteEnsambleRecord(
        CsvHelper.CsvWriter csv,
        User user,
        Ensamble ensamble,
        ShiftPhase phase)
    {
        if (csv is null) throw new ArgumentNullException(nameof(csv));
        if (user is null) throw new ArgumentNullException(nameof(user));
        if (ensamble is null) throw new ArgumentNullException(nameof(ensamble));

        // Common fields
        csv.WriteField(user.Name);
        csv.WriteField(user.Date);
        csv.WriteField(user.Shift);
        csv.WriteField(user.Nomina);
        csv.WriteField(DateTime.Now);
        csv.WriteField(phase.ToString()); // "Start", "Mid", "End"

        var ensambleType = ensamble.GetType();

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

            var prop = ensambleType.GetProperty(
                propName,
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

            if (prop == null)
            {
                // Fallback if property not found
                csv.WriteField("NA");
            }
            else
            {
                var value = prop.GetValue(ensamble);
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