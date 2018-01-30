using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace HexConverter.Droid
{
    [Activity(Label = "HexConverter", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText hexValueEditText;
        TextView redTextView, greenTextView, blueTextView;
        Button calculateButton;
        View colorView;

        HexadecimalConverter hexaConverter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            hexaConverter = new HexadecimalConverter();

            hexValueEditText = FindViewById<EditText>(Resource.Id.hexValueEditText);
            redTextView = FindViewById<TextView>(Resource.Id.redTextView);
            greenTextView = FindViewById<TextView>(Resource.Id.greenTextView);
            blueTextView = FindViewById<TextView>(Resource.Id.blueTextView);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            colorView = FindViewById<View>(Resource.Id.colorView);

            calculateButton.Click += CalculateButton_Click;
        }

        private void CalculateButton_Click(object sender, System.EventArgs e)
        {
            string hexValueString = hexValueEditText.Text;
            this.hexaConverter.AssignHexValue(hexValueString);

            redTextView.Text = this.hexaConverter.RedDecimal.ToString();
            greenTextView.Text = this.hexaConverter.GreenDecimal.ToString();
            blueTextView.Text = this.hexaConverter.BlueDecimal.ToString();

            colorView.SetBackgroundColor(new Android.Graphics.Color(this.hexaConverter.RedDecimal,
                                                                    this.hexaConverter.GreenDecimal,
                                                                    this.hexaConverter.BlueDecimal));
        }
    }
}

