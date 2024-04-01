using System;

/// <summary>
/// Service for figuring durations
/// </summary>
public static class DurationService
{
    /// <summary>
    /// Calculates the number of days between two dates, rounding up.
    /// </summary>
    /// <returns>The number of days between two dates, rounding up.</returns>
    public static int DurationInDays(DateTime startDate, DateTime endDate)
    {
        TimeSpan rentalPeriod = endDate - startDate;
        int transactionDurationInDays = (int)Math.Ceiling(rentalPeriod.TotalDays);
        return transactionDurationInDays;
    }
}
