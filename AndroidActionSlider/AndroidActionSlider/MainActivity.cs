using Android.App;
using Android.Widget;
using Android.OS;
using ActionComponents;
using Android.Graphics;

namespace AndroidActionSlider
{
	[Activity(Label = "AndroidActionSlider", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Access the slider
			var slider = FindViewById<ACSlider>(Resource.Id.brightnessSlider);
			slider.Icon = BitmapFactory.DecodeResource(Resources, Resource.Drawable.iconBrightness);

			// Access text view
			var brightnessLevel = FindViewById<TextView>(Resource.Id.brightnessLevel);

			// Wire-up changes
			slider.ValueChanged += (fillPercent) => {
				brightnessLevel.Text = $"{fillPercent}%";
			};
		}
	}
}

