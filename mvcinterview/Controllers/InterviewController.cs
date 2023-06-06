using Microsoft.AspNetCore.Mvc;

namespace mvcinterview.Controllers
{
    public class InterviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
