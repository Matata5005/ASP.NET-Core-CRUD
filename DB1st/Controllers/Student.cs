using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB1st.Data;
using System.Data;
//using System.Data.Entity;
using DB1st.Models;
using Microsoft.EntityFrameworkCore;

namespace DB1st.Controllers
{
    public class Student : Controller
    {
        private readonly ApplicationDbContext _db;

        public Student(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Products
        public IActionResult Index()
        {
            var displaydata = _db.StudentTable.ToList();
            return View(displaydata);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewStudents nec)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nec);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getstudentdetails = await _db.StudentTable.FindAsync(id);
            return View(getstudentdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewStudents nc)
        {
            if (ModelState.IsValid)
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
            var getstudentdetails = await _db.StudentTable.FindAsync(id);
            return View(getstudentdetails);

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getstudentdetails = await _db.StudentTable.FindAsync(id);
            return View(getstudentdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            //if (id == null)
            //{
                //return RedirectToAction("Index");
            //}
            var getstudentdetails = await _db.StudentTable.FindAsync(id);
            _db.StudentTable.Remove(getstudentdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
