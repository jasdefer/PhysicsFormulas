using System;

namespace PhysicsFormulas.Mechanics
{
    /// <summary>
    /// This static class contains multiple methods to calculate the acceleration.
    /// </summary>
    public static class Acceleration
    {
        /// <summary>
        /// Calculate the uniform acceleration to move the distance <paramref name="s"/> starting with the velocity <paramref name="v0"/> in the duration <paramref name="t"/>.
        /// </summary>
        /// <param name="s">The distance.</param>
        /// <param name="t">The duration.</param>
        /// <param name="v0">The velocity.</param>
        /// <returns>Returns the acceleration value.</returns>
        public static double FromDisplacementOverTime(double s, double t, double v0 = 0)
        {
            if (t == 0)
            {
                throw new DivideByZeroException();
            }
            var a = 2 * (s - t * v0) / (t * t);
            return a;
        }

        /// <summary>
        /// Calculate the uniform acceleration to change the velocity by <paramref name="dV"/> in a timespan of <paramref name="dT"/>.
        /// </summary>
        /// <param name="dV">The change in velocity in m/s.</param>
        /// <param name="dT">The duration in seconds.</param>
        /// <returns>Returns the acceleration in m/s².</returns>
        public static double FromVelocityChange(double dV, double dT)
        {
            if (dT == 0)
            {
                throw new DivideByZeroException();
            }
            return dV / dT;
        }
    }
}