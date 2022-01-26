using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.ItemDto
{
    public class ListsItemsDto
    {
    
        public IEnumerator<ShowItemDto> listItems { get; set; }
    }
}