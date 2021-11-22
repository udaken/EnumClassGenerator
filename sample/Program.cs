using System;

internal partial class Program
{
    static void Main(string[] args)
    {
        Day.TryParse("FRIDAY", out var day);
        switch (day)
        {
            case Day.MONDAY:
                Console.WriteLine("Mondays are bad.");
                break;
            case Day.FRIDAY:
                Console.WriteLine("Fridays are better.");
                break;
            case Day.SATURDAY:
            case Day.SUNDAY:
                Console.WriteLine("Weekends are best.");
                break;
            default:
                Console.WriteLine("Midweek days are so-so.");
                break;
        }
        day = Day.MONDAY.Instance;
    }
}


[EnumClassGenerator.GenerateEnumClass("SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY")]
internal partial class Day
{
    public virtual bool IsHoliday => false;
    partial class SUNDAY
    {
        public override bool IsHoliday => true;
    }
}
