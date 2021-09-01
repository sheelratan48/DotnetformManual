using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dotnetman.Models;
using Microsoft.EntityFrameworkCore;


namespace Dotnetman.Controllers
{
    public class StuController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StuController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var displaydata = _db.StudentTable.ToList();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewStuClass nec)
        {
            if(ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(nec);
        }

        

        [HttpPost]
        public async Task<IActionResult> Edit(NewStuClass nc)
        {
            if(ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
            
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getstudetails = await _db.StudentTable.FindAsync(id);
            return View(getstudetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getstudetails = await _db.StudentTable.FindAsync(id);
            return View(getstudetails);
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        { 

            var getstudetails = await _db.StudentTable.FindAsync(id);
            _db.StudentTable.Remove(getstudetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
