using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChoreLords.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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
        private User loggedInUser
        {
            get { return _dbContext.Users.FirstOrDefault(u => u.UserId == UserSession); }
        }
        // private Character currChar
        // {
        //     get { return _dbContext.user.FirstOrDefault(u => u.Id == HttpContext.Session.GetInt32("CurrCharId")); }
        // }
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            DashboardViewModel vm = new DashboardViewModel();
            vm.Chores = GetAllChores();

            return View(vm);
        }

        [HttpGet("chore/new")]
        public IActionResult NewChore()
        {
            return View();
        }

        [HttpPost("chore/create")]
        public IActionResult CreateChore(Chore newChore)
        {
            if(ModelState.IsValid)
            {
                newChore.CharacterId = loggedInUser.UserId; //! currChar not fully defined yet

                _dbContext.Add(newChore);
                _dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            ModelState.AddModelError("Chore", "Chore is invalid");
            return View("NewChore");
        }

        [HttpGet("chore/{ChoreId}")]
        public IActionResult Show(int choreId)
        {
            return View("Dashboard");
        }

        // Helper functions
        public List<Chore> GetAllChores()
        {
            var allChores = _dbContext.Chores
                .Include(u => u.Creator)
                .OrderByDescending(m => m.CreatedAt)
                .ToList();
            return allChores;
        }
    }
}
