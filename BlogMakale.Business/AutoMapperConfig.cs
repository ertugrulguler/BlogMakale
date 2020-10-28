using AutoMapper;
using BlogMakale.Entities.EntityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogMakale.Business
{
    class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            AddCategoryMapping();
        }

        private void AddCategoryMapping()
        {
            #region Article
            CreateMap<Article, ArticleQuery>().ReverseMap();
            CreateMap<Article, ArticleCommand>().ReverseMap();
            #endregion

            #region Owner
            CreateMap<Owner, OwnerQuery>().ReverseMap();
            CreateMap<Owner, OwnerCommand>().ReverseMap();
            #endregion
            
            #region User
            CreateMap<User, UserQuery>().ReverseMap();
            CreateMap<User, UserCommand>().ReverseMap();
            #endregion

            #region Comment
            CreateMap<Comment, CommentQuery>().ReverseMap();
            CreateMap<Comment, CommentCommand>().ReverseMap();
            #endregion
        }
    }
}
