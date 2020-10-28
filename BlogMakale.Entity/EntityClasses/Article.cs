﻿using BlogMakale.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogMakale.Entities.EntityClasses
{
    public class Article : IEntity
    {
        public Article()
        {
            CreatedDate = DateTime.Now;
            if (UpdatedDate == null) UpdatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Owner Owner { get; set; }
        public List<Comment> Comments { get; set; }
        public string Tags { get; set; }
    }
}