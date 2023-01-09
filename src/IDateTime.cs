namespace IDateTime;

public interface IDateTime
{
    DateTime Now();
    DateTime UtcNow();
    DateTime Today();
    DateTime MinValue();
    DateTime MaxValue();
    DateTime UnixEpoch();
}