using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using BR.Com.Bloder.Magic.View;
using static Android.Views.View;
using Android.Views;
using System;

namespace XamarinMagicButton
{
    [Activity(Label = "XamarinMagicButton", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity,IOnClickListener
    {
        public void OnClick(View v)
        {
            if (v.Id == Resource.Id.btnFacebook)
                Toast.MakeText(this, "Facebook Button Clicked", ToastLength.Short).Show();
            else
                Toast.MakeText(this, "Youtube Button Clicked", ToastLength.Short).Show();

        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            var btnFacebook = FindViewById<MagicButton>(Resource.Id.btnFacebook);
            var btnYoutube = FindViewById<MagicButton>(Resource.Id.btnYoutube);
            btnFacebook.SetMagicButtonClickListener(this);
            btnYoutube.SetMagicButtonClickListener(this);
        }
    }
}

