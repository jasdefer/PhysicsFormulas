namespace PhysicsFormulas.Mechanics
{
    public static class Power
    {
        /// <summary>
        /// Calculate the rate of doing work per unit of time.
        /// </summary>
        /// <param name="work">The work done.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Calculates the value of power.</returns>
        public static double FromWork(double work, double duration)
        {
            return work / duration;
        }
    }
}