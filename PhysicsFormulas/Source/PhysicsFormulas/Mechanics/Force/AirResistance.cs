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
        /// <param name="area">The projected front surface area [m²].</param>
        /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level [kg/m³].</param>
        /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind [m/s].</param>
        /// <returns>Returns the air resistance [N=kg*m/s²].</returns>
        public static double GetForce(double cw, double area, double airDensity, double relativeVelocity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find cw in  F = cw * area * airDensity * relativeVelocity² / 2;
        /// </summary>
        /// <param name="f">The air resistance [N=kg*m/s²].</param>
        /// <param name="area">The projected front surface area [m²].</param>
        /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level [kg/m³].</param>
        /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind [m/s].</param>
        /// <returns>Returns the drag coefficient of the moving object.</returns>
        public static double GetDragCoefficient(double f,double area, double airDensity, double relativeVelocity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find area in  F = cw * area * airDensity * relativeVelocity² / 2;
        /// </summary>
        /// <param name="f">The air resistance [N=kg*m/s²].</param>
        /// <param name="cw">The drag coefficient of the moving object.</param>
        /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level [kg/m³].</param>
        /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind [m/s].</param>
        /// <returns>Returns the projected front surface area [m²].</returns>
        public static double GetArea(double f, double cw, double airDensity, double relativeVelocity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find airDensity in  F = cw * area * airDensity * relativeVelocity² / 2;
        /// </summary>
        /// <param name="f">The air resistance [N=kg*m/s²].</param>
        /// <param name="cw">The drag coefficient of the moving object.</param>
        /// <param name="area">The projected front surface area [m²].</param>
        /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind [m/s].</param>
        /// <returns>Returns the density of the air [kg/m³].</returns>
        public static double GetAirDensity(double f, double cw, double area, double relativeVelocity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find relativeVelocity in  F = cw * area * airDensity * relativeVelocity² / 2;
        /// </summary>
        /// <param name="f">The air resistance [N=kg*m/s²].</param>
        /// <param name="cw">The drag coefficient of the moving object.</param>
        /// <param name="area">The projected front surface area [m²].</param>
        /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level [kg/m³].</param>
        /// <returns>Returns the relative velocity of the vehicle against the wind [m/s].</returns>
        public static double GetRelativeVelocity(double f, double cw, double area, double airDensity)
        {
            throw new NotImplementedException();
        }
    }
}