using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenuineCustomerWebAPI.Controllers
{
    public class GenuineCustomerController : Controller
    {
        // GET: GenuineCustomerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GenuineCustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenuineCustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenuineCustomerController/Create
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

        // GET: GenuineCustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GenuineCustomerController/Edit/5
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

        // GET: GenuineCustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GenuineCustomerController/Delete/5
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
