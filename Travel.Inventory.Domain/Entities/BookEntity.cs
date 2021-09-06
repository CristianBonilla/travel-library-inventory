using System;

namespace Travel.Inventory.Domain.Entities
{
    public class BookEntity
    {
        public Guid Id { get; set; }
        public Guid EditorialId { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public int TotalPages { get; set; }
        public EditorialEntity Editorial { get; set; }
    }
}
