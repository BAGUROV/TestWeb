using c;
using c.Components;
using c.Configuration.Stringing;
using Core.Shell.Widgets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shell.BaseElements.Models.Widgets.Tiles;
using Shell.BaseWidgets.Views.Tiles;
using Shell.Display.Editor.LibraryViews;
using Shell.Display.Scope;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using TestProject.Model;
using TestProject.Services;

namespace TestProject.Controllers
{
    public class TestTest
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private Dictionary<string, sWidgetModel<ITileView>> _dictionaryWidgetModel = new Dictionary<string, sWidgetModel<ITileView>> {
            { "TileTextModel", TestClass.CreateTileTextModel() }, 
            { "AnyTileLangModel", new AnyTileLangModel() } };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult Get(string Text)
        {
            if (Text == null)
                return new JsonResult(null);

            sWidgetModel<ITileView> test = null;
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            CustomJsonConverterForType customJSON = new CustomJsonConverterForType();
            CustomJsonConverterForcBrush customJSON2 = new CustomJsonConverterForcBrush();

            jsonSerializerOptions.Converters.Add(customJSON);
            jsonSerializerOptions.Converters.Add(customJSON2);
            jsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;

            test = _dictionaryWidgetModel[Text];

           
            //var t=JsonConvert.SerializeObject(test, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto, ReferenceLoopHandling = ReferenceLoopHandling.Ignore   });
            return new JsonResult(test);
        }

    }
}
