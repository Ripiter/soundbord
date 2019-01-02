using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Media;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Soundboard
{
    [Activity(Label = "Fourth")]
    public class Fourth : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Fourth);

            Button button = FindViewById<Button>(Resource.Id.First);
            button.Click += delegate { StartActivity(typeof(MainActivity));
            };
            // Create your application here
        }
    }
}