using System;
namespace Reef.Models.Domain
{
    public class Item: Model
    {
        public string Description { get; set; }
        public new string Id { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }

        public Item(): base()
        {
        }
    }
}
