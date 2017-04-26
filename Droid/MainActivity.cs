using Android.App;
using Android.OS;

namespace Shared.Droid
{
	[Activity(Label = "Ma Voiture", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);


		}
	}
}

