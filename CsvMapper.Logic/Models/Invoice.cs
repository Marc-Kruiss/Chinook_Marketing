
using CsvMapper.Logic.Attributes;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "Invoice.csv", Seperator = ';', HasHeader = true)]
    public class Invoice : ModelObject
    {
        // InvoiceId;CustomerId;InvoiceDate;BillingAddress;BillingCity;BillingState;BillingCountry;BillingPostalCode;Total
        [PropertyInfo(OrderPosition = 1)]
        public int Customerid { get; set; }
        [PropertyInfo(OrderPosition = 2)]
        public string InvoiceDate { get; set; }
        [PropertyInfo(OrderPosition = 3)]
        public string BillingAddress { get; set; }
        [PropertyInfo(OrderPosition = 4)]
        public string BillingCity { get; set; }
        [PropertyInfo(OrderPosition = 5)]
        public string BillingState { get; set; }
        [PropertyInfo(OrderPosition = 6)]
        public string BillingCountry { get; set; }
        [PropertyInfo(OrderPosition = 7)]
        public string BillingPostalCode { get; set; }
        [PropertyInfo(OrderPosition = 8)]
        public double Total { get; set; }
    }
}