namespace BerlinClock;

public static class BerlinClockConverter
{
    public static BerlinClockTime ConvertToBerlinClock(TimeOnly time)
    {
        var fiveMins = (time.Minute / 5) switch
        {
            0 => new FiveMinuteRow(Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O, Light.O,
                Light.O, Light.O, Light.O),
            _ => new FiveMinuteRow(Light.Y, Light.Y, Light.Y, Light.Y, Light.Y, Light.Y, Light.Y, Light.Y,
                Light.Y, Light.Y, Light.Y)
        };
        
        var singleMins = (time.Minute % 5) switch
        {
            0  => SingleMinuteRow.ZeroMins,
            1 => SingleMinuteRow.OneMin,
            2 => SingleMinuteRow.TwoMins,
            3 => SingleMinuteRow.ThreeMins,
            _ => SingleMinuteRow.FourMins
        };

        return new BerlinClockTime(singleMins, fiveMins);
    }
}