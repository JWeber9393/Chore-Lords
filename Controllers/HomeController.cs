using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChoreLords.Models;
using Microsoft.AspNetCore.Http;

namespace ChoreLords.Controllers
{
    public class HomeController : Controller
    {
        public int? UserSession
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("UserId", (int)value); }
        }
        public int? CharacterSession
        {
            get { return HttpContext.Session.GetInt32("CurrCharId"); }
            set { HttpContext.Session.SetInt32("CurrCharId", (int)value); }
        }
        private ChoreLordsContext _dbContext;
        public HomeController(ChoreLordsContext context)
        {
            _dbContext = context;
        }

        // TODO: Add Users, Characters table to DbContext in order to use loggedInUser, currChar
        // private User loggedInUser
        // {
        //     get { return _dbContext.Users.FirstOrDefault(u => u.Id == HttpContext.Session.GetInt32("UserId")); }
        // }
        // private Character currChar
        // {
        //     get { return _dbContext.Characters.FirstOrDefault(u => u.Id == HttpContext.Session.GetInt32("CurrCharId")); }
        // }
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            // TODO: Add Linq query to fetch all Chores

            DashboardViewModel vm = new DashboardViewModel();
            return View(vm);
        }

        [HttpPost("chore/create")]
        public IActionResult Create(DashboardViewModel modelData)
        {
            if(ModelState.IsValid)
            {
                Chore newChore = modelData.Chore;
                // newChore.LaborerId = loggedInUser.Id; //! currChar not fully defined yet

                _dbContext.Add(newChore);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("Chore", "Chore is invalid");
            // Dashboard is expecting this data and will complain without it // TODO: Refactor to a method
            var allChores = _dbContext.Chores
                .Include(u => u.Creator)
                .OrderByDescending(m => m.CreatedAt)
                .ToList();

            DashboardViewModel vm = new DashboardViewModel();
            vm.Chores = allChores;
            return View("Dashboard", vm);
        }

        [HttpGet("chore/{ChoreId}")]
        public IActionResult Show(int choreId)
        {
            return View("Dashboard");
        }
    }
}
