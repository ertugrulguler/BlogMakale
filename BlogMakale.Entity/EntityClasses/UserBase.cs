using BlogMakale.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogMakale.Entities.EntityClasses
{
    public class UserBase:EntityBase<Guid>,IEntity
    {
        public UserBase()
        {
            CreatedDate = DateTime.Now;
            if (UpdatedDate == null) UpdatedDate = DateTime.Now;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
