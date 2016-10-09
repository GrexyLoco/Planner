//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

//[assembly: ExportRenderer(typeof(Planner.Droid.CostumRenderers.CostumTableSectionRenderer), typeof())]
//namespace Planner.Droid.CostumRenderers
//{
//    public class CostumTableSectionRenderer : GestureDetector.SingleTapConfirmedEventArgs
//    {
//        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
//        {
//            base.OnElementChanged(e);
//            Android.Widget.Button thisButton = Control as Android.Widget.Button;
//            thisButton.Touch += (object sender, Android.Views.View.TouchEventArgs e2) =>
//            {
//                if (e2.Event.Action == MotionEventActions.Down)
//                    System.Diagnostics.Debug.WriteLine("TouchDownEvent");
//                else if (e2.Event.Action == MotionEventActions.Up)
//                    System.Diagnostics.Debug.WriteLine("TouchUpEvent");
//            };
//        }
//    }
//}