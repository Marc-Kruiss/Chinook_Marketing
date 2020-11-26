
using CsvMapper.Logic.Attributes;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "Customer.csv", Seperator = ';', HasHeader = true)]
    public class Customer : ModelObject
    {
        //CustomerId;FirstName;LastName;Company;Address;City;State;Country;PostalCode;Phone;Fax;Email;SupportRepId

        [PropertyInfo(OrderPosition = 1)]
        public string FirstName { get; set; }
        [PropertyInfo(OrderPosition = 2)]
        public string LastName { get; set; }
        [PropertyInfo(OrderPosition = 3)]
        public string Company { get; set; }
        [PropertyInfo(OrderPosition = 4)]
        public string Address { get; set; }
        [PropertyInfo(OrderPosition = 5)]
        public string City { get; set; }
        [PropertyInfo(OrderPosition = 6)]
        public string State { get; set; }
        [PropertyInfo(OrderPosition = 7)]
        public string Country { get; set; }
        [PropertyInfo(OrderPosition = 8)]
        public string Postalcode { get; set; }
        [PropertyInfo(OrderPosition = 9)]
        public string Phone { get; set; }
        [PropertyInfo(OrderPosition = 10)]
        public string Fax { get; set; }
        [PropertyInfo(OrderPosition = 11)]
        public string Email { get; set; }
        [PropertyInfo(OrderPosition = 12)]
        public int SupportRepId { get; set; }
    }
}