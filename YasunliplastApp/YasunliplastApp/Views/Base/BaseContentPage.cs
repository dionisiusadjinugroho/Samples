using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace YasunliplastApp.Views.Base
{
    public class BaseContentPage : ContentPage
    {
        protected double _pageWidth = -1;
        protected double _pageHeight = -1;

        public BaseContentPage() : base()
        {
            this.Visual = VisualMarker.Material;

            _pageWidth = this.Width;
            _pageHeight = this.Height;

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        #region Device Orientation

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called
            if (this._pageWidth != width || this._pageHeight != height)
            {
                this._pageWidth = width;
                this._pageHeight = height;
                UpdateLayoutOnRotation();
            }
        }

        public virtual void UpdateLayoutOnRotation()
        {

        }

        #endregion
    }
}