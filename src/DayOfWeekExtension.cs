using Soenneker.Enums.DayOfWeek;

namespace Soenneker.Extensions.DayOfWeek;

/// <summary>
/// A collection of helpful DayOfWeek enum extension methods
/// </summary>
public static class DayOfWeekExtension
{
    public static string ToLetter(this DayOfWeekType day)
    {
        return day.Name switch
        {
            nameof(DayOfWeekType.Monday) => "M",
            nameof(DayOfWeekType.Tuesday) => "T",
            nameof(DayOfWeekType.Wednesday) => "W",
            nameof(DayOfWeekType.Thursday) => "T",
            nameof(DayOfWeekType.Friday) => "F",
            nameof(DayOfWeekType.Saturday) => "S",
            nameof(DayOfWeekType.Sunday) => "S",
            _ => ""
        };
    }
}
