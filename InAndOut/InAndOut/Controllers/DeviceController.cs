using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class DeviceController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
