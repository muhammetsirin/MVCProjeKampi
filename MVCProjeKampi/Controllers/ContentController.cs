﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Concrete;

namespace MVCProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }
        Context c = new Context();
        public ActionResult GetAllContent(string p)
        {

            var values = cm.GetList(p);
          
            return View(values);
        }
        public ActionResult ContentbyHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}