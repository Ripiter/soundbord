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
    [Activity(Label = "EnglishSongsB")]
    public class Second : Activity
    {
        MediaPlayer player;
        MediaPlayer GGarim;
        //MediaPlayer Roblox;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Second); //connect to second.axml


            //Going back to the first(Main) page.
            Button button = FindViewById<Button>(Resource.Id.First);
            button.Click += delegate { StartActivity(typeof(MainActivity));
            };



            // Play buttons 


            //Jojo music button
            player = MediaPlayer.Create(this, Resource.Raw.Jojo);

            Button jojobutton = FindViewById<Button>(Resource.Id.jojo);
            jojobutton.Click += (sender, e) =>
            {
                player.Start();
            };

            //We garrim music starts
            GGarim = MediaPlayer.Create(this, Resource.Raw.Garrim);

            Button garimbutton = FindViewById<Button>(Resource.Id.garim);
            garimbutton.Click += (sender, e) =>
            {
                GGarim.Start();
            };


        }
    }
}
