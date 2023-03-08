namespace BerlinClock;

public record BerlinClockTime(SingleMinuteRow SingleMinutesRow, FiveMinuteRow FiveMinuteRow);

public record SingleMinuteRow(Light One, Light Two, Light Three, Light Four)
{
    public override string ToString()
    {
        return $"{One}{Two}{Three}{Four}";
    }

    public static SingleMinuteRow ZeroMins => new(Light.O, Light.O, Light.O, Light.O);
    public static SingleMinuteRow OneMin => new(Light.Y, Light.O, Light.O, Light.O);
    public static SingleMinuteRow TwoMins => new(Light.Y, Light.Y, Light.O, Light.O);
    public static SingleMinuteRow ThreeMins => new(Light.Y, Light.Y, Light.Y, Light.O);
    public static SingleMinuteRow FourMins => new(Light.Y, Light.Y, Light.Y, Light.Y);
}

public record FiveMinuteRow(Light Light, Light Light1, Light Light2, Light Light3, Light Light4, Light Light5, Light Light6, Light Light7, Light Light8, Light Light9, Light Light10);