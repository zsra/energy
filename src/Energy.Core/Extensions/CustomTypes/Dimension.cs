namespace Energy.Core.Extensions.CustomTypes
{
    public enum UnitType
    {
        Inch,
        Feet,
        Meter,
        Centimeter,
    }

    public struct Dimension
    {
        public decimal? X { get; }
        public decimal? Z { get; }
        public decimal? Y { get; }

        public UnitType UnitType { get; }

        public Dimension(decimal? x, decimal? z, decimal? y, UnitType unitType)
        {
            X = x;
            Z = z;
            Y = y;
            UnitType = unitType;
        }

        public override string ToString()
        {
            string unit = GetPrettyUnit();

            return UnitType == UnitType.Centimeter || UnitType == UnitType.Meter
                ? $"{X} {unit} x {Z} {unit} x {Y} {unit}" : $"{X} x {Z} x {Y} {unit}";
        }

        private readonly string GetPrettyUnit() => UnitType switch
        {
            UnitType.Inch => "inches",
            UnitType.Feet => "feets",
            UnitType.Meter => "m",
            UnitType.Centimeter => "cm",
            _ => "undefenied",
        };
    }
}
