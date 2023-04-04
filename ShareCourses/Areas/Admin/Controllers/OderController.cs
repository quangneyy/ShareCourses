﻿using PagedList;
using ShareCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace ShareCourses.Areas.Admin.Controllers
{
    public class OderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext(); 
        // GET: Admin/Oder
        public ActionResult Index(int? page)
        {
            var items = db.Orders.OrderByDescending(x => x.CreatedDate).ToList();
            if (page == null)
            {
                page = 1;
            }
            var pageNumber = page ?? 1;
            var pageSize = 10;
            ViewBag.PageSize = pageSize; 
            ViewBag.Page = pageNumber; 
            return View(items.ToPagedList(pageNumber,pageSize));
        }

        public ActionResult View(int id)
        {
            var item = db.Orders.Find(id);
            return View(item);
        }

        public ActionResult Partial_SanPham(int id)
        {
            var items = db.OrderDetails.Where(x => x.OrderId == id).ToList();
            return PartialView(items);
        }
        [HttpPost]
        public ActionResult UpdateTT(int id,int trangthai)
        {
            var item = db.Orders.Find(id);
            if(item == null)
            {
                db.Orders.Attach(item);
                item.TypePayment = trangthai;
                db.Entry(item).Property(x => x.TypePayment).IsModified = true;
                db.SaveChanges();
                return Json( new {Message="Success", Success = true});
            }
            return Json(new { Message = "UnSuccess", Success = false });
        }
    }
}