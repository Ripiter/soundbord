using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Media;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Soundboard
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : Activity
    {

       
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            // Set our view from the "main" layout resource  
            SetContentView(Resource.Layout.activity_main);


            //Reddirecting button to second.axml with polish songs
            ImageButton polish = FindViewById<ImageButton>(Resource.Id.second);
            polish.Click += delegate { StartActivity(typeof(Second));
            };

            //Reddirecting button to third.axml with english songs
            ImageButton english = FindViewById<ImageButton>(Resource.Id.third);
            english.Click += delegate
            {
                StartActivity(typeof(Third));
            };

            //Reddirecting button to fourth.axml with danish songs
            ImageButton danish = FindViewById<ImageButton>(Resource.Id.fourth);
            danish.Click += delegate
            {
                StartActivity(typeof(Fourth));
            };
        }


        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);




        //    SetContentView(Resource.Layout.activity_main);

        //    player = MediaPlayer.Create(this, Resource.Raw.Jojo);

        //    Button button = FindViewById<Button>(Resource.Id.playButton);
        //    button.Click += (sender, e) =>
        //    {
        //        player.Start();
        //    };


        //    GGarim = MediaPlayer.Create(this, Resource.Raw.Garrim);

        //    ImageButton button2 = FindViewById<ImageButton>(Resource.Id.playButton2);
        //    button2.Click += (sender, e) =>
        //    {
        //        GGarim.Start();
        //    };

        //    Roblox = MediaPlayer.Create(this, Resource.Raw.Roblox);

        //    Button button3 = FindViewById<Button>(Resource.Id.playButton3);
        //    button3.Click += (sender, e) =>
        //    {
        //        Roblox.Start();
        //    };

        //}

    }
}

