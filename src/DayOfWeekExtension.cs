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
    /// Converts the specified day of the week to its corresponding single-character abbreviation.
    /// </summary>
    /// <remarks>If <paramref name="day"/> is Thursday or Tuesday, the method returns 'T'. If it is Saturday
    /// or Sunday, the method returns 'S'.</remarks>
    /// <param name="day">The day of the week to convert. Must be a valid instance of <see cref="DayOfWeekType"/>.</param>
    /// <returns>A character representing the specified day: 'M' for Monday, 'T' for Tuesday or Thursday, 'W' for Wednesday, 'F'
    /// for Friday, and 'S' for Saturday or Sunday. Returns '\0' if <paramref name="day"/> does not match a known day.</returns>
    [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static char ToChar(this DayOfWeekType day)
    {
        if (ReferenceEquals(day, DayOfWeekType.Monday))
            return 'M';

        if (ReferenceEquals(day, DayOfWeekType.Tuesday))
            return 'T';

        if (ReferenceEquals(day, DayOfWeekType.Wednesday))

            return 'W';
        if (ReferenceEquals(day, DayOfWeekType.Thursday))

            return 'T';
        if (ReferenceEquals(day, DayOfWeekType.Friday))
            return 'F';

        if (ReferenceEquals(day, DayOfWeekType.Saturday))
            return 'S';

        if (ReferenceEquals(day, DayOfWeekType.Sunday))
            return 'S';

        return '\0';
    }

    /// <summary>
    /// Converts the specified day of the week to its corresponding single-letter abbreviation.
    /// </summary>
    /// <param name="day">The day of the week to convert to a single-letter abbreviation.</param>
    /// <returns>A string containing the single-letter abbreviation for the specified day of the week, or an empty string if the
    /// day does not have a corresponding letter.</returns>
    [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToLetter(this DayOfWeekType day)
    {
        char c = day.ToChar();
        return c == '\0' ? string.Empty : c.ToString();
    }
}
