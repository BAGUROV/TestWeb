using c.Configuration.Stringing;
using c.Enums;
using Core.Shell.ElementStates;
using Shell.BaseElements.Models.Widgets.Tiles;
using static Shell.BaseElements.Models.Widgets.Tiles.TileFlagModel;

namespace TestProject.Model
{
    public class TestClass
    {
        public static AnyTileLangModel CreateAnyTileLangModel(string tag = "AnyTileLangModel")
        {
            return new AnyTileLangModel
            {
                sName = tag,
                Fore = cBrush.White,
                Back = cBrush.Black,
                ignoreBadQ = false,
                prefix = "",
                postfix = "",
                errMsg = "",
                Tooltip = "",
                Radius = new c4(0),
                BorderThickness = new c4(0),
                Margin = new c4(0),
                ConsiderOnlyValueQuality = false,
                naFore = cBrush.White,
                naBack = cBrush.SoBlue,
                BorderBrush = cBrush.White,
                HAlignment = HorizontalAlignment.Center,
                VAlignment = VerticalAlignment.Center,
                Visible = true,
                Scale = 1,
                sHeight = 20,
                sWidth = 35,
                sX = 0,
                sY = 0,
                sZ = 0
            };
        }

        public static AnyTileModel CreateAnyTileModel(string tag = "AnyTileModel")
        {
            return new AnyTileModel
            {
                sName = tag,
                Fore = cBrush.White,
                Back = cBrush.Black,
                ignoreBadQ = false,
                prefix = "",
                postfix = "",
                errMsg = "",
                Tooltip = "",
                Radius = new c4(0),
                BorderThickness = new c4(0),
                Margin = new c4(0),
                ConsiderOnlyValueQuality = false,
                naFore = cBrush.White,
                naBack = cBrush.SoBlue,
                BorderBrush = cBrush.White,
                HAlignment = HorizontalAlignment.Center,
                VAlignment = VerticalAlignment.Center,
                Visible = true,
                Scale = 1,
                sHeight = 20,
                sWidth = 35,
                sX = 0,
                sY = 0,
                sZ = 0
            };
        }

        public static TileFlagModel CreateTileFlagModel(string tag = "TileFlagModel")
        {
            return new TileFlagModel
            {
                sName = tag,
                offText = "No",
                offFore = cBrush.White,
                offBack = cBrush.Red,
                onText = "Yes",
                onFore = cBrush.White,
                onBack = cBrush.SoGray,
                AlarmStyle = sFlagAlarmStyle.AllIsGood,
                prefix = "",
                postfix = "",
                errMsg = "***",
                Tooltip = "",
                Radius = new c4(0),
                BorderThickness = new c4(0),
                Margin = new c4(0),
                ConsiderOnlyValueQuality = false,
                naFore = cBrush.White,
                naBack = cBrush.SoBlue,
                BorderBrush = cBrush.White,
                HAlignment = HorizontalAlignment.Center,
                VAlignment = VerticalAlignment.Center,
                Visible = true,
                Scale = 1,
                sHeight = 20,
                sWidth = 35,
                sX = 700,
                sY = 215,
                sZ = 0
            };
        }

        public static TileNumberAndStateModel CreateTileNumberAndStateModel(string tag = "TileNumberAndStateModel")
        {
            return new TileNumberAndStateModel
            { 
                sName = tag,
                format = "0,0",
                normFore = cBrush.White,
                normBack = cBrush.SoGray,
                warnFore = cBrush.Black,
                warnBack = cBrush.SoYellow,
                allarmFore = cBrush.White,
                allarmBack = cBrush.Red,
                AutoToolTips = false,
                prefix = "",
                postfix = "",
                errMsg = "",
                Tooltip = "",
                Radius = new c4(0),
                BorderThickness = new c4(0),
                Margin = new c4(0),
                ConsiderOnlyValueQuality = false,
                naFore = cBrush.White,
                naBack = cBrush.SoBlue,
                BorderBrush = cBrush.White,
                HAlignment = HorizontalAlignment.Center,
                VAlignment = VerticalAlignment.Center,
                Visible = true,
                Scale = 1,
                sHeight = 20,
                sWidth = 35,
                sX = 0,
                sY = 0,
                sZ = 0
            };
        }

        public static TileNumberModel CreateNumberModel(string tag = "TileNumberModel")
        {
            return new TileNumberModel
            {
                sName = tag,
                format = "0,0",
                normFore = cBrush.White,
                normBack = cBrush.SoGray,
                warnFore = cBrush.Black,
                warnBack = cBrush.SoYellow,
                allarmFore = cBrush.White,
                allarmBack = cBrush.Red,
                ignoreQuality = false,
                prefix = "",
                postfix = "",
                errMsg = "",
                Tooltip = "",
                Radius = new c4(0),
                BorderThickness = new c4(0),
                Margin = new c4(0),
                ConsiderOnlyValueQuality = false,
                naFore = cBrush.White,
                naBack = cBrush.SoBlue,
                BorderBrush = cBrush.White,
                HAlignment = HorizontalAlignment.Center,
                VAlignment = VerticalAlignment.Center,
                Visible = true,
                Scale = 1,
                sHeight = 20,
                sWidth = 35,
                sX = 0,
                sY = 0,
                sZ = 0
            };
        }

        public static TileSuperModel CreateTileSuperModel(string tag = "TileSuperModel")
        {
            return new TileSuperModel
            {
                sName = tag,
                prefix = "",
                postfix = "",
                errMsg = "***",
                format = "0.0",
                LowLimitMessage = "",
                LowLimitState = ElementState.Green,
                LowLimitFore = cBrush.White,
                HiLimitMessage = "",
                HiLimitState = ElementState.Green,
                HiLimitFore = cBrush.Black,
                HiLimitBack = cBrush.White,
                angle = 0,
                sFontSize = 12,
                Cases = new sTileSwitchCase[0],
                normFore = cBrush.White,
                normBack = cBrush.SoGray,
                warnFore = cBrush.Black,
                warnBack = cBrush.Orange,
                allarmFore = cBrush.White,
                allarmBack = cBrush.Red,
                ignoreQuality = false,
                Tooltip = "",
                naFore = cBrush.White,
                naBack = cBrush.SoBlue,
                BorderBrush = cBrush.White,
                HAlignment = HorizontalAlignment.Center,
                VAlignment = VerticalAlignment.Center,
                Visible = true,
                Scale = 1,
                sHeight = 20,
                sWidth = 35,
                sX = 0,
                sY = 0,
                sZ = 0
            };
        }

        public static TileSwitchModel CreateTileSwitchModel(string tag = "TileSwitchModel")
        {
            return new TileSwitchModel
            {
                sName = tag,
                DefaultBack = cBrush.SoBlue,
                DefaultFore = cBrush.White,
                DefaultMsg = "---",
                DefaultState = ElementState.Green,
                Cases = new sTileSwitchCase[0],
                prefix = "",
                postfix = "",
                errMsg = "***",
                Tooltip = "",
                Radius = new c4(0),
                BorderThickness = new c4(0),
                Margin = new c4(0),
                ConsiderOnlyValueQuality = false,
                naFore = cBrush.White,
                naBack = cBrush.SoBlue,
                BorderBrush = cBrush.White,
                HAlignment = HorizontalAlignment.Center,
                VAlignment = VerticalAlignment.Center,
                Visible = true,
                Scale = 1,
                sHeight = 20,
                sWidth = 35,
                sX = 0,
                sY = 0,
                sZ = 0
            };
        }

        public static TileTextModel CreateTileTextModel(string tag = "TileTextModel")
        {
            return new TileTextModel
            {
                sName = tag,
                Fore = cBrush.White,
                Radius = new c4(0),
                BorderThickness = new c4(0),
                Margin = new c4(0),
                Text = "",
                FSize = 12,
                BorderBrush = cBrush.White,
                HAlignment = HorizontalAlignment.Center,
                VAlignment = VerticalAlignment.Center,
                Visible = true,
                Scale = 1,
                sHeight = 30,
                sWidth = 50,
                sX = 0,
                sY = 0,
                sZ = 0
            };
        }
    }
}
