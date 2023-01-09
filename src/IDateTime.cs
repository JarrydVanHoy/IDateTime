namespace System;

/// <summary>
/// Injectable interface to decouple yourself from use of the DateTime class directly
/// </summary>
public interface IDateTime
{
    /// <summary>
    /// Returns DateTime.Now() by default
    /// </summary>
    /// <returns></returns>
    DateTime Now();
    
    /// <summary>
    /// Returns DateTime.UtcNow() by default
    /// </summary>
    /// <returns></returns>
    DateTime UtcNow();
    
    /// <summary>
    /// Returns DateTime.Today() by default
    /// </summary>
    /// <returns></returns>
    DateTime Today();
    
    /// <summary>
    /// Returns DateTime.MinValue() by default
    /// </summary>
    /// <returns></returns>
    DateTime MinValue();
    
    /// <summary>
    /// Returns DateTime.MaxValue() by default
    /// </summary>
    /// <returns></returns>
    DateTime MaxValue();
    
    /// <summary>
    /// Returns DateTime.UnixEpoch() by default
    /// </summary>
    /// <returns></returns>
    DateTime UnixEpoch();
}