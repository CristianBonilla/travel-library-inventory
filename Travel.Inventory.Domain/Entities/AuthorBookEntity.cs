using System;

namespace Travel.Inventory.Domain.Entities
{
    public class AuthorBookEntity
    {
        public Guid AuthorId { get; set; }
        public Guid BookId { get; set; }
        public AuthorEntity Author { get; set; }
        public BookEntity Book { get; set; }
    }
}
