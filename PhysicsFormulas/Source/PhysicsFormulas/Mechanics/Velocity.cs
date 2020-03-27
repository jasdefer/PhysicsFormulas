using System;

namespace PhysicsFormulas.Mechanics
{
    /// <summary>
    /// This static class contains multiple methods to calculate the velocity.
    /// </summary>
    public static class Velocity
    {
        /// <summary>
        /// Calculate the start velocity required to move the distance <paramref name="s"/> when accelerating uniformly with <paramref name="a"/> in the duration of <paramref name="t"/>.
        /// </summary>
        /// <param name="s">The displacement.</param>
        /// <param name="t">The duration.</param>
        /// <param name="a">The acceleration.</param>
        /// <returns>Returns the velocity value.</returns>
        public static double UniformAcceleration(double s, double t, double a = 0)
        {
            if (t == 0)
            {
                throw new DivideByZeroException();
            }
            return s / t - a * t / 2;
        }

        /// <summary>
        /// Calculate the velocity when acceleration with <paramref name="a"/> over a duration of <paramref name="t"/>.
        /// </summary>
        /// <param name="t">The duration.</param>
        /// <param name="a">The acceleration.</param>
        /// <returns>Returns the velocity value.</returns>
        public static double Accelerate(double t, double a)
        {
            return a * t;
        }

        /// <summary>
        /// Calculate the start velocity required to move a distance of <paramref name="s"/> in the duration <paramref name="t"/>.
        /// </summary>
        /// <param name="s">The displacement.</param>
        /// <param name="t">The duration.</param>
        /// <returns>Returns the velocity value.</returns>
        public static double SteadyMotion(double s, double t)
        {
            if (t == 0)
            {
                throw new DivideByZeroException();
            }
            return s / t;
        }
    }
}