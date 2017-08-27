using System;

namespace FightingEngine2017
{
    public class Color
    {
        public static readonly Color White = new Color(255, 255, 255);
        public static readonly Color Black = new Color(0, 0, 0);

        public Color(Byte r, Byte g, Byte b)
        {
            R = r;
            G = g;
            B = b;
            A = Byte.MaxValue;
        }
        public Color(Byte r, Byte g, Byte b, Byte a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }
        public Color(Color c)
        {
            R = c.R;
            G = c.G;
            B = c.B;
            A = c.A;
        }

        private Byte R;
        private Byte G;
        private Byte B;
        private Byte A;
    }
}
