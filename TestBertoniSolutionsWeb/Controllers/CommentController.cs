using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestBertoniSolutionsWeb.Models;
using TestBertoniSolutionsWeb.Utils;

namespace TestBertoniSolutionsWeb.Controllers
{
    public class CommentController : BaseController
    {
        public JsonResult GetCommentByPhoto(int photoId=0)
        {
            var result = Ejecutar(() =>
            {
                var comments = _cliente.Invocar<List<Comment>>("comments", MetodoHttp.Get);
                return comments.Where(p => p.PostId == photoId).ToList();
            });
            return Json(result);
        }
    }
}