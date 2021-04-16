using System;

namespace PhysicsFormulas.Mechanics.Force
{
    /// <summary>
    /// F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
    /// </summary>
    public static class AccelerationForce
    {
        /// <summary>
        /// Find F in F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
        /// </summary>
        /// <param name="e">A mass factor describing the inertia torque of the accelerating parts of the vehicle.</param>
        /// <param name="massVehicle">The mass of the vehicle which performs the acceleration.</param>
        /// <param name="massLoad">The mass of the load, which the vehicle pulls while accelerating.</param>
        /// <param name="a">The acceleration.</param>
        /// <returns>Returns the force.</returns>
        public static double GetForce(double e, double massVehicle, double massLoad, double a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find F in F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
        /// </summary>
        /// <param name="f">Force</param>
        /// <param name="massVehicle">The mass of the vehicle which performs the acceleration.</param>
        /// <param name="massLoad">The mass of the load, which the vehicle pulls while accelerating.</param>
        /// <param name="a">The acceleration.</param>
        /// <returns>Returns the mass factor describing the inertia torque of the accelerating parts of the vehicle.</returns>
        public static double GetMassFactor(double f, double massVehicle, double massLoad, double a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find massOftheVehicle in F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
        /// </summary>
        /// <param name="f">Force</param>
        /// <param name="e">A mass factor describing the inertia torque of the accelerating parts of the vehicle.</param>
        /// <param name="massLoad">The mass of the load, which the vehicle pulls while accelerating.</param>
        /// <param name="a">The acceleration.</param>
        /// <returns>Returns the mass of the vehicle.</returns>
        public static double GetVehicleMass(double f, double e, double massLoad, double a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find massOfTheVehicleLoad in F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
        /// </summary>
        /// <param name="f">Force</param>
        /// <param name="e">A mass factor describing the inertia torque of the accelerating parts of the vehicle.</param>
        /// <param name="massVehicle">The mass of the vehicle which performs the acceleration.</param>
        /// <param name="a">The acceleration.</param>
        /// <returns>Returns the mass of the vehicle load.</returns>
        public static double GetVehicleLoad(double f, double e, double massVehicle, double a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find a in F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
        /// </summary>
        /// <param name="f">Force</param>
        /// <param name="e">A mass factor describing the inertia torque of the accelerating parts of the vehicle.</param>
        /// <param name="massVehicle">The mass of the vehicle which performs the acceleration.</param>
        /// <param name="massLoad">The mass of the load, which the vehicle pulls while accelerating.</param>
        /// <returns>Returns the acceleration.</returns>
        public static double GetAcceleration(double f, double e, double massVehicle, double massLoad)
        {
            throw new NotImplementedException();
        }
    }
}