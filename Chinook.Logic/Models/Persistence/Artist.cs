using Chinook.Contracts.Persistence;
using CsvMapper.Logic.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models.Persistence
{
    [EntityInfo(FileName ="Artist.csv",Seperator =';',HasHeader =true)]
    internal class Artist:IdentityObject, IArtist
    {
        [PropertyInfo(OrderPosition =1)]
        public string Name { get; set; }

    }
}
