using System;

namespace PhysicsFormulas.Mechanics.Force
{
    /// <summary>
    /// F = cw * area * airDensity * relativeVelocity² / 2;
    /// </summary>
    public static class AirResistance
    {
        /// <summary>
        /// Find F in  F = cw * area * airDensity * relativeVelocity² / 2;
        /// </summary>
        /// <param name="cw">The drag coefficient of the moving object.</param>
        /// <param name="area">The projected front surface area.</param>
        /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level.</param>
        /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind.</param>
        /// <returns>Returns the air resistance</returns>
        public static double GetForce(double cw, double area, double airDensity, double relativeVelocity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find cw in  F = cw * area * airDensity * relativeVelocity² / 2;
        /// </summary>
        /// <param name="f">The air resistance.</param>
        /// <param name="area">The projected front surface area.</param>
        /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level.</param>
        /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind.</param>
        /// <returns>Returns the drag coefficient of the moving object.</returns>
        public static double GetDrawCoefficient(double f,double area, double airDensity, double relativeVelocity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find area in  F = cw * area * airDensity * relativeVelocity² / 2;
        /// </summary>
        /// <param name="f">The air resistance.</param>
        /// <param name="cw">The drag coefficient of the moving object.</param>
        /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level.</param>
        /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind.</param>
        /// <returns>Returns the projected front surface area.</returns>
        public static double GetArea(double f, double cw, double airDensity, double relativeVelocity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find airDensity in  F = cw * area * airDensity * relativeVelocity² / 2;
        /// </summary>
        /// <param name="f">The air resistance.</param>
        /// <param name="cw">The drag coefficient of the moving object.</param>
        /// <param name="area">The projected front surface area.</param>
        /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind.</param>
        /// <returns>Returns the density of the air.</returns>
        public static double GetAirDensity(double f, double cw, double area, double relativeVelocity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find relativeVelocity in  F = cw * area * airDensity * relativeVelocity² / 2;
        /// </summary>
        /// <param name="f">The air resistance.</param>
        /// <param name="cw">The drag coefficient of the moving object.</param>
        /// <param name="area">The projected front surface area.</param>
        /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level.</param>
        /// <returns>Returns the relative velocity of the vehicle against the wind,</returns>
        public static double GetRelativeVelocity(double f, double cw, double area, double airDensity)
        {
            throw new NotImplementedException();
        }
    }
}