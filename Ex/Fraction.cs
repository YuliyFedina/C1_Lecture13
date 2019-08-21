using System;

namespace Ex
{
    [Serializable]
    public class Fraction
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Fraction(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X == 0 ? $"{X}" : $"{X}/{Y}";
        }
    }
}