
using CsvMapper.Logic.Attributes;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "InvoiceLine.csv", Seperator = ';', HasHeader = true)]
    public class InvoiceLine : ModelObject
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