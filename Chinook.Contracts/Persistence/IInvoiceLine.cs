using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface IInvoiceLine:IIdentifiable
    {
        public int InvoiceId { get; set; }
        public int TrackId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
