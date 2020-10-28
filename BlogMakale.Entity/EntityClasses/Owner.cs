using System;

namespace BlogMakale.Entities.EntityClasses
{
    public class Owner:UserBase
    {
    }

    public class OwnerQuery
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class OwnerCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
    }

}