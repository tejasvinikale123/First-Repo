using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApiApp.Data
{
    public class JsonUtility
    {
    }

    public record class College(
    string Name,
    int NoOfStudents,
    bool IsPublic);

    public static class SurveyReport
    {
        public static List<College> GetColleges() => new()
        {           
            new("Juvenile", 300, false),
            new("Cambrian", 650, true),
            new("Mapple Leaf", 450, true)
        };
    }

    // Native/JsonFileUtils.cs
    public static class JsonFileUtils
    {
        private static readonly JsonSerializerOptions _options =
            new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

        public static void SimpleWrite(object obj, string fileName)
        {
            var jsonString = JsonSerializer.Serialize(obj, _options);
            File.WriteAllText(fileName, jsonString);
        }
    }

    


}
