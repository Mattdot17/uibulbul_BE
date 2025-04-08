using Microsoft.AspNetCore.Mvc;

namespace uibulbul.Utils
{
    public class ResponseView : Controller
    {
        public IActionResult render(dynamic value)
        {
            return View(value);
        }
    }
}
