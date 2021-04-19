using System;

namespace PhysicsFormulas.Mechanics.Force
{
    /// <summary>
    /// Fn = Fg * cos(alpha)
    /// </summary>
    public static class NormalForce
    {
        /// <summary>
        /// Find Fn in Fn = Fg * cos(alpha)
        /// </summary>
        /// <param name="fg">The weight force [N=kg*m/s²]</param>
        /// <param name="alpha">The angle of the slope [radians].</param>
        /// <returns>Returns the normal force [N=kg*m/s²].</returns>
        public static double GetNormalForce(double fg, double alpha)
        {
            var fn = fg * Math.Cos(alpha);
            return fn;
        }

        /// <summary>
        /// Find Fg in Fn = Fg * cos(alpha)
        /// </summary>
        /// <param name="fn">The normal force [N=kg*m/s²]</param>
        /// <param name="alpha">The angle of the slope [radians].</param>
        /// <returns>Returns the weight force [N=kg*m/s²].</returns>
        public static double GetWeightForce(double fn, double alpha)
        {
            var fg = fn / Math.Cos(alpha);
            return fg;
        }

        /// <summary>
        /// Find alpha in Fn = Fg * cos(alpha)
        /// </summary>
        /// <param name="fn">The normal force [N=kg*m/s²]</param>
        /// <param name="fg">The weight force [N=kg*m/s²]</param>
        /// <returns>Returns the angle of the slope [radians].</returns>
        public static double GetAlpha(double fn, double fg)
        {
            var alpha = Math.Acos(fn/fg);
            return alpha;
        }
    }
}