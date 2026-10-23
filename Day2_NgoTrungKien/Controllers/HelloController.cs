using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2_NgoTrungKien.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public  string Index()
        //{
        //    return "Hello World";
        //}
        public IActionResult Index1(String name, int ID)
        {
            //ViewData["Name"]=name;
            //ViewData["ID"]=ID;
            ViewBag.Message="Hello"+name;
            ViewData["ID"]=ID;
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
            return View();
        }
        
    }
}
