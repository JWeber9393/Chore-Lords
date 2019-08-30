using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChoreLords.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


namespace ChoreLords.Controllers
{
    public class LogRegController : Controller
    {
        private ChoreLordsContext dbContext;
        public LogRegController(ChoreLordsContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index(string msg)//Register Page
        {
            LogRegWrapper vm = new LogRegWrapper();
            vm.allUsers = dbContext.Users.ToList();
            if (msg != null)
            {
                ViewBag.ErrorMessage = msg;
            }
            return View(vm);
        }


        [HttpPost]
        [Route("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(u => u.alias == newUser.alias))
                {
                    string msg = "Alias not unique!";
                    return RedirectToAction("Index", new { msg = msg });
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.password = Hasher.HashPassword(newUser, newUser.password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();
                    //session user
                    HttpContext.Session.SetInt32("User", newUser.UserId);
                    return RedirectToAction("AvatarSelect");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        [Route("select_avatar")]
        public IActionResult AvatarSelect()
        {
            return View("AvatarSelect");
        }
        
        [HttpPost("/addgladiator")]
        public IActionResult CreateGladiator(AvatarSelectViewModel ModelData)
        {
            var newGladiator = new Gladiator(ModelData.Name);
                dbContext.Add(newGladiator);
                dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }

        [HttpPost("/addsamurai")]
        public IActionResult CreateSamurai(AvatarSelectViewModel ModelData)
        {
            var newGladiator = new Samurai(ModelData.Name);
                dbContext.Add(newGladiator);
                dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }

        [HttpPost("/addviking")]
        public IActionResult CreateViking(AvatarSelectViewModel ModelData)
        {
            var newGladiator = new Viking(ModelData.Name);
                dbContext.Add(newGladiator);
                dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }



        [HttpPost]
        [Route("login")]
        public IActionResult Login(LogRegWrapper userSub)//Had to change because we are passing this a wrapper model
        {
            LogUser userSubmission = userSub.logUser;//made an instance of LogUser from the wrapper model to userSubmission in order to continue using userSubmission and not changing it throughout!

            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault(u => u.alias == userSubmission.log_alias);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View! 
                    string msg = "Invalid Email/Password!";
                    return RedirectToAction("Index", new { msg = msg });
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<LogUser>();

                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.password, userSubmission.log_password);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    string msg = "Invalid Email/Password!";
                    return RedirectToAction("Index", new { msg = msg });
                }
                else
                {
                    HttpContext.Session.SetInt32("User", userInDb.UserId);
                    return RedirectToAction("Dashboard", "Home");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult Logout(string msg = "")
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", new { msg = msg });
        }
    }
}