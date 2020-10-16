using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace FirstAppEFCore.Helper
{
    public static class ConvertJson
    {
        public static string Serialize(object obj)
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true,
                PropertyNameCaseInsensitive = true,
            };
            return JsonSerializer.Serialize(obj, options);
        }

        public static T Deserialize<T>(string json)
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true,
                PropertyNameCaseInsensitive = true,
            };
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}
