using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

namespace uibulbul.Utils
{
    public class ResponseJson : Controller
    {

        public IActionResult render(dynamic value)
        {
            return Ok(value);
        }
    }
}
