using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace YasunliplastApp.iOS.Renderers
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Control == null) return;
            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;

        }
    }
}
