using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.ItemDto;
using API.Models;
using API.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{   [ApiController]
    [Route("api/item")]
    public class ItemController : ControllerBase
    {
        private readonly IItem _item;
        private readonly IMapper _mapp;

        public ItemController(IItem item, IMapper mapp)
        {
            _item = item;
            _mapp = mapp;
        }

        [HttpGet]
        public IActionResult GetItemsAsync()
        {
            var model =  _item.GetAllItems();
            var MapModel = _mapp.Map<IEnumerable<ShowItemDto>>(model);
            
            return Ok(MapModel);
        }
        [HttpPost]
        public async Task<ActionResult> PostNewItem([FromBody] CreateItemDto showItemDto)
        {
            var MapModel = _mapp.Map<Item>(showItemDto);

            await _item.Create(MapModel);
            return Ok();

        }
        [HttpPut("{id}")]
        public async Task<ActionResult> DeleteItem(int id)
        {
           
            await _item.DeleteById(id);
            return Ok();

        }



    }
}