using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundriSoft_Assignment.Models;
using MundriSoft_Assignment.Services;

namespace MundriSoft_Assignment.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices services;

        public UserController(IUserServices services)
        {
            this.services = services;
        }        

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = services.Register(user);
                    if (res == 1)
                    {
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                return View();
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            try
            {
                User u = services.Login(user);
                if (u != null)
                {

                    HttpContext.Session.SetString("User_Id", u.User_Id.ToString());
                    HttpContext.Session.SetString("Email", u.Email);
                    HttpContext.Session.SetString("Role_Id", u.Role_Id.ToString());

                    if (u.Email == user.Email)
                    {
                        return RedirectToAction("Index", "Employee");
                    }
                    else
                    {
                        return RedirectToAction("Register", "User");
                    }
                }
                else
                {
                    ViewBag.ErrorMsg = "Invalid Email or Password";
                }
            }
            catch (Exception ex)
            {
                return View();
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(User user)
        {
            try
            {

                string userid = HttpContext.Session.GetString("User_Id");
                user.User_Id = Convert.ToInt32(userid);
                int result = services.ForgetPassword(user);
                if (result == 1)
                {
                    ViewBag.SuccessMessage = "Updated Successfully !";
                }
                else
                {
                    ViewBag.ErrorMessage = "Something wrong!";
                }


            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Something wrong!";
                return View();
            }
            return View();
        }



    }
}
