using Microsoft.AspNetCore.Mvc;

namespace uibulbul.Utils
{
    public class ResponseError : Controller
    {
        public IActionResult render()
        {
            return NotFound();
        }
    }
}
