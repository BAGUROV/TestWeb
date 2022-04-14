using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestProject.Model
{
    public class jsonChangesWidget
    {
        public string Properties { get; set; }

        [JsonPropertyName("Widgets")]
        public List<WidgetChanges> Widgets { get; set; }
    }
    public class WidgetChanges
    {
        public string Name { get; set; } = "";
        public string Properties { get; set; }
    }
}
