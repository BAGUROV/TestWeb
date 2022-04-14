using c.Configuration.Stringing;
using Core.Shell.Widgets;
using Shell.BaseElements.Models.Widgets.Tiles;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestProject.Model
{
    public class jsonWidget
    {
        public CanvasModel Properties { get; set; }

        [JsonPropertyName("Widgets")]
        public List<Widget> Widgets { get; set; }
    }

    public class Widget
    {
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public sWidgetModel<ITileView> Properties { get; set; }
    }

    public class CanvasModel
    { 
        public cBrush Background { get; set; }
        public cBrush Foreground { get; set; }
        public int Height { get; set; } 
        public int Width { get; set; }  
    }
}
