namespace PhysicsFormulas.Mechanics.Force;

/// <summary>
/// Calculate the force pulling on an object on a slope.
/// F = Fg * sin(alpha)
/// </summary>
public static class DownhillForce
{
    /// <summary>
    /// Find F in F = Fg * sin(alpha)
    /// </summary>
    /// <param name="fg">Weight force [N=kg*m/s²]</param>
    /// <param name="alpha">The angle of the slope [radians].</param>
    /// <returns>Returns the downhill force [N=kg*m/s²].</returns>
    public static double GetDownhillForce(double fg, double alpha)
    {
        var f = fg * Math.Sin(alpha);
        return f;
    }

    /// <summary>
    /// Find Fg in F = Fg * sin(alpha)
    /// </summary>
    /// <param name="f">Downhill force [N=kg*m/s²]</param>
    /// <param name="alpha">The angle of the slope [radians].</param>
    /// <returns>Returns the weight force [N=kg*m/s²].</returns>
    public static double GetWeightForce(double f, double alpha)
    {
        var fg = f / Math.Sin(alpha);
        return fg;
    }

    /// <summary>
    /// Find alpha in F = Fg * sin(alpha)
    /// </summary>
    /// <param name="f">Downhill force[N=kg*m/s²]</param>
    /// <param name="fg">Weight force [N=kg*m/s²]</param>
    /// <returns>Returns the angle of the slope [radians].</returns>
    public static double GetAlpha(double f, double fg)
    {
        var alpha = Math.Asin(f / fg);
        return alpha;
    }
}
