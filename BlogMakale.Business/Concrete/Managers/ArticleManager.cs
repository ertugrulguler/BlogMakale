using BlogMakale.Business.Abstract;
using BlogMakale.DataAccess.Abstract;
using BlogMakale.Entities.EntityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogMakale.Business.Concrete.Managers
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        public Article Add(Article product)
        {
            return _articleDal.Add(product);
        }

        public bool Delete(int id)
        {
            var article = _articleDal.Get(i => i.Id == id);
            var result = _articleDal.Delete(article);
            if (result > 0)
                return true;
            return false;
        }

        public List<Article> GetAll()
        {
            return _articleDal.GetList();
        }

        public Article GetById(int id)
        {
            return _articleDal.Get(i => i.Id == id);
        }

        public Article Update(Article article)
        {
            return _articleDal.Update(article);
        }
    }
}
