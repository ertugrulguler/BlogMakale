using BlogMakale.Entities.EntityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogMakale.Business.Abstract
{
    public interface IArticleService
    {
        List<Article> GetAll();
        Article GetById(int id);
        Article Add(Article product);
        Article Update(Article product);
        bool Delete(int id);
    }
}
