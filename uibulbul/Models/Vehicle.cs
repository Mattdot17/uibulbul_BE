using NuGet.Protocol;
using uibulbul.Services;

namespace uibulbul.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Image { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string FuelTypes { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public float Price { get; set; }
        public bool Popular { get; set; }

        public string CachedVehicle(int id, CacheServices<Vehicle> _cacheServices, VehicleService _vehicleService)
        {
            Vehicle item;
            bool exists = _cacheServices.GetKey(id, out item);
            if (exists == false)
            {
                item = _vehicleService.GetById(id);
                _cacheServices.SetKey(id, item);
                ;
            }
            return item.ToJson();
        }
    }

    


}
