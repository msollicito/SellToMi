using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SellToMi.Models;

namespace SellToMi.Controllers
{
    public class DisplayAdViewModel
    {
        public GetFullAd_Result AdObject { get; set; }
        public List<GetSubCategories_Result> SubCatObject { get; set; }
    }  
    public class FullAdController : Controller
    {
        private DB_77381_txttoadEntities db = new DB_77381_txttoadEntities();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(db.vwFullAdItem.ToList());
        }

        //
        // GET: /Default1/Details/5
        
        public ActionResult DisplayAd(int id = 0)
        {
            List<GetFullAd_Result> vwfulladitem = db.GetFullAd(id).ToList<GetFullAd_Result>();
            if (vwfulladitem.Count() == 0)
            {
                return HttpNotFound();
            }
            GetFullAd_Result fullAd = vwfulladitem.ElementAt(0);

            List<GetSubCategories_Result> SubCats = db.GetSubCategories(fullAd.CategoryId).ToList<GetSubCategories_Result>();

            var DisplayAdViewModel = new DisplayAdViewModel
            {
                AdObject = fullAd,
                SubCatObject = SubCats
            };
            return View(DisplayAdViewModel);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(vwFullAdItem vwfulladitem)
        {
            if (ModelState.IsValid)
            {
                db.vwFullAdItem.Add(vwfulladitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vwfulladitem);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            vwFullAdItem vwfulladitem = db.vwFullAdItem.Find(id);
            if (vwfulladitem == null)
            {
                return HttpNotFound();
            }
            return View(vwfulladitem);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(vwFullAdItem vwfulladitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vwfulladitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vwfulladitem);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            vwFullAdItem vwfulladitem = db.vwFullAdItem.Find(id);
            if (vwfulladitem == null)
            {
                return HttpNotFound();
            }
            return View(vwfulladitem);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vwFullAdItem vwfulladitem = db.vwFullAdItem.Find(id);
            db.vwFullAdItem.Remove(vwfulladitem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}