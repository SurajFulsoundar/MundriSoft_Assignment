using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundriSoft_Assignment.Models;
using MundriSoft_Assignment.Services;
using System.ComponentModel.DataAnnotations;

namespace MundriSoft_Assignment.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices services;

        public DepartmentController(IDepartmentServices services)
        {
            this.services = services;
        }

        // GET: DepartmentController
        public ActionResult Index()
        {
            var result = services.GetAllDepartment();
            return View(result);
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            var result = services.GetDepartmentById(id);
            return View(result);
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department dept)
        {
            try
            {
                int result = services.AddDepartment(dept);
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

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = services.GetDepartmentById(id);
            return View(result);
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department dept)
        {
            try
            {
                int result = services.UpdateDepartment(dept);
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

        // GET: DepartmentController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = services.GetDepartmentById(id);
            return View(result);
        }

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                int result = services.DeleteDepartment(id);
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
