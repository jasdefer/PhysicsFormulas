namespace PhysicsFormulas.Mechanics.Energy;

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
        return dw / dt;
    }

    /// <summary>
    /// Find dW in P = dW/dt
    /// </summary>
    /// <param name="p">Power [W=kg*m/s³]</param>
    /// <param name="dt">Duration [s]</param>
    /// <returns>Returns the Work [J=kg*m²/s²].</returns>
    public static double GetDeltaWork(double p, double dt)
    {
        return p * dt;
    }

    /// <summary>
    /// Find dt in P = dW/dt
    /// </summary>
    /// <param name="p">Power [W=kg*m²/s³]</param>
    /// <param name="dw">Work [J=kg*m²/s²]</param>
    /// <returns>Returns the duration [s].</returns>
    public static double GetDeltaTime(double p, double dw)
    {
        return dw / p;
    }
}
