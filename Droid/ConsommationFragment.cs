﻿using Android.App;
using Android.OS;
using Android.Views;

namespace Shared.Droid
{
	public class ConsommationFragment : ListFragment
	{
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			return inflater.Inflate(Resource.Layout.Consommation, container, false);

			//return base.OnCreateView(inflater, container, savedInstanceState);
		}
	}
}