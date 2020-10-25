using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

namespace Search_AutoComplete
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            List<string> lst = new List<string>() {"okba","mohamad","ali","yousef","abd alruhman","baraa" };
            var adapter = new ArrayAdapter<string>(this, Resource.Layout.ticket,Resource.Id.textViewtest ,lst);
            AutoCompleteTextView automamlete = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextViewtest);
            automamlete.Adapter=adapter;
            automamlete.ItemClick += delegate {
                var alert = new Android.App.AlertDialog.Builder(this);
                alert.SetTitle("search done..");
                alert.SetMessage(automamlete.Text)
                .Show()
                ;
            };
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}