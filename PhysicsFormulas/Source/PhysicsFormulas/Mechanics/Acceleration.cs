using System;

namespace PhysicsFormulas.Mechanics
{
    public static class Acceleration
    {
        /// <summary>
        /// Calculate the uniform acceleration to move the distance <paramref name="s"/> starting with the velocity <paramref name="v0"/> in the duration <paramref name="t"/>.
        /// </summary>
        /// <param name="s">The distance.</param>
        /// <param name="t">The duration.</param>
        /// <param name="v0">The velocity.</param>
        /// <returns>Returns the acceleration value.</returns>
        public static double UniformAcceleration(double s, double t, double v0 = 0)
        {
            if (t == 0)
            {
                throw new DivideByZeroException();
            }
            var a = 2 * (s - t * v0) / (t * t);
            return a;
        }
    }
}