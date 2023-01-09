namespace IDateTime;

public class DateTimeProvider : IDateTime
{
    public DateTime Now()
    {
        return DateTime.Now;
    }

    public DateTime UtcNow()
    {
        return DateTime.UtcNow;
    }

    public DateTime Today()
    {
        return DateTime.Today;
    }

    public DateTime MinValue()
    {
        return DateTime.MinValue;
    }

    public DateTime MaxValue()
    {
        return DateTime.MaxValue;
    }

    public DateTime UnixEpoch()
    {
        return DateTime.UnixEpoch;
    }
}