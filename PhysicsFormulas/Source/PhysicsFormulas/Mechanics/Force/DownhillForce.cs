using System;

namespace PhysicsFormulas.Mechanics.Force
{
    /// <summary>
    /// Calculate the force pulling on an object on a slope.
    /// F = Fg * sin(alpha)
    /// </summary>
    public static class DownhillForce
    {
        /// <summary>
        /// Find F in F = Fg * sin(alpha)
        /// </summary>
        /// <param name="fg">Weight force [N=kg*m/s²]</param>
        /// <param name="alpha">The angle of the slope [radians].</param>
        /// <returns>Returns the downhill force [N=kg*m/s²].</returns>
        public static double GetDownhillForce(double fg, double alpha)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find Fg in F = Fg * sin(alpha)
        /// </summary>
        /// <param name="f">Downhill force [N=kg*m/s²]</param>
        /// <param name="alpha">The angle of the slope [radians].</param>
        /// <returns>Returns the weight force [N=kg*m/s²].</returns>
        public static double GetWeightForce(double f, double alpha)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find alpha in F = Fg * sin(alpha)
        /// </summary>
        /// <param name="f">Downhill force[N=kg*m/s²]</param>
        /// <param name="fg">Weight force [N=kg*m/s²]</param>
        /// <returns>Returns the angle of the slope [radians].</returns>
        public static double GetAlpha(double f, double fg)
        {
            throw new NotImplementedException();
        }
    }
}