namespace PhysicsFormulas.Mechanics.Translation
{
    /// <summary>
    /// s = 0.5*a*t² + v0*t
    /// a = dv/dt
    /// </summary>
    public static class UniformAcceleration
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
            var s = 0.5 * a * t * t + v0 * t;
            return s;
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
            var a = 2 * (s - v0 * t) / (t * t);
            return a;
        }

        /// <summary>
        /// Find t in s = 0.5*a*t² + v0*t
        /// </summary>
        /// <param name="s">The distance [m].</param>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <param name="v0">The initial velocity [m/s].</param>
        /// <exception cref="NegativeValueException">Thrown, if the given distance will never be reached.</exception>
        /// <returns>Returns the duration [s].</returns>
        public static Durations GetDuration(double s, double a, double v0)
        {
            if (a == 0)
            {
                var t = SteadyMotion.GetDuration(s, v0);
                return new Durations(t, t);
            }
            var sqrt = 2 * a * s + v0 * v0;
            if (sqrt < 0)
            {
                throw new NegativeValueException($"The distance {s}m will never be reached starting with a velocity of {v0}m/s and accelerating with {a}m/s²");
            }
            var t1 = (-Math.Sqrt(sqrt) - v0) / a;
            var t2 = (Math.Sqrt(sqrt) - v0) / a;
            var durations = new Durations(t1, t2);
            return durations;
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
            var v0 = s / t - 0.5 * a * t;
            return v0;
        }

        /// <summary>
        /// Find a in a = dv/dt
        /// </summary>
        /// <param name="dv">The change in velocity [m/s].</param>
        /// <param name="dt">The duration [s].</param>
        /// <returns>Returns the acceleration [m/s²].</returns>
        public static double GetAcceleration(double dv, double dt)
        {
            var a = dv / dt;
            return a;
        }

        /// <summary>
        /// Find dv in a = dv/dt
        /// </summary>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <param name="dt">The duration [s].</param>
        /// <returns>Returns the change in velocity [m/s].</returns>
        public static double GetDeltaVelocity(double a, double dt)
        {
            var dv = a * dt;
            return dv;
        }

        /// <summary>
        /// Find dt in a = dv/dt
        /// </summary>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <param name="dv">The change in velocity [m/s].</param>
        /// <returns>Returns the duration [s].</returns>
        public static double GetDeltaDuration(double a, double dv)
        {
            var dt = dv / a;
            return dt;
        }
    }
}