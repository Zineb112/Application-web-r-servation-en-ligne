using Bookingapp.Data;
using Bookingapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookingapp.Controllers
{
    public class AdminReservationController : Controller
    {


        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AdminReservationController(ApplicationDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        // GET: AdminReservationController
        public async Task<ActionResult> Index()
        {


            var list = await _context.Reservations
                .Include(t => t.Reserve)
                .Include(s => s.Student)
                .OrderBy(r => r.Date)
               
                .ToListAsync();
            return View("Index", list);
        }

        // GET: AdminReservationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminReservationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminReservationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminReservationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminReservationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
