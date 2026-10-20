using Microsoft.AspNetCore.Mvc;

namespace abc.Controllers
{
    public class HelloController : Controller
    {


        public string Greeting()
        {
            return "Chào mừng các bạn đến với môn học ASP.NET MVC!";
        }
        public string Welcome(int id1, string name)
        {
            return $"Xin chào {id1} - {name}, chúc các bạn học tốt môn ASP.NET MVC!";
        }
        //IactionResult 
        public IActionResult Welcome1(int id1, string name)
        {
            ViewBag.Id = id1;
            ViewData["Name"] = name;

            return View();
    }
    } 
}
