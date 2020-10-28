using BlogMakale.Core.DataAccess.EntityFramework.Abstract;
using BlogMakale.Entities.EntityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogMakale.DataAccess.Abstract
{
    public interface IArticleDal:IEntityRepository<Article>
    {
    }
}
