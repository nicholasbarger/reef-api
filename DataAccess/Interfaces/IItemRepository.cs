using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Reef.Models.Domain;
using Reef.Models.Filters;

namespace Reef.DataAccess
{
    public interface IItemRepository
    {
        Task<Item> Create(Item item);
        Task<Item> Delete(Item item);
        Task<IEnumerable<Item>> Get(ItemFilter filter);
        Task<Item> Get(Guid id);
        Task<Item> Update(Item item);
    }
}
