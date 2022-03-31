using c;
using c.Components;
using c.Configuration.Stringing;
using Core.Shell.Widgets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shell.BaseElements.Models.Widgets.Tiles;
using System.Collections.Generic;
using TestProject.Model;
using TestProject.Services;

namespace TestProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private Dictionary<string, sWidgetModel<ITileView>> _dictionaryWidgetModel = new Dictionary<string, sWidgetModel<ITileView>> {
            { "TileTextModel", TestClass.CreateTileTextModel() },
            { "AnyTileLangModel", new AnyTileLangModel() } };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult Get(string Text)
        {
            if (Text == null)
                return new JsonResult(null);

            sWidgetModel<ITileView> test = null;

            //JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            //CustomJsonConverterForType customJSON = new CustomJsonConverterForType();
            //CustomJsonConverterForcBrush customJSON2 = new CustomJsonConverterForcBrush();
            //jsonSerializerOptions.Converters.Add(customJSON);
            //jsonSerializerOptions.Converters.Add(customJSON2);
            //jsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;

            test = _dictionaryWidgetModel[Text];


            //var t=JsonConvert.SerializeObject(test, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto, ReferenceLoopHandling = ReferenceLoopHandling.Ignore   });
            return new JsonResult(test);
        }
    }
}
