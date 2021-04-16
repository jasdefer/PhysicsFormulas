using System;

namespace PhysicsFormulas.Mechanics.Translation
{
    /// <summary>
    /// s = 0.5*a*t² + v0*t
    /// a = dv/dt
    /// </summary>
    public class UniformAcceleration
    {
        /// <summary>
        /// Find s in s = 0.5*a*t² + v0*t
        /// </summary>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <param name="t">The duration [s].</param>
        /// <param name="v0">The initial velocity [m/s].</param>
        /// <returns>Returns the distance [m].</returns>
        public static double GetDistance(double a, double t, double v0)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find a in s = 0.5*a*t² + v0*t
        /// </summary>
        /// <param name="s">The distance [m].</param>
        /// <param name="t">The duration [s].</param>
        /// <param name="v0">The initial velocity [m/s].</param>
        /// <returns>Returns the acceleration [m/s².</returns>
        public static double GetAcceleration(double s, double t, double v0)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find t in s = 0.5*a*t² + v0*t
        /// </summary>
        /// <param name="s">The distance [m].</param>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <param name="v0">The initial velocity [m/s].</param>
        /// <returns>Returns the duration [s].</returns>
        public static (double t1, double t2) GetDuration(double s, double a, double v0)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find v0 in s = 0.5*a*t² + v0*t
        /// </summary>
        /// <param name="s">The distance [m].</param>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <param name="t">The duration [s].</param>
        /// <returns>Returns the initial velocity [m/s].</returns>
        public static double GetStartVelocity(double s, double a, double t)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find a in a = dv/dt
        /// </summary>
        /// <param name="dv">The change in velocity [m/s].</param>
        /// <param name="dt">The duration [s].</param>
        /// <returns>Returns the acceleration [m/s²].</returns>
        public static double GetAcceleration(double dv, double dt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find dv in a = dv/dt
        /// </summary>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <param name="dt">The duration [s].</param>
        /// <returns>Returns the change in velocity [m/s].</returns>
        public static double GetDeltaVelocity(double a, double dt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find dt in a = dv/dt
        /// </summary>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <param name="dv">The change in velocity [m/s].</param>
        /// <returns>Returns the duration [s].</returns>
        public static double GetDeltaDuration(double a, double dv)
        {
            throw new NotImplementedException();
        }
    }
}