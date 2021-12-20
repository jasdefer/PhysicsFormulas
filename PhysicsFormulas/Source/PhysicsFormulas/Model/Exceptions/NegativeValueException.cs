namespace PhysicsFormulas.Model.Exceptions;

/// <summary>
/// This exception is thrown, if a positive number is expected to be in a set of one or more values, but all of them are negative.
/// </summary>
public class NegativeValueException : Exception
{
    /// <summary>
    /// Create a new instance without a description.
    /// </summary>
    public NegativeValueException() : base()
    {

    }

    /// <summary>
    /// Create a new instance with a description.
    /// </summary>
    /// <param name="message">The message of the exception.</param>
    public NegativeValueException(string message) : base(message)
    {
    }

    /// <summary>
    /// Create a new instance with a description and an inner exception.
    /// </summary>
    /// <param name="message">The message of the outer exception.</param>
    /// <param name="innerException">The inner exception.</param>
    public NegativeValueException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
