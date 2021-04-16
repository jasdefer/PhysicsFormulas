using System;

namespace PhysicsFormulas.Mechanics.Energy
{
    /// <summary>
    /// P = dW/dt
    /// </summary>
    public static class Power
    {
        /// <summary>
        /// Find P in P = dW/dt
        /// </summary>
        /// <param name="dw">Work [J=kg*m²/s²]</param>
        /// <param name="dt">Duration [s]</param>
        /// <returns>Returns the power [W=kg*m/s³].</returns>
        public static double GetPower(double dw, double dt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find dW in P = dW/dt
        /// </summary>
        /// <param name="p">Power [W=kg*m/s³]</param>
        /// <param name="dt">Duration [s]</param>
        /// <returns>Returns the Work [J=kg*m²/s²].</returns>
        public static double GetDeltaWork(double p, double dt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find dt in P = dW/dt
        /// </summary>
        /// <param name="p">Power [W=kg*m²/s³]</param>
        /// <param name="dw">Work [J=kg*m²/s²]</param>
        /// <returns>Returns the duration [s].</returns>
        public static double GetDeltaTime(double p, double dw)
        {
            throw new NotImplementedException();
        }
    }
}