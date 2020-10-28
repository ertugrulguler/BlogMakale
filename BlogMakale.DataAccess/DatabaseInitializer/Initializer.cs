using BlogMakale.DataAccess.Context;
using BlogMakale.Entities.EntityClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogMakale.DataAccess.DatabaseInitializer
{
    public static class Initializer
    {
        public static void Seed()
        {

            var context = new MakaleContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Articles.Count() == 0)
                {
                    var articleList = new List<Article>();
                    for (int i = 0; i < 10; i++)
                    {
                        var article = new Article()
                        {
                            Title = FakeData.PlaceData.GetCounty(),
                            Content = FakeData.TextData.GetSentences(3),
                            Tags = FakeData.NameData.GetCompanyName(),
                            Comments = GetComments(context),
                            Owner = GetOwner(context)
                        };
                        articleList.Add(article);
                    }
                        context.SaveChanges();
                }
            }
        }


        public static List<Comment> GetComments(MakaleContext context)
        {
            var list = new List<Comment>();
            for (var i = 0; i < 3; i++)
            {
                var comment = new Comment()
                {
                    Title = FakeData.PlaceData.GetCity(),
                    Content = FakeData.TextData.GetSentences(3),
                    User = new User()
                    {
                        Age = "20",
                        Email = FakeData.NetworkData.GetEmail(),
                        Gentle = false,
                        Name = FakeData.NameData.GetFemaleFirstName(),
                        Surname = FakeData.NameData.GetSurname(),
                        Username = FakeData.NameData.GetFirstName() + "." + FakeData.NameData.GetSurname()
                    }
                };
                list.Add(comment);
                if (context.Comments.Count() == 0)
                    context.AddRange(list);
            }
            return list;
        }
        public static Owner GetOwner(MakaleContext context)
        {
            var owner = new Owner()
            {
                Name = FakeData.NameData.GetFullName(),
                Surname = FakeData.NameData.GetSurname(),
                Username = FakeData.NameData.GetFirstName() + "." + FakeData.NameData.GetSurname()
            };
            if (context.Owners.Count() == 0)
                context.Owners.Add(owner);

            return owner;
        }

    }
}
