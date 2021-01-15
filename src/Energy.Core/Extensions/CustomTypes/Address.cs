namespace Energy.Core.Extensions.CustomTypes
{
    public class Address
    {
        public string Postcode { get; }
        public Country Country { get; }
        public string City { get; set; }
        public string StreetAndHouseNumber { get; }
        public string AdditionalInfo { get; }

        public Address(string postcode, Country country, string city, string streetAndHouseNumber, string additionalInfo)
        {
            Postcode = postcode;
            Country = country;
            City = city;
            StreetAndHouseNumber = streetAndHouseNumber;
            AdditionalInfo = additionalInfo;
        }
    }
}
