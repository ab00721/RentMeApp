using System;

/// <summary>
/// Service for figuring durations
/// </summary>
public static class DurationService
{    
    /// <summary>
    /// Calculates the duration of a rental period in days.
    /// </summary>
    /// <param name="startDate">The start date of the rental.</param>
    /// <param name="endDate">The end date of the rental.</param>
    /// <returns>The duration of the rental in days.</returns>
    public static int DurationInDays(DateTime startDate, DateTime endDate)
    {
        TimeSpan rentalPeriod = endDate - startDate;
        int transactionDurationInDays = (int)Math.Ceiling(rentalPeriod.TotalDays);
        if (transactionDurationInDays == 0)
        {
            transactionDurationInDays = 1;
        }
        return transactionDurationInDays;
    }
}
