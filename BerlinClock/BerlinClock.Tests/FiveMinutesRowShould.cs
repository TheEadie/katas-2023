using Shouldly;

namespace BerlinClock.Tests;

public class FiveMinutesRowShould
{
    private static object[] _testCases =
    {
        new object[] {new TimeOnly(12, 0, 0), FiveMinuteRow.ZeroMins},
        new object[] {new TimeOnly(12, 1, 0), FiveMinuteRow.ZeroMins},
        new object[] {new TimeOnly(12, 2, 0), FiveMinuteRow.ZeroMins},
        new object[] {new TimeOnly(12, 3, 0), FiveMinuteRow.ZeroMins},
        new object[] {new TimeOnly(12, 4, 0), FiveMinuteRow.ZeroMins},
        new object[] {new TimeOnly(12, 5, 0), FiveMinuteRow.FiveMins},
        new object[] {new TimeOnly(12, 6, 0), FiveMinuteRow.FiveMins},
        new object[] {new TimeOnly(12, 7, 0), FiveMinuteRow.FiveMins},
        new object[] {new TimeOnly(12, 8, 0), FiveMinuteRow.FiveMins},
        new object[] {new TimeOnly(12, 9, 0), FiveMinuteRow.FiveMins},
        new object[] {new TimeOnly(12, 10, 0), FiveMinuteRow.TenMins},
        new object[] {new TimeOnly(12, 11, 0), FiveMinuteRow.TenMins},
        new object[] {new TimeOnly(12, 12, 0), FiveMinuteRow.TenMins},
        new object[] {new TimeOnly(12, 13, 0), FiveMinuteRow.TenMins},
        new object[] {new TimeOnly(12, 14, 0), FiveMinuteRow.TenMins},
        new object[] {new TimeOnly(12, 15, 0), FiveMinuteRow.FifteenMins},
        new object[] {new TimeOnly(12, 16, 0), FiveMinuteRow.FifteenMins},
        new object[] {new TimeOnly(12, 17, 0), FiveMinuteRow.FifteenMins},
        new object[] {new TimeOnly(12, 18, 0), FiveMinuteRow.FifteenMins},
        new object[] {new TimeOnly(12, 19, 0), FiveMinuteRow.FifteenMins},
        new object[] {new TimeOnly(12, 20, 0), FiveMinuteRow.TwentyMins},
        new object[] {new TimeOnly(12, 21, 0), FiveMinuteRow.TwentyMins},
        new object[] {new TimeOnly(12, 22, 0), FiveMinuteRow.TwentyMins},
        new object[] {new TimeOnly(12, 23, 0), FiveMinuteRow.TwentyMins},
        new object[] {new TimeOnly(12, 24, 0), FiveMinuteRow.TwentyMins},
        new object[] {new TimeOnly(12, 25, 0), FiveMinuteRow.TwentyFiveMins},
        new object[] {new TimeOnly(12, 26, 0), FiveMinuteRow.TwentyFiveMins},
        new object[] {new TimeOnly(12, 27, 0), FiveMinuteRow.TwentyFiveMins},
        new object[] {new TimeOnly(12, 28, 0), FiveMinuteRow.TwentyFiveMins},
        new object[] {new TimeOnly(12, 29, 0), FiveMinuteRow.TwentyFiveMins},
        new object[] {new TimeOnly(12, 30, 0), FiveMinuteRow.ThirtyMins},
        new object[] {new TimeOnly(12, 31, 0), FiveMinuteRow.ThirtyMins},
        new object[] {new TimeOnly(12, 32, 0), FiveMinuteRow.ThirtyMins},
        new object[] {new TimeOnly(12, 33, 0), FiveMinuteRow.ThirtyMins},
        new object[] {new TimeOnly(12, 34, 0), FiveMinuteRow.ThirtyMins},
        new object[] {new TimeOnly(12, 35, 0), FiveMinuteRow.ThirtyFiveMins},
        new object[] {new TimeOnly(12, 36, 0), FiveMinuteRow.ThirtyFiveMins},
        new object[] {new TimeOnly(12, 37, 0), FiveMinuteRow.ThirtyFiveMins},
        new object[] {new TimeOnly(12, 38, 0), FiveMinuteRow.ThirtyFiveMins},
        new object[] {new TimeOnly(12, 39, 0), FiveMinuteRow.ThirtyFiveMins},
        new object[] {new TimeOnly(12, 40, 0), FiveMinuteRow.FortyMins},
        new object[] {new TimeOnly(12, 41, 0), FiveMinuteRow.FortyMins},
        new object[] {new TimeOnly(12, 42, 0), FiveMinuteRow.FortyMins},
        new object[] {new TimeOnly(12, 43, 0), FiveMinuteRow.FortyMins},
        new object[] {new TimeOnly(12, 44, 0), FiveMinuteRow.FortyMins},
        new object[] {new TimeOnly(12, 45, 0), FiveMinuteRow.FortyFiveMins},
        new object[] {new TimeOnly(12, 46, 0), FiveMinuteRow.FortyFiveMins},
        new object[] {new TimeOnly(12, 47, 0), FiveMinuteRow.FortyFiveMins},
        new object[] {new TimeOnly(12, 48, 0), FiveMinuteRow.FortyFiveMins},
        new object[] {new TimeOnly(12, 49, 0), FiveMinuteRow.FortyFiveMins},
        new object[] {new TimeOnly(12, 50, 0), FiveMinuteRow.FiftyMins},
        new object[] {new TimeOnly(12, 51, 0), FiveMinuteRow.FiftyMins},
        new object[] {new TimeOnly(12, 52, 0), FiveMinuteRow.FiftyMins},
        new object[] {new TimeOnly(12, 53, 0), FiveMinuteRow.FiftyMins},
        new object[] {new TimeOnly(12, 54, 0), FiveMinuteRow.FiftyMins},
        new object[] {new TimeOnly(12, 55, 0), FiveMinuteRow.FiftyFiveMins},
        new object[] {new TimeOnly(12, 56, 0), FiveMinuteRow.FiftyFiveMins},
        new object[] {new TimeOnly(12, 57, 0), FiveMinuteRow.FiftyFiveMins},
        new object[] {new TimeOnly(12, 58, 0), FiveMinuteRow.FiftyFiveMins},
        new object[] {new TimeOnly(12, 59, 0), FiveMinuteRow.FiftyFiveMins},
    };

    [TestCaseSource(nameof(_testCases))]
    public void ConvertFromTimeToFiveMinuteRow(TimeOnly input, FiveMinuteRow expected)
    {
        var berlinClockTime = BerlinClockConverter.ConvertToBerlinClock(input);
        berlinClockTime.FiveMinuteRow.ShouldBe(expected);
    }
}