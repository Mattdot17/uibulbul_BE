using System.Linq;
using System.Security.AccessControl;
using AutoMapper;
using NuGet.Protocol;
using uibulbul.Data;
using uibulbul.DTO;
using uibulbul.Models; 

namespace uibulbul.Services
{

    public class VehicleService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public VehicleService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }

        private VehicleDTO GetAllVehicles(int start = 0, int itemForPage = 5)
        {
            var list = _context.Vehicles.Skip(start * itemForPage).Take(itemForPage).ToList();
            var data = _mapper.Map<VehicleDTO>(list);
            return data;
        }

        public List<VehicleDTO> GetAllVehicles()
        {
            var data = _context.Vehicles.ToList();
            var returnValue = _mapper.Map<List<VehicleDTO>>(data);
            return returnValue;
        }



        public VehicleDTO GetPaginatedVehicles(int page = 0)
        {
            var items = GetAllVehicles(page);
            return items;
        }

        public Vehicle? GetById(int id)
        {
            return _context.Vehicles.Find(id);
        }
        public void AddNewVehicle(Vehicle vehicle)
        {
            
            Vehicle newVehicle = new()
            {
                Image = vehicle.Image,
                Model = vehicle.Model,
                FuelTypes = vehicle.FuelTypes,
                Capacity = vehicle.Capacity,
                Price = vehicle.Price,
                Popular = vehicle.Popular
            };

            _context.Vehicles.Add(newVehicle);
            _context.SaveChanges();
        }

        public void AddSampleVehicles()
        {
            _context.Vehicles.AddRange(
                new Vehicle
                {
                    Image = "fiat_panda.jpg",
                    Model = "Panda",
                    FuelTypes = "Benzina",
                    Capacity = 4,
                    Price = 12500.00f,
                    Popular = true
                },
            new Vehicle
            {
                Image = "ford_focus.jpg",
                Model = "Focus",
                FuelTypes = "Diesel",
                Capacity = 5,
                Price = 18000.50f,
                Popular = true
            },
            new Vehicle
            {
                Image = "renault_clio.jpg",
                Model = "Clio",
                FuelTypes = "Benzina",
                Capacity = 5,
                Price = 16200.75f,
                Popular = false
            },
            new Vehicle
            {
                Image = "bmw_serie3.jpg",
                Model = "Serie 3",
                FuelTypes = "Benzina/Elettrica",
                Capacity = 5,
                Price = 45000.00f,
                Popular = true
            },
            new Vehicle
            {
                Image = "dacia_duster.jpg",
                Model = "Duster",
                FuelTypes = "GPL",
                Capacity = 5,
                Price = 17800.90f,
                Popular = true
            },
            new Vehicle
            {
                Image = "peugeot_208.jpg",
                Model = "208",
                FuelTypes = "Elettrica",
                Capacity = 4,
                Price = 28000.00f,
                Popular = false
            },
            new Vehicle
            {
                Image = "audi_a4.jpg",
                Model = "A4",
                FuelTypes = "Diesel",
                Capacity = 5,
                Price = 38500.00f,
                Popular = true
            },
            new Vehicle
            {
                Image = "citroen_c3.jpg",
                Model = "C3",
                FuelTypes = "Benzina",
                Capacity = 5,
                Price = 14900.50f,
                Popular = false
            }
            );
            _context.SaveChanges();
        }
    }
}