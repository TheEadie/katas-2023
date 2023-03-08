namespace BerlinClock;

public record BerlinClockTime(SingleMinuteRow SingleMinutesRow, FiveMinuteRow FiveMinuteRow);

public record SingleMinuteRow(Light One, Light Two, Light Three, Light Four)
{
    public override string ToString()
    {
        return $"{One}{Two}{Three}{Four}";
    }

    public static SingleMinuteRow ZeroMins => 
        new(Light.O, Light.O, Light.O, Light.O);
    public static SingleMinuteRow OneMin => 
        new(Light.Y, Light.O, Light.O, Light.O);
    public static SingleMinuteRow TwoMins => 
        new(Light.Y, Light.Y, Light.O, Light.O);
    public static SingleMinuteRow ThreeMins =>
        new(Light.Y, Light.Y, Light.Y, Light.O);
    public static SingleMinuteRow FourMins => 
        new(Light.Y, Light.Y, Light.Y, Light.Y);
}

public record FiveMinuteRow(Light Five, Light Ten, Light Fifteen,
    Light Twenty, Light TwentyFive, Light Thirty,
    Light ThirtyFive, Light Forty, Light FortyFive,
    Light Fifty, Light FiftyFive)
{
    public override string ToString()
    {
        return $"{Five}{Ten}{Fifteen}{Twenty}{TwentyFive}{Thirty}{ThirtyFive}{Forty}{FortyFive}{Fifty}{FiftyFive}";
    }
    
    public static FiveMinuteRow ZeroMins => new(
        Light.O, Light.O, Light.O,
        Light.O, Light.O, Light.O,
        Light.O, Light.O, Light.O, 
        Light.O, Light.O);
    public static FiveMinuteRow FiveMins => new(
        Light.Y, Light.O, Light.O,
        Light.O, Light.O, Light.O,
        Light.O, Light.O, Light.O, 
        Light.O, Light.O);
    public static FiveMinuteRow TenMins => new(
        Light.Y, Light.Y, Light.O,
        Light.O, Light.O, Light.O,
        Light.O, Light.O, Light.O, 
        Light.O, Light.O);
    public static FiveMinuteRow FifteenMins => new(
        Light.Y, Light.Y, Light.R,
        Light.O, Light.O, Light.O,
        Light.O, Light.O, Light.O,
        Light.O, Light.O);
    
    public static FiveMinuteRow TwentyMins => new(
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.O, Light.O,
        Light.O, Light.O, Light.O,
        Light.O, Light.O);
    
    public static FiveMinuteRow TwentyFiveMins => new(
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.O,
        Light.O, Light.O, Light.O,
        Light.O, Light.O);
    
    public static FiveMinuteRow ThirtyMins => new(
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.R,
        Light.O, Light.O, Light.O,
        Light.O, Light.O);
    
    public static FiveMinuteRow ThirtyFiveMins => new(
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.O, Light.O,
        Light.O, Light.O);
    
    public static FiveMinuteRow FortyMins => new(
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.O,
        Light.O, Light.O);
    
    public static FiveMinuteRow FortyFiveMins => new(
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.R,
        Light.O, Light.O);
    
    public static FiveMinuteRow FiftyMins => new(
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.O);
    
    public static FiveMinuteRow FiftyFiveMins => new(
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y, Light.R,
        Light.Y, Light.Y);
}