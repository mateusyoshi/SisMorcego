﻿using System;
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
        TextView _dateDisplay1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RegistroH);

            Button _button7 = FindViewById<Button>(Resource.Id.button7);
            _dateDisplay = FindViewById<TextView>(Resource.Id.textView0);
            Button _button1 = FindViewById<Button>(Resource.Id.button6);
            _dateDisplay1 = FindViewById<TextView>(Resource.Id.textView1);


            _button1.Click += _button1_Click;
            _button7.Click += _button7_Click;

            // Create your application here
        }

        private void _button7_Click(object sender, EventArgs e)
        {
            DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
            {
                _dateDisplay1.Text = time.ToLongDateString();
            });
            frag.Show(FragmentManager, DatePickerFragment.TAG);
        }

        private void _button1_Click(object sender, EventArgs e)
        {
            DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
            {
                _dateDisplay.Text = time.ToLongDateString();
            });
            frag.Show(FragmentManager, DatePickerFragment.TAG);
        }
        public void OnProviderEnabled(string provider) { }
        public void OnProviderDisabled(string provider) { }
        public void OnStatusChanged(string provider, Android.Locations.Availability status, Bundle extras) { }
        public void OnLocationChanged(Android.Locations.Location location) { }
    }
}