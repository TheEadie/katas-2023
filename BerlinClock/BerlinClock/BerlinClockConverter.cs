namespace BerlinClock;

public static class BerlinClockConverter
{
    public static BerlinClockTime ConvertToBerlinClock(TimeOnly time)
    {
        var fiveMins = (time.Minute / 5) switch
        {
            0 => FiveMinuteRow.ZeroMins,
            1 => FiveMinuteRow.FiveMins,
            2 => FiveMinuteRow.TenMins,
            3 => FiveMinuteRow.FifteenMins,
            4 => FiveMinuteRow.TwentyMins,
            5 => FiveMinuteRow.TwentyFiveMins,
            6 => FiveMinuteRow.ThirtyMins,
            7 => FiveMinuteRow.ThirtyFiveMins,
            8 => FiveMinuteRow.FortyMins,
            9 => FiveMinuteRow.FortyFiveMins,
            10 => FiveMinuteRow.FiftyMins,
            11 => FiveMinuteRow.FiftyFiveMins,
            _ => throw new ArgumentOutOfRangeException()
        };
        
        var singleMins = (time.Minute % 5) switch
        {
            0  => SingleMinuteRow.ZeroMins,
            1 => SingleMinuteRow.OneMin,
            2 => SingleMinuteRow.TwoMins,
            3 => SingleMinuteRow.ThreeMins,
            4 => SingleMinuteRow.FourMins,
            _ => throw new ArgumentOutOfRangeException()
        };

        return new BerlinClockTime(singleMins, fiveMins);
    }
}