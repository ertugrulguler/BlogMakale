using BlogMakale.Core.Entities;

namespace BlogMakale.Entities.EntityClasses
{
    public class Comment:EntityBase<int>, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
    }

    public class CommentQuery
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public UserQuery User { get; set; }
    }

    public class CommentCommand
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public UserCommand User { get; set; }
    }
}