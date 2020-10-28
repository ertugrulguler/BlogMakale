using BlogMakale.Core.Entities;

namespace BlogMakale.Entities.EntityClasses
{
    public class Comment:EntityBase<int>, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
    }
}