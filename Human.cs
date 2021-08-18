namespace Hospital
{
    public enum Month
    {
        January = 1,
        February, March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    public class Human
    {
        public string Name { get; set; }
        public uint YearBirth { get; set; }
        public Month MonthBrth { get; set; }

        public uint DayBirth { get; set; }
    }
}
