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
        /// <param name="fg">Weight force</param>
        /// <param name="alpha">The angle of the slope measured in radians.</param>
        /// <returns>Returns the downhill force.</returns>
        public static double GetDownhillForce(double fg, double alpha)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find Fg in F = Fg * sin(alpha)
        /// </summary>
        /// <param name="f">Downhill force</param>
        /// <param name="alpha">The angle of the slope measured in radians.</param>
        /// <returns>Returns the weight force.</returns>
        public static double GetWeightForce(double f, double alpha)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find alpha in F = Fg * sin(alpha)
        /// </summary>
        /// <param name="f">Downhill force</param>
        /// <param name="fg">Weight force</param>
        /// <returns>Returns the angle of the slope [radians].</returns>
        public static double GetAlpha(double f, double fg)
        {
            throw new NotImplementedException();
        }
    }
}