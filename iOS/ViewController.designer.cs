// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HexConverter.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BlueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ConvertButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ConvertedColorView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel GreenLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        HexaTextField HexTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel RedLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BlueLabel != null) {
                BlueLabel.Dispose ();
                BlueLabel = null;
            }

            if (ConvertButton != null) {
                ConvertButton.Dispose ();
                ConvertButton = null;
            }

            if (ConvertedColorView != null) {
                ConvertedColorView.Dispose ();
                ConvertedColorView = null;
            }

            if (GreenLabel != null) {
                GreenLabel.Dispose ();
                GreenLabel = null;
            }

            if (HexTextField != null) {
                HexTextField.Dispose ();
                HexTextField = null;
            }

            if (RedLabel != null) {
                RedLabel.Dispose ();
                RedLabel = null;
            }
        }
    }
}