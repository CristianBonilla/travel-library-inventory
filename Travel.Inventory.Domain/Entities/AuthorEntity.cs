using System;

namespace Travel.Inventory.Domain.Entities
{
    public class AuthorEntity
    {
        public Guid Id { get; set; }
        public string DNI { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
