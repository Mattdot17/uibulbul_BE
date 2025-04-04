using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using uibulbul.Data;
using uibulbul.Services;

namespace uibulbul.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly CurrencyServices _currencyService ;

        public CurrencyController (CurrencyServices currencyService)
        {
            _currencyService = currencyService;
        }



        // GET: CurrencyController
        public IActionResult Index()
        {
            return Ok(_currencyService.GetAllCurrencies());
        }

        // GET: CurrencyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CurrencyController/Create
        public void Create()
        {
            _currencyService.AddSampleCurrencies();
        }

        // POST: CurrencyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CurrencyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CurrencyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CurrencyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CurrencyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
