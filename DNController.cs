using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai_1.Models;

namespace bai_1.Controllers
{
    public class DNController : Controller
    {
        //
        // GET: /DN/
        
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string name,string pass)
        {
            if("yennh".Equals(name) && "1234".Equals(pass))
            {
            //    var user = new User();
            //    user.login = name;
            //    user.Username = "Di Da";

                Session["user"]= new User(){login= name, Username= "Di Da"};

            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public ActionResult DangKy(string name,string pass,string rt_pass){
            if (name.Length >= 2 && pass.Length >= 4 && pass.Equals(rt_pass))
                return RedirectToAction("DangNhap", "DN");
            else
                return View();
        }
        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        
	}
}
