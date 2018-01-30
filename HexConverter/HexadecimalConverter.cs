using System;
namespace HexConverter
{
    public class HexadecimalConverter
    {
        public HexadecimalConverter()
        {
        }

        public int RedDecimal { get; private set; }
        public int GreenDecimal { get; private set; }
        public int BlueDecimal { get; private set; }

        private string hexString;

        public void AssignHexValue(string hexValue)
        {
            this.hexString = hexValue;
            this.ConvertToRGB();
        }

        private void ConvertToRGB()
        {
            string redText = "";
            string greenText = "";
            string blueText = "";

            redText = hexString.Substring(0, 2);
            greenText = hexString.Substring(2, 2);
            blueText = hexString.Substring(4, 2);

            RedDecimal = ConvertHexToDex(redText);
            GreenDecimal = ConvertHexToDex(greenText);
            BlueDecimal = ConvertHexToDex(blueText);
        }

        private int ConvertHexToDex(string hexString)
        {
            int result = 0;

            int maxCount = hexString.Length;
            for (int i = 0; i < maxCount; i++)
            {
                int parsedInt = GetDecimalValueFromHexString(hexString.Substring(i,1));
                result = result + (int)(Math.Floor(parsedInt * Math.Pow(16, i)));
            }

            return result;
        }

        private int GetDecimalValueFromHexString(string hexString)
        {
            int result = 0;

            switch(hexString)
            {
                case "A": result = 10; break;
                case "B": result = 11; break;
                case "C": result = 12; break;
                case "D": result = 13; break;
                case "E": result = 14; break;
                case "F": result = 15; break;
                default:
                    {
                        int.TryParse(hexString, out result);
                    }
                    break;
            }

            return result;
        }
    }
}
