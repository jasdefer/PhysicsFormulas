using System;

namespace PhysicsFormulas.Mechanics
{
    public static class Force
    {
        /// <summary>
        /// Calculate the rolling resistance.
        /// </summary>
        /// <param name="m">The mass of the moving object.</param>
        /// <param name="alpha">The angle of the slope measured in radians.</param>
        /// <param name="c">Rolling resistance coefficient, which defaults to 0.02 for a car on asphalt.</param>
        /// <param name="g">Gravitational acceleration: 9.81 m/s² on planet earth.</param>
        /// <returns>Returns the rolling resistance in Newton.</returns>
        public static double RollingResistance(double m, double alpha = 0, double c=0.02, double g = 9.81)
        {
            return c * m * g * Math.Cos(alpha);
        }

        /// <summary>
        /// Calculate the force pulling on an object on a slope.
        /// </summary>
        /// <param name="m">The mass of the moving object.</param>
        /// <param name="alpha">The angle of the slope measured in radians.</param>
        /// <param name="g">Gravitational acceleration: 9.81 m/s² on planet earth.</param>
        /// <returns>Returns the downhill force in Newton.</returns>
        public static double DownHillForce(double m, double alpha = 0, double g = 9.81)
        {
            return m * g * Math.Sin(alpha);
        }

        /// <summary>
        /// Calculate the force required to accelerate a given object.
        /// </summary>
        /// <param name="massOftheVehicle">The mass of the vehicle which performs the acceleration.</param>
        /// <param name="massOfTheVehicleLoad">The mass of the load, which the vehicle pulls while accelerating.</param>
        /// <param name="a">The acceleration.</param>
        /// <param name="e">A mass factor describing the inertia torque of the accelerating parts of the vehicle.</param>
        /// <returns>Returns the force required to accelerate the given object in Newton.</returns>
        public static double AccelerationForce(double massOftheVehicle, double massOfTheVehicleLoad, double a, double e = 1)
        {
            return (e * massOftheVehicle + massOfTheVehicleLoad) * a;
        }

        /// <summary>
        /// Calculate the air resistance of a moving object.
        /// </summary>
        /// <param name="cw">The drag coefficient of the moving object.</param>
        /// <param name="area">The projected front surface area.</param>
        /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind.</param>
        /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level.</param>
        /// <returns>Returns the air resistance of a vehicle in Netwon.</returns>
        public static double AirResistance(double cw, double area, double relativeVelocity, double airDensity = 1.2)
        {
            return cw * area * airDensity * relativeVelocity * relativeVelocity / 2;
        }
    }
}