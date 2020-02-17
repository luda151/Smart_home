using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Smart_home.Controllers
{
    public class ReleController : Controller
    {
        // GET: Rele
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rele/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rele/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rele/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Rele/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rele/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Rele/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rele/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}