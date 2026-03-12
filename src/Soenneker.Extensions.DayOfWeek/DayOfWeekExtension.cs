using Soenneker.Enums.DayOfWeek;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Extensions.DayOfWeek;

/// <summary>
/// A collection of helpful DayOfWeek enum extension methods
/// </summary>
public static class DayOfWeekExtension
{
    /// <summary>
    /// Converts the specified nullable day of week value to its corresponding single-character representation.
    /// </summary>
    /// <remarks>If the provided value does not correspond to a recognized day of the week, the method returns
    /// the null character ('\0'). This method is intended for scenarios where a compact, single-character
    /// representation of a day is required.</remarks>
    /// <param name="day">The nullable day of week value to convert. If null, the method returns the null character ('\0').</param>
    /// <returns>A character representing the specified day of the week. Returns 'M' for Monday, 'T' for Tuesday or Thursday, 'W'
    /// for Wednesday, 'F' for Friday, 'S' for Saturday or Sunday, or '\0' if the value is null or unrecognized.</returns>
    [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static char ToChar(this DayOfWeekType? day)
    {
        if (day is null)
            return '\0';

        return day.Value switch
        {
            DayOfWeekType.MondayValue => 'M',
            DayOfWeekType.TuesdayValue => 'T',
            DayOfWeekType.WednesdayValue => 'W',
            DayOfWeekType.ThursdayValue => 'T',
            DayOfWeekType.FridayValue => 'F',
            DayOfWeekType.SaturdayValue => 'S',
            DayOfWeekType.SundayValue => 'S',
            _ => '\0'
        };
    }

    /// <summary>
    /// Returns the single-letter abbreviation corresponding to the specified day of the week.
    /// </summary>
    /// <remarks>Monday is represented as "M", Tuesday and Thursday as "T", Wednesday as "W", Friday as "F",
    /// and Saturday and Sunday as "S".</remarks>
    /// <param name="day">The day of the week to convert to a single-letter abbreviation, or null.</param>
    /// <returns>A string containing the single-letter abbreviation for the specified day of the week. Returns an empty string if
    /// <paramref name="day"/> is null or does not represent a valid day.</returns>
    [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToLetter(this DayOfWeekType? day)
    {
        // Avoid allocating via c.ToString() by returning cached single-char strings.
        return day?.Value switch
        {
            DayOfWeekType.MondayValue => "M",
            DayOfWeekType.TuesdayValue => "T",
            DayOfWeekType.WednesdayValue => "W",
            DayOfWeekType.ThursdayValue => "T",
            DayOfWeekType.FridayValue => "F",
            DayOfWeekType.SaturdayValue => "S",
            DayOfWeekType.SundayValue => "S",
            _ => string.Empty
        };
    }
}
