using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Views;
using Android.Widget;
using Android.Content;

namespace cameratask
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, Android.Views.View.IOnClickListener
	{
        Button submitBtn;
        EditText fname;
        EditText lname;
        EditText address;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           

            SetContentView(Resource.Layout.activity_main);

            submitBtn = FindViewById<Button>(Resource.Id.submitbtn);
            submitBtn.SetOnClickListener(this);

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

		public void OnClick(View v)
		{
			if (submitBtn == v)
			{
                Intent intent = new Intent(this, typeof(Activity1));
                intent.PutExtra("fname", fname.Text);
                intent.PutExtra("lname", lname.Text);
                intent.PutExtra("address", address.Text);
                StartActivity(intent);
			}
		}

    }
}