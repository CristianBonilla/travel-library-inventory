using System;
using System.Collections.Generic;

namespace Travel.Inventory.Domain.Entities
{
    public class EditorialEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sede { get; set; }
        public ICollection<BookEntity> Books { get; set; } = new HashSet<BookEntity>();
    }
}
