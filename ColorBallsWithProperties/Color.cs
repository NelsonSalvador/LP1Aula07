namespace ColorBallsWithProperties
{
    public class Color
    {
        // Instance variables
        public byte Red {set; get;}
        public byte Green {set; get;}
        public byte Blue {set; get;}
        public byte Alpha {set; get;}

        public byte GetGrayscale
        {
            get
            {
                return (byte)((red + green + blue) / 3);
            }
        }

        // Constructors
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

    }
}