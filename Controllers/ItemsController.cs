using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reef.Logic;
using Reef.Models.Domain;
using Reef.Models.Filters;

namespace Reef.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        private IItemLogic _logic;

        public ItemsController(IItemLogic logic)
        {
            this._logic = logic;
        }

        // GET: api/items
        [HttpGet]
        public async Task<IEnumerable<Item>> Get(ItemFilter filter)
        {
            return await _logic.Get(filter);
        }

        // GET api/items/d1745a45-ba52-40bd-b7d8-f139197008ca
        [HttpGet("{id}")]
        public async Task<Item> Get(Guid id)
        {
            return await _logic.Get(id);
        }

        // POST api/items
        [HttpPost]
        public async Task<Item> Post([FromBody]Item item)
        {
            return await _logic.Create(item);
        }

        // PUT api/items/d1745a45-ba52-40bd-b7d8-f139197008ca
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody]Item item)
        {
            return await _logic.Update(item);
        }

        // DELETE api/items/d1745a45-ba52-40bd-b7d8-f139197008ca
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            return await _logic.Delete(id);
        }
    }
}
