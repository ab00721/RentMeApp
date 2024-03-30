using System;

/// <summary>
/// Service for figuring durations
/// </summary>
public static class DurationService
{
    /// <summary>
    /// Calculates the number of days between two dates.
    /// </summary>
    /// <returns>The number of days between two dates.</returns>
    public static int DurationInDays(DateTime rentalDate, DateTime dueDate)
    {
        TimeSpan rentalPeriod = dueDate - rentalDate;
        int transactionDurationInDays = rentalPeriod.Days;
        return transactionDurationInDays;
    }
}
