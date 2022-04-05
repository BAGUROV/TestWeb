using Core.Shell.Widgets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shell.BaseElements.Models.Widgets.Tiles;
using System;
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
            { "AnyTileLangModel", TestClass.CreateAnyTileLangModel() }, //AnyLang
            { "AnyTileModel", TestClass.CreateAnyTileModel() }, // Any
            { "TileFlagModel", TestClass.CreateTileFlagModel() }, // Flag
            { "TileNumberAndStateModel", TestClass.CreateTileNumberAndStateModel() }, //NumberAndState
            { "TileNumberModel", TestClass.CreateNumberModel() }, //Number
            { "TileSuperModel", TestClass.CreateTileSuperModel() }, //Super
            { "TileSwitchModel", TestClass.CreateTileSwitchModel() }, //Switch
            { "TileTextModel", TestClass.CreateTileTextModel() } //Text
            };

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

            JsonResult jsonResult = null;
            try
            {
                _logger.LogInformation("Trying to get a widget(" + Text + ") in the format JSON");
                sWidgetModel<ITileView> test = _dictionaryWidgetModel[Text];
                jsonResult = new JsonResult(test);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Failed attempt to get widget(" + Text + ") in format JSON");
            }
            _logger.LogInformation("Successful receipt of the widget(" + Text + ") in the format JSON");
            return jsonResult;
        }
    }
}
