using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using factorySystem.Models;
namespace factorySystem.Controllers
{
    public class CompanyController : Controller
    {
        DatabaseHandlerClass db = new DatabaseHandlerClass();
        //
        // GET: /Company/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Company/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Company/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult getCompany()
        {
            ModelState.Clear();
            return View(db.companyList());
        }

        //
        // POST: /Company/Create
        [HttpPost]
        public ActionResult Create(Company cp)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    DatabaseHandlerClass db = new DatabaseHandlerClass();
                    if (db.addCompany(cp))
                    {
                        ViewBag.Message = "Company Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Company/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Company/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Company/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Company/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
