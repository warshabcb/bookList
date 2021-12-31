using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using booklist.Models;
using static bookList.Models.Enum;
using booklist.Data;
using Microsoft.EntityFrameworkCore;
namespace booklist.Controllers
{
    public class BooksController : BaseController
    {
        private readonly ApplicationDbContext _db;
        public BooksController(ApplicationDbContext db)
        {
            _db= db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Alert("El tutorial ha finalizado con éxito", NotificationType.success);
            return View();
        }

     #region
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Books.ToListAsync()});
        }
     #endregion
    }
}