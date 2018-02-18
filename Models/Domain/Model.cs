using System;
namespace Reef.Models.Domain
{
    public class Model
    {
        public DateTime Created { get; set; }
        public int Id { get; set; }
        public Guid ObfuscatedId { get; set; }
        public DateTime? Updated { get; set; }

        public Model()
        {
            this.ObfuscatedId = Guid.NewGuid();
            this.Created = DateTime.UtcNow;
        }
    }
}
