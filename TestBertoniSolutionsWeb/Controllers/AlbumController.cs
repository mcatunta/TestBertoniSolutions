using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestBertoniSolutionsWeb.Models;
using TestBertoniSolutionsWeb.Utils;

namespace TestBertoniSolutionsWeb.Controllers
{
    public class AlbumController : BaseController
    {
        public ActionResult Index()
        {
            var result = Ejecutar(() =>
            {
                return _cliente.Invocar<List<Album>>("albums", MetodoHttp.Get);
            });
            ViewBag.Albums = result;
            return View(result);
        }

        // GET: Album/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Album/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Album/Create
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

        // GET: Album/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Album/Edit/5
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

        // GET: Album/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Album/Delete/5
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