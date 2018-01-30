﻿using System;

using UIKit;

namespace HexConverter.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;

        private HexadecimalConverter hexaConverter;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Initialize();
            this.AssignCallbacks();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        private void Initialize()
        {
            hexaConverter = new HexadecimalConverter();

            RedLabel.Text = "000";
            GreenLabel.Text = "000";
            BlueLabel.Text = "000";

            HexTextField.Text = "";

            ConvertedColorView.BackgroundColor = new UIColor(1.0f, 1.0f, 1.0f, 1.0f);
        }

        private void AssignCallbacks()
        {
            ConvertButton.TouchUpInside += (object sender, EventArgs e) => 
            {
                this.HexTextField.ResignFirstResponder();
                this.hexaConverter.AssignHexValue(this.HexTextField.Text);

                RedLabel.Text = this.hexaConverter.RedDecimal + "";
                GreenLabel.Text = this.hexaConverter.GreenDecimal + "";
                BlueLabel.Text = this.hexaConverter.BlueDecimal + "";

                ConvertedColorView.BackgroundColor = new UIColor(hexaConverter.RedDecimal / 255.0f,
                                                                 hexaConverter.GreenDecimal / 255.0f,
                                                                 hexaConverter.BlueDecimal / 255.0f,
                                                                 1.0f);
            };
        }
    }
}
