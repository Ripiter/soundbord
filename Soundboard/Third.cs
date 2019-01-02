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
    [Activity(Label = "Third")]
    public class Third : Activity
    {
        MediaPlayer Wiisound;
        //MediaPlayer Yeetsound;
        MediaPlayer garimm;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Third);

            Button button = FindViewById<Button>(Resource.Id.First);
            button.Click += delegate {
                StartActivity(typeof(MainActivity));
            };
            // Create your application here  

            Wiisound = MediaPlayer.Create(this, Resource.Raw.Wii);

            Button Wiibutton = FindViewById<Button>(Resource.Id.yeeet);
            Wiibutton.Click += (sender, e) =>
            {
                Wiisound.Start();
            };

            garimm = MediaPlayer.Create(this, Resource.Raw.Garrim);

            Button Yeetbutton = FindViewById<Button>(Resource.Id.garim);
            Yeetbutton.Click += (sender, e) =>
            {
                garimm.Start();
            };


        }
    }
}