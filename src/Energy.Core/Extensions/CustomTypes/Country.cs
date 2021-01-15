namespace Energy.Core.Extensions.CustomTypes
{
    public class Country
    {
        public string Name { get; }
        public string Fullname { get; }
        public string Code { get; }
        public string Currency { get; }
        public string Language { get; }

        public Country(string name, string fullname, string code, string currency, string language)
        {
            Name = name;
            Fullname = fullname;
            Code = code;
            Currency = currency;
            Language = language;
        }
    }
}
