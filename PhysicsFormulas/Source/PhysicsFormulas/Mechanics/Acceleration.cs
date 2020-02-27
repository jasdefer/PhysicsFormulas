using System;

namespace PhysicsFormulas.Mechanics
{
    public static class Acceleration
    {
        public static double UniformAcceleration(double s, double t, double v = 0)
        {
            if (t == 0)
            {
                throw new DivideByZeroException();
            }
            var a = 2 * (s - t * v) / (t * t);
            return a;
        }
    }
}