using BusinessLayer.Managers;
using DAL.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers.Account
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            var ctx = HttpContext.GetOwinContext();
            var userManager = ctx.GetUserManager<EmployeeManager>();
            var auth = ctx.Authentication;

            var user = await userManager.FindAsync(model.Email, model.Password);
            var identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
            auth.SignIn(new AuthenticationProperties
            {
                IsPersistent = false,
            }, identity);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();
            var employee = new Employee
            {

                Email = model.Email,
                Age = model.Age,
                UserName = model.Email,
                PhoneNumber = model.Phone,
                LastName = model.LastName,
                PostalCode=model.PostalCode,
                FirstName=model.FirstName,
                City=model.City

                /// role?????????
            };

            await userManager.CreateAsync(employee, model.Password);


            return RedirectToAction("LogIn");
        }

        public ActionResult Register()
        {
            return View();
        }


        [Authorize]
        public ActionResult LogOut()
        {
            var ctx = HttpContext.GetOwinContext();
            var authManager = ctx.Authentication;
            authManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);


            return RedirectToAction("LogIn");


        }
    }
}