
using Chinook.Contracts.Persistence;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Models.Persistence
{
    [EntityInfo(FileName = "InvoiceLine.csv", Seperator = ';', HasHeader = true)]
    internal class InvoiceLine : IdentityObject, IInvoiceLine
    {
        //InvoiceLineId;InvoiceId;TrackId;UnitPrice;Quantity
        [PropertyInfo(OrderPosition = 1)]
        public int InvoiceId { get; set; }
        [PropertyInfo(OrderPosition = 2)]
        public int TrackId { get; set; }
        [PropertyInfo(OrderPosition = 3)]
        public double UnitPrice { get; set; }
        [PropertyInfo(OrderPosition = 4)]
        public int Quantity { get; set; }

    }
}