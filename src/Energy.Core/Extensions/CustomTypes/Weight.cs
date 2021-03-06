﻿namespace Energy.Core.Extensions.CustomTypes
{
    public enum WeightType
    {
        Pounds,
        Ounches,
        Gramm,
        Kilogramm,
    }

    public struct Weight
    {
        public decimal? Value { get; set; }
        public WeightType WeightType { get; set; }

        public Weight(decimal? value, WeightType weightType)
        {
            Value = value;
            WeightType = weightType;
        }

        public override string ToString()
            => Value == null ? "undefenied" : $"{Value} {WeightType}";
    }
}
