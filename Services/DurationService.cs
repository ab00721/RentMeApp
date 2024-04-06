using System;

/// <summary>
/// Service for figuring durations
/// </summary>
public static class DurationService
{
    /// <summary>
    /// Calculates the number of days between two dates, rounding up and including partial days.
    /// </summary>
    /// <returns>The number of days between two dates, rounding up and including partial days.</returns>
    public static int DurationInDays(DateTime startDate, DateTime endDate)
    {
        TimeSpan rentalPeriod = endDate - startDate;
        int transactionDurationInDays = (int)Math.Ceiling(rentalPeriod.TotalDays) + 1;
        return transactionDurationInDays;
    }
}
