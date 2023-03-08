using Shouldly;

namespace BerlinClock.Tests;

public class SingleMinutesRowShould
{
    private static object[] _testCases()
    {
        var testCases = new List<object>();
        int min;
        int lights;
        for (min = 0, lights = 0; min < 60; min++, lights = (lights + 1) % 5)
        {
            testCases.Add(new object[] {GenerateTimeOnly(min), GenerateMinuteRow(lights)});
        }

        return testCases.ToArray();
    }

    private static TimeOnly GenerateTimeOnly(int min) => new(12, min, 0);

    private static SingleMinuteRow GenerateMinuteRow(int lights) =>
        lights switch
        {
            4 => new SingleMinuteRow(Light.Y, Light.Y, Light.Y, Light.Y),
            3 => new SingleMinuteRow(Light.Y, Light.Y, Light.Y, Light.O),
            2 => new SingleMinuteRow(Light.Y, Light.Y, Light.O, Light.O),
            1 => new SingleMinuteRow(Light.Y, Light.O, Light.O, Light.O),
            _ => new SingleMinuteRow(Light.O, Light.O, Light.O, Light.O)
        };

    [TestCaseSource(nameof(_testCases))]
    public void ConvertFromTimeToSingleMinuteRow(TimeOnly input, SingleMinuteRow expected)
    {
        var converter = new BerlinClockConverter();
        var berlinClockTime = converter.ConvertToBerlinClock(input);
        berlinClockTime.SingleMinutesRow.ShouldBe(expected);
    }
}