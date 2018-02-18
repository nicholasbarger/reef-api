using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Reef.Models.Domain;
using Reef.Models.Filters;

namespace Reef.DataAccess
{
    public class ItemRepository: IItemRepository
    {
        public ItemRepository()
        {
        }

        public Task<IEnumerable<Item>> Get(ItemFilter filter)
        {
            throw new NotImplementedException();
        }

        public Task<Item> Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
