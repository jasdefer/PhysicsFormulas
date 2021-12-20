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
        /// <param name="massVehicle">The mass of the vehicle which performs the acceleration [kg].</param>
        /// <param name="massLoad">The mass of the load, which the vehicle pulls while accelerating [kg].</param>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <returns>Returns the force [N=kg*m/s²].</returns>
        public static double GetForce(double e, double massVehicle, double massLoad, double a)
        {
            var f = (e * massVehicle + massLoad) * a;
            return f;
        }

        /// <summary>
        /// Find e in F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
        /// </summary>
        /// <param name="f">Force [N=kg*m/s²]</param>
        /// <param name="massVehicle">The mass of the vehicle which performs the acceleration [kg].</param>
        /// <param name="massLoad">The mass of the load, which the vehicle pulls while accelerating [kg].</param>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <returns>Returns the mass factor describing the inertia torque of the accelerating parts of the vehicle.</returns>
        public static double GetMassFactor(double f, double massVehicle, double massLoad, double a)
        {
            var e = f / (a * massVehicle) - massLoad / massVehicle;
            return e;
        }

        /// <summary>
        /// Find massOftheVehicle in F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
        /// </summary>
        /// <param name="f">Force [N=kg*m/s²]</param>
        /// <param name="e">A mass factor describing the inertia torque of the accelerating parts of the vehicle.</param>
        /// <param name="massLoad">The mass of the load, which the vehicle pulls while accelerating [kg].</param>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <returns>Returns the mass of the vehicle.</returns>
        public static double GetVehicleMass(double f, double e, double massLoad, double a)
        {
            var massVehicle = f / (e * a) - massLoad / e;
            return massVehicle;

        }

        /// <summary>
        /// Find massOfTheVehicleLoad in F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
        /// </summary>
        /// <param name="f">Force [N=kg*m/s²]</param>
        /// <param name="e">A mass factor describing the inertia torque of the accelerating parts of the vehicle.</param>
        /// <param name="massVehicle">The mass of the vehicle which performs the acceleration [kg].</param>
        /// <param name="a">The acceleration [m/s²].</param>
        /// <returns>Returns the mass of the vehicle load.</returns>
        public static double GetVehicleLoad(double f, double e, double massVehicle, double a)
        {
            var massLoad = f / a - e * massVehicle;
            return massLoad;
        }

        /// <summary>
        /// Find a in F = (e * massOftheVehicle + massOfTheVehicleLoad) * a
        /// </summary>
        /// <param name="f">Force [N=kg*m/s²]</param>
        /// <param name="e">A mass factor describing the inertia torque of the accelerating parts of the vehicle.</param>
        /// <param name="massVehicle">The mass of the vehicle which performs the acceleration [kg].</param>
        /// <param name="massLoad">The mass of the load, which the vehicle pulls while accelerating [kg].</param>
        /// <returns>Returns the acceleration [m/s²].</returns>
        public static double GetAcceleration(double f, double e, double massVehicle, double massLoad)
        {
            var a = f / (e * massVehicle + massLoad);
            return a;
        }
    }
}