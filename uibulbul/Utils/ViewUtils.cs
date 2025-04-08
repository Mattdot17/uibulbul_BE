using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

namespace uibulbul.Utils
{
    public class ViewUtils
    {
        public string _type { get; set; }
        public ViewUtils(string type)
        {
            _type = type;
        }
        public IActionResult response<T>(List<T> value)
        {
            Dictionary<string, Func<IActionResult>> response = new()
            {
                { "json" , () => new Utils.ResponseJson().render(value)},
                { "view", () => new Utils.ResponseView().render(value) },
                { "csv", () =>  new Utils.ResponseCsv().render<T>(value)}

            };

            bool exists = response.TryGetValue(_type, out Func<IActionResult>? getResponse);
            if (exists) return getResponse!();
            return new Utils.ResponseError().render();

        }

    }
}
