using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace FloorDigitalization.Helpers;

public static class CsvOperatorReader
{

    public static string GetOperator(int nomina)
    {
        string output = "No encontrado";
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };
        try
        {
            using (var reader = new StreamReader("V:\\IT\\ControlCalidad\\Datos\\Lista_Operadores_DataList2.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<Operator>();

                var record = records.FirstOrDefault<Operator>(r => r.Codigo == nomina);
                if (record is not null)
                    output = string.IsNullOrEmpty(record.Empleado) ? "No encontrado" : record.Empleado;
            }
            
        }
        catch (System.Exception)
        {
            return output = "Falla de red";
        }


        return output;
    }

    private class Operator
    {
        public int Codigo { get; set;}
        public string? Empleado { get; set;} = "No encontrado";
    }
}