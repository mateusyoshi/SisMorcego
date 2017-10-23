using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SisMorcego
{
    [Activity(Label = "RegistroH")]
    public class ActRegistroH : Activity
    {
        TextView _dateDisplay;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RegistroH);
            _dateDisplay = FindViewById<TextView>(Resource.Id.textView0);
            Button _button1;
            _button1 = FindViewById<Button>(Resource.Id.button6);
            _button1.Click += _button1_Click;

            // Create your application here
        }

        private void _button1_Click(object sender, EventArgs e)
        {
            DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
            {
                _dateDisplay.Text = time.ToLongDateString();
            });
            frag.Show(FragmentManager, DatePickerFragment.TAG);
        }
    }
}