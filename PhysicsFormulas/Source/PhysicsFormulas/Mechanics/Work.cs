namespace PhysicsFormulas.Mechanics
{
    public static class Work
    {
        /// <summary>
        /// Calculate the work done to move an object the distance <paramref name="s"/> with the force <paramref name="f"/>.
        /// </summary>
        /// <param name="f">The force</param>
        /// <param name="s">The displacement</param>
        /// <returns>Return the value of the force.</returns>
        public static double ConstantForce(double f, double s)
        {
            return f * s;
        }
    }
}