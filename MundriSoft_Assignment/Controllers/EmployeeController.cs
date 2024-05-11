using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundriSoft_Assignment.Models;
using MundriSoft_Assignment.Services;

namespace MundriSoft_Assignment.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices services;

        public EmployeeController(IEmployeeServices services)
        {
            this.services = services;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            var result = services.GetAllEmployee();
            return View(result);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var result = services.GetEmployeeById(id);
            return View(result);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                int result = services.AddEmployee(employee);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = services.GetEmployeeById(id);
            return View(result);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                int result = services.UpdateEmployee(employee);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();     //regenarate main page
                }
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = services.GetEmployeeById(id);
            return View(result);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                int result = services.DeleteEmployee(id);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));


                }
                else
                {
                    return View();

                }
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
