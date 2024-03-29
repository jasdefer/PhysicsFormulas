﻿namespace PhysicsFormulas.Mechanics.Translation;

/// <summary>
/// s = v * t
/// </summary>
public static class SteadyMotion
{
    /// <summary>
    /// Find s in s = v * t
    /// </summary>
    /// <param name="v">The velocity [m/s²].</param>
    /// <param name="t">The duration [s].</param>
    /// <returns>Returns the distance [m].</returns>
    public static double GetDistance(double v, double t)
    {
        var s = v * t;
        return s;
    }

    /// <summary>
    /// Find v in s = v * t
    /// </summary>
    /// <param name="s">The distance [m].</param>
    /// <param name="t">The duration [s].</param>
    /// <returns>Returns the velocity [m/s²].</returns>
    public static double GetVelocity(double s, double t)
    {
        var v = s / t;
        return v;
    }

    /// <summary>
    /// Find t in s = v * t
    /// </summary>
    /// <param name="s">The distance [m].</param>
    /// <param name="v">The velocity [m/s²].</param>
    /// <returns>Returns the duration [s].</returns>
    public static double GetDuration(double s, double v)
    {
        var t = s / v;
        return t;
    }
}
