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

namespace uibulbul.Controllers
{

    public class VehiclesController : Controller
    {
        public IActionResult responseByType(dynamic value, string type = "view")
        {
            Dictionary<string, Func<IActionResult>> response = new()
            {
                { "json" , () => Ok(value)},
                { "view", () => View() },
                { "csv", () =>  Ok("csv")}

            };
            bool exists = response.TryGetValue(type, out Func<IActionResult>? getResponse);
            if (exists) return getResponse!();
            return NotFound();

        }

        private readonly VehicleService _vehicleService;
        private readonly CacheServices<Vehicle> _cacheServices;

        public VehiclesController(VehicleService vehicleService, CacheServices<Vehicle> cacheServices)
        {
            _vehicleService = vehicleService;
            _cacheServices = cacheServices;
        }

        // GET: vehicles
        
        public IActionResult Index(string type) 
        {
            return responseByType(_vehicleService.GetAllVehicles(), type);
        }

        // GET: vehicles/details/5
        public string Details(int id)
        {
            Vehicle vehicle = new();
            return vehicle.CachedVehicle(id, _cacheServices, _vehicleService);
        }

        // GET: vehicles/Create
        //public string Create()
        //{
        //    _vehicleService.AddSampleVehicles();
        //    return _vehicleService.GetAllVehicles().ToJson();
        //}



        // POST: vehicles/Create
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

        // GET: vehicles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: vehicles/Edit/5
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

        // GET: vehicles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: vehicles/Delete/5
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
