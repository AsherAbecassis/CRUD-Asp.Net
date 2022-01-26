using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.ItemDto
{
    public class ShowItemDto
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}