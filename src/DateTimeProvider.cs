namespace System;

/// <summary>
/// Default implementation that acts as a passthrough for the DateTime class.
/// </summary>
public class DateTimeProvider : IDateTime
{
    /// <summary>
    /// Returns DateTime.Now() by default
    /// </summary>
    /// <returns></returns>
    public DateTime Now()
    {
        return DateTime.Now;
    }

    /// <summary>
    /// Returns DateTime.UtcNow() by default
    /// </summary>
    /// <returns></returns>
    public DateTime UtcNow()
    {
        return DateTime.UtcNow;
    }

    /// <summary>
    /// Returns DateTime.Today() by default
    /// </summary>
    /// <returns></returns>
    public DateTime Today()
    {
        return DateTime.Today;
    }

    /// <summary>
    /// Returns DateTime.MinValue() by default
    /// </summary>
    /// <returns></returns>
    public DateTime MinValue()
    {
        return DateTime.MinValue;
    }

    /// <summary>
    /// Returns DateTime.MaxValue() by default
    /// </summary>
    /// <returns></returns>
    public DateTime MaxValue()
    {
        return DateTime.MaxValue;
    }

    /// <summary>
    /// Returns DateTime.UnixEpoch() by default
    /// </summary>
    /// <returns></returns>
    public DateTime UnixEpoch()
    {
        return DateTime.UnixEpoch;
    }
}