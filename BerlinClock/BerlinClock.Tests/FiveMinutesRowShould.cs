using Shouldly;

namespace BerlinClock.Tests;

public class FiveMinutesRowShould
{
    private static object[] _testCases()
    {
        TimeOnly GenerateTimeOnly(int min) => new(12, min, 0);

        FiveMinuteRow GenerateFiveMinuteRow(int lights) => lights switch
        {
            11 => FiveMinuteRow.FiftyFiveMins,
            10 => FiveMinuteRow.FiftyMins,
            9 => FiveMinuteRow.FortyFiveMins,
            8 => FiveMinuteRow.FortyMins,
            7 => FiveMinuteRow.ThirtyFiveMins,
            6 => FiveMinuteRow.ThirtyMins,
            5 => FiveMinuteRow.TwentyFiveMins,
            4 => FiveMinuteRow.TwentyMins,
            3 => FiveMinuteRow.FifteenMins,
            2 => FiveMinuteRow.TenMins,
            1 => FiveMinuteRow.FiveMins,
            0 => FiveMinuteRow.ZeroMins,
            _ => throw new ArgumentOutOfRangeException()
        };

        var testCases = new List<object>();
        int min;
        int lights;
        for (min = 0, lights = 0; min < 60; min++, lights++)
        {
            testCases.Add(new object[] {GenerateTimeOnly(min), GenerateFiveMinuteRow(lights / 5)});
        }

        return testCases.ToArray();
    }
    
    [TestCaseSource(nameof(_testCases))]
    public void ConvertFromTimeToFiveMinuteRow(TimeOnly input, FiveMinuteRow expected)
    {
        var berlinClockTime = BerlinClockConverter.ConvertToBerlinClock(input);
        berlinClockTime.FiveMinuteRow.ShouldBe(expected);
    }
}