using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Reef.DataAccess;
using Reef.Models.Domain;
using Reef.Models.Filters;

namespace Reef.Logic
{
    public class ItemLogic: IItemLogic
    {
        private IItemRepository _repository;

        public ItemLogic(IItemRepository repository)
        {
            this._repository = repository;
        }

        public async Task<Item> Create(Item item)
        {
            return await this._repository.Create(item);
        }

        public async Task<Item> Delete(Item item)
        {
            return await this._repository.Delete(item);
        }

        public async Task<IEnumerable<Item>> Get(ItemFilter filter)
        {
            return await this._repository.Get(filter);
        }

        public async Task<Item> Get(Guid id)
        {
            return await this._repository.Get(id);
        }

        public async Task<Item> Update(Item item)
        {
            return await this.Update(item);
        }
    }
}
