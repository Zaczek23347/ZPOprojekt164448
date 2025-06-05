using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace Zabiegi_SalonFryzjerski.serwisy
{
    public static class JsonService
    {
        public static void ZapiszDoPliku<T>(string sciezka, List<T> dane)
        {
            var json = JsonSerializer.Serialize(dane, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(sciezka, json);
        }

        public static List<T> WczytajZPliku<T>(string sciezka)
        {
            if (!File.Exists(sciezka)) return new List<T>();
            var json = File.ReadAllText(sciezka);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }
    }
}
