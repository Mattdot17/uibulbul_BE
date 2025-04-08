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
            string columns = "";
            string rows = "";
            var info = typeof(T).GetProperties();
            foreach (var prop in info)
            {
                columns += prop.Name + "\t";
            }

            foreach (var item in values)
            {
                var row = "";
                foreach (var col in info)
                {
                    row += "\"" + col.GetValue(item) + "\"" + "\t" ;
                }
                rows += row.TrimEnd() + "\n";
            }


            return Ok(columns.TrimEnd() + "\n" + rows);

        }
    }
}
