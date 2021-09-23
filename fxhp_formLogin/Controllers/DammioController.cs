using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fxhp_formLogin.Controllers
{
    public class DammioController : Controller
    {
        //
        // GET: /Dammio/

        public ActionResult Index()
        {
            return View();
        }

        public string chaoMung1()
        {
            return "chào mừng 1";
        }

        public ActionResult test()
        {
            return View();
        }
        public ActionResult Hello(string name,string address,int numInt = 10)
        {
            // các kiến thức về viewBag (thuộc tính động lưu tất cả các biến đẩy vể), ViewData, TempData : các 
            // kiểu đẩy dữ liệu
            ViewBag.Message = "hello: " +name;
            ViewBag.Address = "địa chỉ tại : " +address;
            ViewBag.NumInt = numInt;
            
            return View();
            // sự khác nhau giữa html.actionLink và url.action 
        }
    }
}
