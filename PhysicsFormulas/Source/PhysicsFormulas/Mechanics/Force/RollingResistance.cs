using System;

namespace PhysicsFormulas.Mechanics.Force
{
    /// <summary>
    /// Fr = c * Fn
    /// </summary>
    public static class RollingResistance
    {
        /// <summary>
        /// Find Fr in Fr = c * Fn
        /// </summary>
        /// <param name="c">Rolling resistance coefficient, which defaults to 0.02 for a car on asphalt.</param>
        /// <param name="fn">The normal force [N=kg*m/s²].</param>
        /// <returns>Returns the rolling resistance [N=kg*m/s²].</returns>
        public static double GetRollingResistance(double c, double fn)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find c in Fr = c * Fn
        /// </summary>
        /// <param name="fr">The rolling resistance [N=kg*m/s²].</param>
        /// <param name="fn">The normal force [N=kg*m/s²].</param>
        /// <returns>Returns the rolling resistance coefficient, which defaults to 0.02 for a car on asphalt.</returns>
        public static double GetRollingResistanceCoefficient(double fr, double fn)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find Fn in Fr = c * Fn
        /// </summary>
        /// <param name="fr">The rolling resistance [N=kg*m/s²].</param>
        /// <param name="c">Rolling resistance coefficient, which defaults to 0.02 for a car on asphalt.</param>
        /// <returns>Returns the normal force [N=kg*m/s²].</returns>
        public static double GetNormalForce(double fr, double c)
        {
            throw new NotImplementedException();
        }
    }
}