﻿namespace PhysicsFormulas.Mechanics
{
    public static class Displacement
    {
        /// <summary>
        /// Calculate the displacement for a uniform acceleration.
        /// </summary>
        /// <param name="v0">The initial velocity for t=0.</param>
        /// <param name="t">The duration of the uniform acceleration.</param>
        /// <param name="a">The uniform acceleration.</param>
        /// <param name="s0">The displacement for t=0.</param>
        /// <returns>Returns the displacement in meters.</returns>
        public static double UniformAcceleration(double v0, double t, double a = 0, double s0=0)
        {
            return 0.5 * a * t * t + v0 * t + s0;
        }

        /// <summary>
        /// Calculate the displacement for a movement without acceleration.
        /// </summary>
        /// <param name="v0">The initial velocity for t=0.</param>
        /// <param name="t">The duration of the uniform acceleration.</param>
        /// <param name="s0">The displacement for t=0.</param>
        /// <returns>Returns the displacement in meters.</returns>
        public static double SteadyMotion(double v0, double t, double s0 = 0)
        {
            return v0 * t + s0;
        }
    }
}