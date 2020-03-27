using System;

namespace PhysicsFormulas.Mechanics
{
    /// <summary>
    /// This static class contains multiple methods to calculate the duration.
    /// </summary>
    public static class Duration
    {
        /// <summary>
        /// Calculates all possible duration values to move the distance <paramref name="s"/> starting with the velocity <paramref name="v0"/> and accelerating uniformly with <paramref name="a"/>.
        /// </summary>
        /// <param name="v0">The velocity of the object at t=0.</param>
        /// <param name="s">The displacement.</param>
        /// <param name="a">The constant acceleration.</param>
        /// <returns>The given distance is reached at two times. Both times are returned. Both times can be equal, if a=0.</returns>
        public static (double t1, double t2)UniformAcceleration(double v0, double s, double a = 0)
        {
            if (a == 0)
            {
                var t = SteadyMovement(v0, s);
                return (t, t);
            }
            var sqrt = 2 * a * s + v0 * v0;
            if (sqrt < 0)
            {
                throw new Exception($"There is no solution for v={v0}, s={s} and a={a}.");
            }
            var t1 = (-Math.Sqrt(sqrt) - v0) / a;
            var t2 = (Math.Sqrt(sqrt) - v0) / a;
            return (t1, t2);
        }

        /// <summary>
        /// Calculates the time to move the distance <paramref name="s"/> with the velocity <paramref name="v"/>.
        /// </summary>
        /// <param name="v">The velocity.</param>
        /// <param name="s">The displacement.</param>
        /// <returns>Returns the time in seconds.</returns>
        public static double SteadyMovement(double v , double s)
        {
            if (v == 0)
            {
                if (s == 0)
                {
                    return 0;
                }
                throw new DivideByZeroException();
            }
            var t = s / v;
            return t;
        }

        /// <summary>
        /// When using the method <seealso cref="UniformAcceleration(double, double, double)"/> two values for the time are returned.
        /// This method returns the smallest positive value.
        /// </summary>
        /// <param name="t1">The first value.</param>
        /// <param name="t2">The second value.</param>
        /// <returns>Returns the smallest positive value.</returns>
        public static double GetSmallestPositiveTime(double t1, double t2)
        {
            if(t1 < 0)
            {
                if (t2 < 0)
                {
                    throw new Exception();
                }
                return t2;
            }
            if (t2 < 0)
            {
                return t1;
            }
            return t1 < t2 ? t1 : t2;
        }
    }
}