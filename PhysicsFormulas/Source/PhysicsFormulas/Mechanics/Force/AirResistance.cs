namespace PhysicsFormulas.Mechanics.Force;

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
        var f = cw * airDensity * relativeVelocity * relativeVelocity * area / 2;
        return f;
    }

    /// <summary>
    /// Find cw in  F = cw * area * airDensity * relativeVelocity² / 2;
    /// </summary>
    /// <param name="f">The air resistance [N=kg*m/s²].</param>
    /// <param name="area">The projected front surface area [m²].</param>
    /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level [kg/m³].</param>
    /// <param name="relativeVelocity">The relative velocity of the vehicle against the wind [m/s].</param>
    /// <returns>Returns the drag coefficient of the moving object.</returns>
    public static double GetDragCoefficient(double f, double area, double airDensity, double relativeVelocity)
    {
        var cw = 2 * f / (area * airDensity * relativeVelocity * relativeVelocity);
        return cw;
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
        var area = 2 * f / (cw * airDensity * relativeVelocity * relativeVelocity);
        return area;
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
        var density = 2 * f / (cw * area * relativeVelocity * relativeVelocity);
        return density;
    }

    /// <summary>
    /// Find relativeVelocity in  F = cw * area * airDensity * relativeVelocity² / 2;
    /// </summary>
    /// <param name="f">The air resistance [N=kg*m/s²].</param>
    /// <param name="cw">The drag coefficient of the moving object.</param>
    /// <param name="area">The projected front surface area [m²].</param>
    /// <param name="airDensity">The density of the air, which defaults to 1.2 kg / m³ at 20°C at sea level [kg/m³].</param>
    /// <returns>Returns the absolute value of the relative velocity of the vehicle against the wind [m/s].</returns>
    public static double GetRelativeVelocity(double f, double cw, double area, double airDensity)
    {
        var sqrt = 2 * f / (cw * area * airDensity);
        var relativeVelocity = Math.Sqrt(sqrt < 0 ? -sqrt : sqrt);
        return relativeVelocity;
    }
}
