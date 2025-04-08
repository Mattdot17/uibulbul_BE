using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using uibulbul.Data;
using uibulbul.Models;
using uibulbul.Services;
using AutoMapper;
using uibulbul.DTO;


namespace uibulbul.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly VehicleService _vehicleService;
        private readonly CacheServices<Vehicle> _cacheServices;

        public VehiclesController(VehicleService vehicleService, CacheServices<Vehicle> cacheServices)
        {
            _vehicleService = vehicleService;
            _cacheServices = cacheServices;
        }

        [HttpGet]
        // GET: vehicles
        public IActionResult Index(string type = "csv")
        {
            return new Utils.ViewUtils(type).response<VehicleDTO>(_vehicleService.GetAllVehicles());
        }

        //// GET: vehicles/details/5
        //public string Details(int id)
        //{
        //    Vehicle vehicle = new();
        //    return vehicle.CachedVehicle(id, _cacheServices, _vehicleService);
        //}

        //// GET: vehicles/Create
        ////public string Create()
        ////{
        ////    _vehicleService.AddSampleVehicles();
        ////    return _vehicleService.GetAllVehicles().ToJson();
        ////}



        //// POST: vehicles/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: vehicles/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: vehicles/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: vehicles/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: vehicles/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
