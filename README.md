# EnumClassGenerator

## Usage
```csharp
[EnumClassGenerator.GenerateEnumClass("SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY")]
internal partial class Day
{
    public virtual bool IsHoliday => false;
    partial class SUNDAY
    {
        public override bool IsHoliday => true;
    }
}
```

Generated code:
```csharp
#nullable enable

using System;
using System.Linq;
using System.Collections.Generic;
[Serializable]
abstract partial class Day : IEquatable<Day>, IComparable<Day>
{
    public abstract int Ordinal { get; }
    public string Name => _Names[Ordinal];
    private Day() { }
    public abstract bool Equals(Day? obj);
    public override sealed bool Equals(object? obj) => obj is Day other && Equals(other);
    public override sealed int GetHashCode() => 696030412 ^ Ordinal.GetHashCode();
    public override string ToString() => $"{nameof(Day)}.{Name}";
    public int CompareTo(Day? other) => other?.Ordinal.CompareTo(Ordinal) ?? -1;
    public static bool operator ==(Day? left, Day? right) =>
      Object.ReferenceEquals(left, right) || (!Object.ReferenceEquals(left, null) && left.Equals(right));
    public static bool operator !=(Day? left, Day? right) => !(left == right);
    public static bool TryParse(ReadOnlySpan<char> name, out Day? value) { for (var i = 0; i < _Names.Length; i++) { if (name.SequenceEqual(_Names[i])) { value = _Values[i]; return true; } } value = null; return false; }
    private static readonly Day[] _Values = { SUNDAY.Instance, MONDAY.Instance, TUESDAY.Instance, WEDNESDAY.Instance, THURSDAY.Instance, FRIDAY.Instance, SATURDAY.Instance };
    public static ReadOnlySpan<Day> ValueSpan => _Values;
    public static IEnumerable<Day> Values => new System.Collections.ObjectModel.ReadOnlyCollection<Day>(_Values);
    private static readonly string[] _Names = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
    public static ReadOnlySpan<string> NamesSpan => _Names;
    public static IEnumerable<string> Names => new System.Collections.ObjectModel.ReadOnlyCollection<string>(_Names);
    public sealed partial class SUNDAY : Day
    {
        public static Day Instance { get; } = new SUNDAY();
        private SUNDAY() : base() { }
        public override int Ordinal => 0;

        public override bool Equals(Day? obj) => obj is SUNDAY;
    }
    public sealed partial class MONDAY : Day
    {
        public static Day Instance { get; } = new MONDAY();
        private MONDAY() : base() { }
        public override int Ordinal => 1;

        public override bool Equals(Day? obj) => obj is MONDAY;
    }
    public sealed partial class TUESDAY : Day
    {
        public static Day Instance { get; } = new TUESDAY();
        private TUESDAY() : base() { }
        public override int Ordinal => 2;

        public override bool Equals(Day? obj) => obj is TUESDAY;
    }
    public sealed partial class WEDNESDAY : Day
    {
        public static Day Instance { get; } = new WEDNESDAY();
        private WEDNESDAY() : base() { }
        public override int Ordinal => 3;

        public override bool Equals(Day? obj) => obj is WEDNESDAY;
    }
    public sealed partial class THURSDAY : Day
    {
        public static Day Instance { get; } = new THURSDAY();
        private THURSDAY() : base() { }
        public override int Ordinal => 4;

        public override bool Equals(Day? obj) => obj is THURSDAY;
    }
    public sealed partial class FRIDAY : Day
    {
        public static Day Instance { get; } = new FRIDAY();
        private FRIDAY() : base() { }
        public override int Ordinal => 5;

        public override bool Equals(Day? obj) => obj is FRIDAY;
    }
    public sealed partial class SATURDAY : Day
    {
        public static Day Instance { get; } = new SATURDAY();
        private SATURDAY() : base() { }
        public override int Ordinal => 6;

        public override bool Equals(Day? obj) => obj is SATURDAY;
    }
}

```
