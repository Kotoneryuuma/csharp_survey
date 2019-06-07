using Microsoft.AspNetCore.Mvc;

namespace IndexASp
{
    public class HomeController : Controller{
        [HttpGet]
        [Route("")]
        public ViewResult index(){
            return View("index");
        }

        [HttpPost]
        [Route("process")]
        public RedirectToActionResult Method(string name, string localist, string lanlist, string comment)
        {
            var myobject = new {
                Name = name,
                Location = localist,
                Language = lanlist,
                Comment = comment
            };
            return RedirectToAction("result", myobject);
        }
        [HttpGet]       
        [Route("result")]     
        public ViewResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("result");
        }
    }
}