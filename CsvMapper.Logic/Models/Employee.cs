using CsvMapper.Logic.Attributes;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "Employee.csv", Seperator = ';', HasHeader = true)]
    public class Employee : ModelObject
    {

        // EmployeeId;LastName;FirstName;Title;ReportsTo;BirthDate;HireDate;Address;City;State;Country;PostalCode;Phone;Fax;Email

        [PropertyInfo(OrderPosition = 1)]
        public string LastName { get; set; }
        [PropertyInfo(OrderPosition = 2)]
        public string FirstName { get; set; }
        [PropertyInfo(OrderPosition = 3)]
        public string Title { get; set; }
        [PropertyInfo(OrderPosition = 4)]
        public string ReportsTo { get; set; }
        [PropertyInfo(OrderPosition = 5)]
        public string BirthDate { get; set; }
        [PropertyInfo(OrderPosition = 6)]
        public string HireDate { get; set; }
        [PropertyInfo(OrderPosition = 7)]
        public string Address { get; set; }
        [PropertyInfo(OrderPosition = 8)]
        public string City { get; set; }
        [PropertyInfo(OrderPosition = 9)]
        public string State { get; set; }
        [PropertyInfo(OrderPosition = 10)]
        public string PostalCode { get; set; }
        [PropertyInfo(OrderPosition = 11)]
        public string Phone { get; set; }
        [PropertyInfo(OrderPosition = 12)]
        public string Fax { get; set; }
        [PropertyInfo(OrderPosition = 13)]
        public string Email { get; set; }
    }
}