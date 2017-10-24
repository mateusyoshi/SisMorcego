using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace SisMorcego
{
    [Activity(Label = "SisMorcego", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button _button2;
            Button _button3;
            Button _button4;

            _button2 = FindViewById<Button>(Resource.Id.button2); // button2 is the name of your button in layout
            _button3 = FindViewById<Button>(Resource.Id.button3); // button3 is the name of your button in layout
            _button4 = FindViewById<Button>(Resource.Id.button4);

            _button2.Click += Button_Click;
            _button3.Click += Button_Click;
            _button4.Click += _button4_Click;

        }

        private void _button4_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(ActRegistroH));
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "IT WORKS!", ToastLength.Long).Show();
        }
    }
}
