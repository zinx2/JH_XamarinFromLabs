using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomMdTest.Droid.Renderers;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Xamarin.Forms.MasterDetailPage), typeof(MyMasterDetailRenderer))]
namespace CustomMdTest.Droid.Renderers
{
    public class MyMasterDetailRenderer : MasterDetailRenderer
    {
        bool firstDone;

        public override void AddView(View child)
        {
            if (firstDone)
            {
                MyMasterDetailPage page = (MyMasterDetailPage)this.Element;
                LayoutParams p = (LayoutParams)child.LayoutParameters;
                p.Width = page.DrawerWidth;
                base.AddView(child, p);
            }
            else
            {
                firstDone = true;
                base.AddView(child);
            }
        }

    }
}