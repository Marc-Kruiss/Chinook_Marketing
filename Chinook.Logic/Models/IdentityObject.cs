using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models
{
    internal abstract class IdentityObject:Contracts.IIdentifiable
    {
        [CsvMapper.Logic.Attributes.PropertyInfo(OrderPosition=0)]
        public int Id { get; set; }
    }
}
