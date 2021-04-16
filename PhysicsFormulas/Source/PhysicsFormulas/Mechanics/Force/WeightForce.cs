using System;

namespace PhysicsFormulas.Mechanics.Force
{
    /// <summary>
    /// Fg = m * g
    /// </summary>
    public class WeightForce
    {
        /// <summary>
        /// Find Fg in Fg = m * g
        /// </summary>
        /// <param name="m">The mass [kg].</param>
        /// <param name="g">Gravitational acceleration: 9.81 m/s² on planet earth [m/s²].</param>
        /// <returns>Returns the weight force [N].</returns>
        public static double GetForce( double m, double g)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find m in Fg = m * g
        /// </summary>
        /// <param name="fg">The weight force [N].</param>
        /// <param name="g">Gravitational acceleration: 9.81 m/s² on planet earth [m/s²].</param>
        /// <returns>Returns the mass [kg].</returns>
        public static double GetMass(double fg, double g)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find g in Fg = m * g
        /// </summary>
        /// <param name="fg">The weight force [N].</param>
        /// <param name="m">The mass [kg].</param>
        /// <returns>Returns the gravitational acceleration.</returns>
        public static double GetGravitationalAcceleration(double fg, double m)
        {
            throw new NotImplementedException();
        }
    }
}