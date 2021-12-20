using System.Diagnostics.CodeAnalysis;

namespace PhysicsFormulas.Model;

/// <summary>
/// A tuple of two duration values
/// </summary>
public struct Durations : IEquatable<Durations>
{
    /// <summary>
    /// Create a new tuple of durations
    /// </summary>
    /// <param name="duration1">The first duration variable.</param>
    /// <param name="duration2">The second duration variable.</param>
    public Durations(double duration1,
        double duration2)
    {
        if (duration2 < duration1)
        {
            Duration1 = duration2;
            Duration2 = duration1;
        }
        else
        {
            Duration1 = duration1;
            Duration2 = duration2;
        }

    }

    /// <summary>
    /// The first duration [s]
    /// </summary>
    public double Duration1 { get; }

    /// <summary>
    /// The second duration [s]
    /// </summary>
    public double Duration2 { get; }


    /// <summary>
    /// Get the smallest positive duration
    /// </summary>
    /// <exception cref="NegativeValueException">Throws, if both durations are negative.</exception>
    /// <returns>Returns the smallest positive duration [m].</returns>
    [SuppressMessage("Design", "CA1024:Use properties where appropriate", Justification = "Logic too complex for a property")]
    public double GetSmallestPositiveDuration()
    {
        if (Duration1 < 0)
        {
            if (Duration2 < 0)
            {
                throw new NegativeValueException($"{Duration1} and {Duration2} are both negative values.");
            }
            return Duration2;
        }
        if (Duration2 < 0)
        {
            return Duration1;
        }
        return Duration1 < Duration2 ? Duration1 : Duration2;
    }

    /// <summary>
    /// Indicates if this instance is equal to another instance.
    /// </summary>
    /// <param name="obj">The comparing object.</param>
    /// <returns>True if the comparing object is a Durations struct and the the first and second duration are equal respectively.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is not Durations)
            return false;

        return base.Equals((Durations)obj);
    }

    /// <summary>
    /// Indicates if this instance is equal to another instance.
    /// </summary>
    /// <param name="other">The comparing Durations instance.</param>
    /// <returns>True if the first and second duration are equal respectively.</returns>
    public bool Equals(Durations other)
    {
        return Duration1 == other.Duration1 &&
            Duration2 == other.Duration2;
    }

    /// <summary>
    /// Returns the hash code for this instance.
    /// </summary>
    /// <returns>A 32-bit signed integer hash code.</returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Duration1, Duration2);
    }

    /// <summary>
    /// Converts the tuple of durations to a string.
    /// </summary>
    /// <returns>A string in the format "({Duration1};{Duration2})"</returns>
    public override string ToString()
    {
        return $"({Duration1};{Duration2})";
    }

    /// <summary>
    /// Compare, if both durations are equal.
    /// </summary>
    /// <param name="left">The first instance.</param>
    /// <param name="right">The second instance.</param>
    /// <returns>True, if both instances are equal.</returns>
    public static bool operator ==(Durations left, Durations right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// Compare, if both durations are not equal.
    /// </summary>
    /// <param name="left">The first instance.</param>
    /// <param name="right">The second instance.</param>
    /// <returns>False, if both instances are equal.</returns>
    public static bool operator !=(Durations left, Durations right)
    {
        return !(left == right);
    }
}
