using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace Planner.Droid
{
	[Activity (Label = "Planner", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
        public static Size DeviceWindowSize { get; set; }
        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);


			var metrics = Resources.DisplayMetrics;
			var widthInDp = ConvertPixelsToDp(metrics.WidthPixels);
			var heightInDp = ConvertPixelsToDp(metrics.HeightPixels);


            //App.DeviceWindowSize = new Size(Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density, Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density);

            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new Planner.App ());
		}
	  
		private int ConvertPixelsToDp(float pixelValue)
		{
			var dp = (int)((pixelValue) / Resources.DisplayMetrics.Density);
			return dp;
		}
	}
}

