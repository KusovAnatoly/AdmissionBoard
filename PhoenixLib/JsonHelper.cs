using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PhoenixLib
{
    public class JsonHelper
    {
        public static void Serialize<T>(List<T> list, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(list);
            File.WriteAllText(filePath, jsonString);
        }

        public static List<T> Deserialize<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            List<T>? list =
                   JsonSerializer.Deserialize<List<T>>(jsonString);
            return list;
        }
    }
}
