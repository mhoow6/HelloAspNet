using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloEmpty.Models;

namespace HelloEmpty.Controllers
{
    // 어떤 화면(View)에 어떤 정보를 연동시켜줄 지 Controller에서 결정한다.
    // Controller 앞의 이름과 View의 이름을 맞춰줘야 한다.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HelloMessage msg = new HelloMessage()
            {
                Message = "Welcome to Asp.Net MVC !"
            };

            // View다가 데이터를 넘기는 바구니
            ViewBag.Noti = "Input message and click submit";

            return View(msg);
        }

        // POST를 처리하는 Index
        [HttpPost]
        public IActionResult Index(HelloMessage obj)
        {
            ViewBag.Noti = "Message Changed";
            return View(obj);
        }
    }
}
