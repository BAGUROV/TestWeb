using c.Configuration.Stringing;
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

        private jsonWidget _twoWidgets = new jsonWidget()
        {
            Properties = new CanvasModel()
            {
                Background = cBrush.SoDarkGray,
                Foreground = cBrush.White,
                Height = 800,
                Width = 1200,
            },
            Widgets = new List<Widget>()
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult Open(string Text) // '>:\\Main'
        {
            if (Text == null)
                return new JsonResult(null);

            JsonResult jsonResult = null;
            try
            {
                _logger.LogInformation("Trying to get a widget(" + Text + ") in the format JSON");

                _twoWidgets.Widgets.Add(new Widget());
                _twoWidgets.Widgets.Add(new Widget());
                _twoWidgets.Widgets[0].Name = "tiles#1";
                _twoWidgets.Widgets[0].Type = @"tiles\Text";
                _twoWidgets.Widgets[0].Properties = _dictionaryWidgetModel["TileTextModel"];
                _twoWidgets.Widgets[1].Name = "tiles#2";
                _twoWidgets.Widgets[1].Type = @"tiles\Number";
                _twoWidgets.Widgets[1].Properties = _dictionaryWidgetModel["TileNumberModel"];

                jsonResult = new JsonResult(_twoWidgets);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Failed attempt to get widget(" + Text + ") in format JSON");
            }
            _logger.LogInformation("Successful receipt of the widget(" + Text + ") in the format JSON");
            return jsonResult;
        }

        [HttpGet("delta")]
        public JsonResult GetDelta(string Text, int clock)
        {
            var change = new jsonChangesWidget();
            change.Properties = "Background: red";
            change.Widgets = new List<WidgetChanges>();
            change.Widgets.Add(new WidgetChanges());
            change.Widgets[0].Name = "tiles#1";
            change.Widgets[0].Properties = "Background: green";
            var jsonResult = new JsonResult(change);

            return jsonResult;
        }

        [HttpPut]
        public bool Put([FromForm]sWidgetModel<ITileView> redesignedWidget)
        {

            return true;
        }
    }
}
