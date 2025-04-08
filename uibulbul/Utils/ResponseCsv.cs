using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using static Azure.Core.HttpHeader;

namespace uibulbul.Utils
{
    public class BaseEntity
    {

    }
    public class ResponseCsv : Controller
    {
        public IActionResult render<T>(List<T> values)
        {
            string columns = string.Empty;
            string rows = string.Empty;
            int length = 30;
            var info = typeof(T).GetProperties();
            foreach (var prop in info)
            {
                //int spaces = prop.Name.Length < length ? length - prop.Name.Length : 0;
                columns += prop.Name.PadRight(length);
            }

            foreach (var item in values)
            {
                var row = string.Empty;
                foreach (var col in info)
                {
                    string itemName = col.GetValue(item).ToString() ?? string.Empty;
                    //int spaces = itemName.Length < length ? length - itemName.Length : 0;
                    row += itemName.PadRight(length);
                }
                rows += row + "\n";
            }


            return Ok(columns + "\n" + rows);

        }
    }
}
