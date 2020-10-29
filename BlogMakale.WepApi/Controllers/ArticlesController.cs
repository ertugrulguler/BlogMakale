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
        private IMapper _mapper;
        public ArticlesController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        [HttpGet("GetArticles")]
        public IActionResult GetArticles()
        {
            try
            {
                var articles = _articleService.GetAll();
                if (articles.Count == 0)
                    return Ok(new { Statu = false, Message = "Makale bulunamadı." });

                var response = _mapper.Map<List<ArticleQuery>>(articles);

                return Ok(new { Status = true, response });
            }
            catch (Exception ex)
            {
                return BadRequest("Bir hata oluştu.");
            }

        }

        [HttpGet("GetArticle/{id}")]
        public IActionResult GetArticle(int id)
        {
            try
            {
                var article = _articleService.GetById(id);
                if (article == null)
                    return Ok(new { Statu = false, Message = "Makale bulunamadı." });

                var response = _mapper.Map<ArticleQuery>(article);

                return Ok(new { Status = true, response });
            }
            catch (Exception ex)
            {
                return BadRequest("Bir hata oluştu.");
            }
           
        }

        [HttpPost("AddArticle")]
        public IActionResult AddArticle(ArticleCommand articleCommand)
        {
            try
            {
                if (articleCommand == null)
                    return BadRequest(new { Statu = false, Message = "İstenilen kriterlere uygun bir model gönderilmedi." });

                var article = _mapper.Map<Article>(articleCommand);
                var response = _articleService.Add(article);
                if (response == null)
                    return BadRequest(new { Statu = false, Message = "Makale oluşturulamadı." });

                var articleQuery = _mapper.Map<ArticleQuery>(response);
                return Ok(new { Status = true, articleQuery });
            }
            catch (Exception ex)
            {
                return BadRequest("Bir hata oluştu.");
            }
        }

        [HttpPost("UpdateArticle")]
        public IActionResult UpdateArticle(ArticleCommand articleCommand)
        {
            try
            {
                if (articleCommand == null)
                    return BadRequest(new { Statu = false, Message = "İstenilen kriterlere uygun bir model gönderilmedi." });

                var article = _mapper.Map<Article>(articleCommand);
                var response = _articleService.Update(article);
                if (response == null)
                    return BadRequest(new { Statu = false, Message = "Makale güncellenemedi." });

                var articleQuery = _mapper.Map<ArticleQuery>(response);
                return Ok(new { Status = true, articleQuery });
            }
            catch (Exception ex)
            {
                return BadRequest("Bir hata oluştu.");
            }
        }

        [HttpGet("DeleteArticle/{id}")]
        public IActionResult DeleteArticle(int id)
        {
            try
            {
                if (id == null)
                    return BadRequest(new { Statu = false, Message = "Id alanı boş olamaz." });

             
                var response = _articleService.Delete(id);
                if (!response)
                    return BadRequest(new { Statu = false, Message = "Makale silinemedi." });

                return Ok(new { Status = true, Message="İşlem başarıyla gerçekleşti." });
            }
            catch (Exception ex)
            {
                return BadRequest("Bir hata oluştu.");
            }
        }
    }
}
