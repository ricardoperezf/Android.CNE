using Android.App;
using Android.Widget;
using Android.OS;

namespace Android.CNE
{
    [Activity(Label = "Android.CNE", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var spinnerAccesoZona = FindViewById<Spinner>(Resource.Id.spinnerAccesoZona);
            spinnerAccesoZona.ItemSelected += (s, e) =>
            {
                string firstItem = spinnerAccesoZona.SelectedItem.ToString();
                if (firstItem.Equals(spinnerAccesoZona.SelectedItem.ToString()))
                {
                    //To do when first item is selected.
                }
                else
                {
                    Toast.MakeText(this, "Ha elegido: " + e.Parent.GetItemIdAtPosition(e.Position).ToString(), ToastLength.Short).Show();
                }
            };
        }
    }
}

