using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShareCourses.Models;

namespace ShareCourses.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Parial_ItemsByCateId()
        {
            var items = db.Products.Where(x => x.IsHome && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }

        public ActionResult Parial_ProductSales()
        {
            var items = db.Products.Where(x => x.IsSale && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }

        //[HttpPost]

        //public ActionResult IsActive(int id)
        //{
        //    var item = db.Products.Find(id);
        //    if (item != null)
        //    {
        //        item.IsActive = !item.IsActive;
        //        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //        return Json(new { success = true, isAcive = item.IsActive });
        //    }
        //    return Json(new { success = false });
        //}

        //[HttpPost]

        //public ActionResult IsHome(int id)
        //{
        //    var item = db.Products.Find(id);
        //    if (item != null)
        //    {
        //        item.IsActive = !item.IsHome;
        //        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //        return Json(new { success = true, IsHome = item.IsHome });
        //    }
        //    return Json(new { success = false });
        //}

        //[HttpPost]

        //public ActionResult IsSale(int id)
        //{
        //    var item = db.Products.Find(id);
        //    if (item != null)
        //    {
        //        item.IsSale = !item.IsSale;
        //        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //        return Json(new { success = true, IsSale = item.IsSale });
        //    }
        //    return Json(new { success = false });
        //}
    }
}