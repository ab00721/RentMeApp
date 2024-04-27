using System;

/// <summary>
/// Service for figuring durations
/// </summary>
public static class DurationService
{
    /// <summary>
    /// Calculates the duration of a rental in days.
    /// </summary>
    /// <param name="startDate">The start date of the rental.</param>
    /// <param name="endDate">The end date of the rental.</param>
    /// <returns>The duration of the rental in days.</returns>
    public static int RentalDurationInDays(DateTime startDate, DateTime endDate)
    {
        TimeSpan rentalPeriod = endDate - startDate;
        int transactionDurationInDays = (int)Math.Ceiling(rentalPeriod.TotalDays) + 1;
        return transactionDurationInDays;
    }
    
    /// <summary>
    /// Calculates the duration of returning an item in days.
    /// </summary>
    /// <param name="startDate">The start date of the return.</param>
    /// <param name="endDate">The end date of the return.</param>
    /// <returns>The duration of the return in days.</returns>
    public static int ReturnDurationInDays(DateTime startDate, DateTime endDate)
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
