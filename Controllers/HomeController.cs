using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebTest.Models;
using Microsoft.EntityFrameworkCore;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
               
        public ApplicationContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ContactList()
        {
            return View(await db.Contact.ToListAsync());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Contact contacts)
        {
            db.Contact.Add(contacts);
            await db.SaveChangesAsync();
            return RedirectToAction("ContactList");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //Удаление
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id != null)
            {
                Contact contact = new Contact { TabN = id.Value };
                db.Entry(contact).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                    return RedirectToAction("ContactList");
            }
            return NotFound();
        }

        //Редактирование 
        public async Task<IActionResult> Edit(int? id)
        {
            if (id!=null)
            {
                Contact? contact = await db.Contact.FirstOrDefaultAsync(p => p.TabN == id);
                if (contact != null) return View(contact);
             }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit (Contact contact)
        {
            db.Contact.Update(contact);
            await db.SaveChangesAsync();
            return RedirectToAction("ContactList");
        }

    }
}