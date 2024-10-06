using System;


namespace DisablakExtensions
{

    public static class MathExtensions
    {
        private const double TOLERANCE            = 1e-10;
        private const int    CENTIMETERS_IN_METER = 100;

        public static int ConvertCmToM(this int cm)
        {
            if (cm == 0)
            {
                return 0;
            }

            return cm / CENTIMETERS_IN_METER;
        }

        public static bool AlmostZero(this float value)
        {
            return Equals(value, 0.0f);
        }

        public static bool Equals(double x, double y, double tolerance = TOLERANCE)
        {
            double diff = Math.Abs(x - y);
            return diff <= tolerance ||
                diff <= Math.Max(Math.Abs(x), Math.Abs(y)) * tolerance;
        }
    }

}