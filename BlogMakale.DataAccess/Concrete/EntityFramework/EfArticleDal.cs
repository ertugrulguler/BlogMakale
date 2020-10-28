using BlogMakale.Core.DataAccess.EntityFramework.Concrete;
using BlogMakale.DataAccess.Abstract;
using BlogMakale.DataAccess.Context;
using BlogMakale.Entities.EntityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogMakale.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal:EfEntityRepositoryBase<Article,MakaleContext>,IArticleDal
    {
    }
}
