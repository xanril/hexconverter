using Foundation;
using System;
using UIKit;

namespace HexConverter.iOS
{
    public partial class HexaTextField : UITextField
    {
        public HexaTextField (IntPtr handle) : base (handle)
        {
        }

        public override bool ShouldChangeTextInRange(UITextRange inRange, string replacementText)
        {
            Console.WriteLine("Replacement String: " + replacementText);
            return base.ShouldChangeTextInRange(inRange, replacementText);
        }
    }
}