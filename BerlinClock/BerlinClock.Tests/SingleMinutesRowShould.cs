using Shouldly;

namespace BerlinClock.Tests;

public class SingleMinutesRowShould
{
    private static object[] _testCases()
    {
        TimeOnly GenerateTimeOnly(int min) => new(12, min, 0);

        SingleMinuteRow GenerateMinuteRow(int lights) => lights switch
        {
            4 => SingleMinuteRow.FourMins,
            3 => SingleMinuteRow.ThreeMins,
            2 => SingleMinuteRow.TwoMins,
            1 => SingleMinuteRow.OneMin,
            _ => SingleMinuteRow.ZeroMins
        };

        var testCases = new List<object>();
        int min;
        int lights;
        for (min = 0, lights = 0; min < 60; min++, lights = (lights + 1) % 5)
        {
            testCases.Add(new object[] {GenerateTimeOnly(min), GenerateMinuteRow(lights)});
        }

        return testCases.ToArray();
    }

    [TestCaseSource(nameof(_testCases))]
    public void ConvertFromTimeToSingleMinuteRow(TimeOnly input, SingleMinuteRow expected)
    {
        var berlinClockTime = BerlinClockConverter.ConvertToBerlinClock(input);
        berlinClockTime.SingleMinutesRow.ShouldBe(expected);
    }
}