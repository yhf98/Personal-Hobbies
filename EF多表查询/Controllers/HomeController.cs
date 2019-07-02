using EF多表查询.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF多表查询.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (StuEntities db = new StuEntities())
            {
                var userListTest = (from u in db.Class
                                    join p in db.Stu on u.ClassID equals p.ClassID
                                    select new {StuID=p.StuID,StuName=p.StuName,ClassName=u.ClassName });
                List<dynamic> oneList = new List<dynamic>();
                foreach (var one in userListTest.ToList())
                {
                    dynamic dyObject = new ExpandoObject();
                    dyObject.StuName = one.StuName;
                    dyObject.StuID = one.StuID;
                    dyObject.ClassName = one.ClassName;
                    oneList.Add(dyObject);
                }

                ViewBag.dyObject = oneList;
                return View();
            }   
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}