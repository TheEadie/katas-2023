namespace BerlinClock;

public class BerlinClockConverter
{
    public BerlinClockTime ConvertToBerlinClock(TimeOnly time)
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
            0  => new SingleMinuteRow(Light.O, Light.O, Light.O, Light.O),
            1 => new SingleMinuteRow(Light.Y, Light.O, Light.O, Light.O),
            2 => new SingleMinuteRow(Light.Y, Light.Y, Light.O, Light.O),
            3 => new SingleMinuteRow(Light.Y, Light.Y, Light.Y, Light.O),
            _ => new SingleMinuteRow(Light.Y, Light.Y, Light.Y, Light.Y)
        };

        return new BerlinClockTime(singleMins, fiveMins);
    }
}