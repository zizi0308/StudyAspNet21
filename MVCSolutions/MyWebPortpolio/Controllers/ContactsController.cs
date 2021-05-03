using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebPortpolio.Data;
using MyWebPortpolio.Models;

namespace MyWebPortpolio.Controllers
{
    public class ContactsController : Controller
    {
        private readonly MyWebPortpolioContext _context;

        public ContactsController(MyWebPortpolioContext context)
        {
            _context = context;
        }

        // GET: Contacts
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("Id,Name,Email,Contents")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    contact.RegDate = DateTime.Now;
                    _context.Add(contact);
                    await _context.SaveChangesAsync();

                    ViewBag.Message = "감사합니다. 연락 드리겠습니다.";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $"예외가 발생했습니다. {ex.Message}";
                }
                // return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}

