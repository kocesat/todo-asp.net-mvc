using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TodoAspNetMvc.Models;

namespace TodoAspNetMvc.Controllers
{
    public class TodoItemsController : Controller
    {
        private ApplicationDbContext _context;

        public TodoItemsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: TodoItems
        [HttpGet]
        public ActionResult Index()
        {
            var todoItems = _context.TodoItems.ToList();

            return View(todoItems);
        }

        public ActionResult New()
        {
            var item = new TodoItem();
            ViewBag.Title = "Add New Item";
            return View("TodoItemForm");
        }

        [HttpPost]
        public ActionResult Save(TodoItem item)
        {
            if (!ModelState.IsValid)
            {
                return View("TodoItemForm", item);
            }

            // check if it already included in the database
            if (item.Id == 0)
            {
                item.CreationDate = DateTime.Now;
                _context.TodoItems.Add(item);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "TodoItems");
        }

    }
}