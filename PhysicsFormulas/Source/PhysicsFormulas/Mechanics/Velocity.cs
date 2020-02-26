using System;

namespace PhysicsFormulas.Mechanics
{
    public static class Velocity
    {
        public static double UniformAcceleration(double s, double t, double a = 0)
        {
            if (t == 0)
            {
                throw new DivideByZeroException("time");
            }
            return s / t - a * t / 2;
        }

        public static double SteadyMotion(double s, double t)
        {
            if (t == 0)
            {
                throw new DivideByZeroException("time");
            }
            return s / t;
        }
    }
}