using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using booklist.Models;
using static bookList.Models.Enum;

namespace booklist.Controllers
{
    public class BooksController : BaseController
    {

        [HttpGet]
        public IActionResult Index()
        {
            // Alert("El tutorial ha finalizado con éxito", NotificationType.success);
            return View();
        }

        public void GetAll()
        {

        }
    }
}