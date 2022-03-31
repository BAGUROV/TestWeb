using c.Configuration.Stringing;
using Shell.BaseElements.Models.Widgets.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Model
{
    public class TestClass
    {
        public static TileTextModel CreateTileTextModel(string tag = "tile")
        {
            return new TileTextModel
            {
                Radius = new c4(0),
                sHeight = 10,
                sWidth = 10,
                Background = cBrush.SoBlue,
                BorderBrush = cBrush.Transparent,
                Fore = cBrush.White,
                sName = tag,
                sX = 7,
                sY = 7,
                sZ = 2,
                Scale = 2,
            };
        }
    }
}
