using Shouldly;

namespace BerlinClock.Tests;

public class FiveMinutesRowShould
{
    [Test]
    public void ShowALlLightsOffWhenMinutes0()
    {
        var converter = new BerlinClockConverter();
        var input = new TimeOnly(0, 0, 0);
        var expected = new FiveMinuteRow(Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O);
        var berlinClockTime = converter.ConvertToBerlinClock(input);
        berlinClockTime.FiveMinuteRow.ShouldBe(expected);
    }
}