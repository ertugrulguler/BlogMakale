using BlogMakale.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogMakale.Entities.EntityClasses
{
    public class Article :EntityBase<int>, IEntity
    {
        public Article()
        {
            CreatedDate = DateTime.Now;
            if (UpdatedDate == null) UpdatedDate = DateTime.Now;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Owner Owner { get; set; }
        public List<Comment> Comments { get; set; }
        public string Tags { get; set; }
    }


    public class ArticleQuery
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public OwnerQuery Owner { get; set; }
        public string Tags { get; set; }
    }

    public class ArticleCommand
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public OwnerCommand Owner { get; set; }
        public string Tags { get; set; }
    }
}
