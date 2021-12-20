namespace PhysicsFormulas.Mechanics.Energy;

/// <summary>
/// W = F * s
/// </summary>
public static class MechanicalWork
{
    /// <summary>
    /// Find W in W = F * s
    /// </summary>
    /// <param name="f">Force [N=kg*m/s²]</param>
    /// <param name="s">Distance [m]</param>
    /// <returns>Returns the work [J=kg*m²/s²].</returns>
    public static double GetWork(double f, double s)
    {
        return f * s;
    }

    /// <summary>
    /// Find s in W = F * s
    /// </summary>
    /// <param name="w">Work [J=kg*m²/s²]</param>
    /// <param name="f">Force [N=kg*m/s²]</param>
    /// <returns>Returns the distance [m].</returns>
    public static double GetDistance(double w, double f)
    {
        return w / f;
    }

    /// <summary>
    /// Find F in W = F * s
    /// </summary>
    /// <param name="w">Work [J=kg*m²/s²]</param>
    /// <param name="s">Distance [m]</param>
    /// <returns>Returns the force [N=kg*m/s²].</returns>
    public static double GetForce(double w, double s)
    {
        return w / s;
    }
}
