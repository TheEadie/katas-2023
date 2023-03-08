namespace BerlinClock;

public record BerlinClockTime(SingleMinuteRow SingleMinutesRow, FiveMinuteRow FiveMinuteRow);

public record SingleMinuteRow(Light One, Light Two, Light Three, Light Four)
{
    public override string ToString()
    {
        return $"{One}{Two}{Three}{Four}";
    }
}

public record FiveMinuteRow(Light Light, Light Light1, Light Light2, Light Light3, Light Light4, Light Light5, Light Light6, Light Light7, Light Light8, Light Light9, Light Light10);