using System;

namespace PhysicsFormulas.Mechanics
{
    public static class Duration
    {
        public static (double t1, double t2)UniformAcceleration(double v, double s, double a = 0)
        {
            if (a == 0)
            {
                return (SteadyMovement(v, s), SteadyMovement(v, s));
            }
            var sqrt = 2 * a * s + v * v;
            if (sqrt < 0)
            {
                throw new Exception($"There is no solution for v={v}, s={s} and a={a}.");
            }
            var t1 = (-Math.Sqrt(sqrt) - v) / a;
            var t2 = (Math.Sqrt(sqrt) - v) / a;
            return (t1,t2);
        }

        public static double SteadyMovement(double v , double s)
        {
            if (v == 0)
            {
                if (s == 0)
                {
                    return 0;
                }
                throw new DivideByZeroException("velocity");
            }
            var t = s / v;
            return s/v;
        }
    }
}