using System;

namespace BlogMakale.Entities.EntityClasses
{
    public class User:UserBase
    {
        public string Age { get; set; }
        public bool Gentle { get; set; }
        public string Email { get; set; }
    }

    public class UserQuery
    {
        public string Age { get; set; }
        public bool Gentle { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class UserCommand
    {
        public Guid Id { get; set; }
        public string Age { get; set; }
        public bool Gentle { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
    }
}