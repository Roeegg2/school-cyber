using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cameratask
{
	[Activity(Label = "Activity1")]
	public class Activity1 : Activity
	{
		TextView tv;

		string[] array1 = new string[3];
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.layout1);

			array1[0] = Intent.GetStringExtra("fname");
			array1[1] = Intent.GetStringExtra("lname");
			array1[2] = Intent.GetStringExtra("address");

			tv.Text = "its cone" + array1[0] + array1[1] + array1[2];
		}
	}
}