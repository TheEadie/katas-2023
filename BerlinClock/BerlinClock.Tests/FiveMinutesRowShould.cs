using Shouldly;

namespace BerlinClock.Tests;

public class FiveMinutesRowShould
{
    [Test]
    public void ShowALlLightsOffWhenMinutes0()
    {
        var input = new TimeOnly(0, 0, 0);
        var expected = new FiveMinuteRow(Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O);
        var berlinClockTime = BerlinClockConverter.ConvertToBerlinClock(input);
        berlinClockTime.FiveMinuteRow.ShouldBe(expected);
    }
}