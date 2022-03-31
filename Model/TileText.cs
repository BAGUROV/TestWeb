using c.Configuration;
using c.Configuration.Stringing;
using c.Enums;
using Core;
using Core.Shell.Widgets;
using Shell.BaseElements.Models.Widgets.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestProject.Model
{
    public class TileText
    {
        private HorizontalAlignment _hAlign;
        private VerticalAlignment _vAlignment;
        private int _sX;
        private int _sY;
        private int _sZ;
        private int _sHeight;
        private int _sWidth;
        private c4 _radius;
        private c4 _borderThickness;
        private cBrush _borderBrush;
        private c4 _margin;
        private int _fsize;

        public TileText()
        { 
            
        }

        [JsonIgnore]
        public const int DefaultValueForProperty = 0;

        [aAlsoKnownAs("borderRadius")]
        [cSetter("Round element radius")]
        public c4 Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                ForeachView(v => v.sRadius = value);
            }
        }

        public virtual int sHeight
        {
            get => _sHeight;
            set
            {
                _sHeight = value < 0 ? DefaultValueForProperty : value;
                ForeachBaseView(v => v.sHeight = _sHeight);
            }
        }

        public virtual int sWidth
        {
            get => _sWidth;
            set
            {
                _sWidth = value < 0 ? DefaultValueForProperty : value;
                ForeachBaseView(v => v.sWidth = _sWidth);
            }
        }


        public virtual int sX
        {
            get => _sX;
            set
            {
                _sX = value < 0 ? DefaultValueForProperty : value;
                ForeachBaseView(v => v.sX = _sX);
            }
        }

        public virtual int sY
        {
            get => _sY;
            set
            {
                _sY = value < 0 ? DefaultValueForProperty : value;
                ForeachBaseView(v => v.sY = _sY);
            }
        }

        public virtual int sZ
        {
            get => _sZ;
            set
            {
                _sZ = value;
                ForeachBaseView(v => v.sZ = _sZ);
            }
        }

        [aAlsoKnownAs("borderBrush")]
        [cSetter("Border color", group: "Brushes")]
        public cBrush BorderBrush
        {
            get => _borderBrush;
            set
            {
                _borderBrush = value;
                ForeachView(v => v.sBorderBrush = value);
            }
        }

        [aAlsoKnownAs("borderThick")]
        [cSetter("Border thickness")]
        public c4 BorderThickness
        {
            get => _borderThickness;
            set
            {
                _borderThickness = value;
                ForeachView(v => v.sBorderThickness = value);
            }
        }

        [aAlsoKnownAs("hAlign")]
        [cSetter("Horizontal content orientation", group: "Text")]
        public HorizontalAlignment HAlignment
        {
            get => _hAlign;
            set
            {
                _hAlign = value;
                ForeachView(v => v.sHAlignment = value);
            }
        }

        [aAlsoKnownAs("vAlign")]
        [cSetter("Vertical content orientation", group: "Text")]
        public VerticalAlignment VAlignment
        {
            get => _vAlignment;
            set
            {
                _vAlignment = value;
                ForeachView(v => v.sVAlignment = value);
            }
        }

        [aAlsoKnownAs("margin")]
        [cSetter("Offset", "Layout")]
        public c4 Margin
        {
            get => _margin;
            set
            {
                _margin = value;
                ForeachView(v => v.sMargin = value);
            }
        }

        [cSetter("Font Size", "FontSize")]
        public int FSize
        {
            get => _fsize;
            set
            {
                _fsize = value;
                ForeachView(v => v.FSize = value);
            }
        }

        protected void ForeachBaseView(Action<IWidgetViewModel> action)
        {
            //foreach (var view in Views.ToArray())
            //{
            //    action(view);
            //}
        }
        protected void ForeachView(Action<ITileView> action)
        {
            //foreach (var view in Views.ToArray().OfType<TView>())
            //{
            //    action(view);
            //}
        }
    }
}
