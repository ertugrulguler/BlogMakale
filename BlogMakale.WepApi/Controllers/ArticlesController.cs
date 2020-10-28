using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlogMakale.Business.Abstract;
using BlogMakale.Entities.EntityClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogMakale.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IArticleService _articleService;
        //private IMapper _mapper;
        public ArticlesController(IArticleService articleService/*,IMapper mapper*/)
        {
            _articleService = articleService;
            //_mapper = mapper;
        }

        [HttpGet("GetArticles")]
        public IActionResult GetArticles()
        {
            var articles = _articleService.GetAll();
            if (articles.Count == 0)
                return Ok(new { Statu = false, Message = "Makale bulunamadı." });

            //var response = _mapper.Map<List<ArticleQuery>>(articles);

            return Ok(new { Status = true, articles });
        }
    }
}
