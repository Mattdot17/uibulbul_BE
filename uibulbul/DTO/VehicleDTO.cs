namespace uibulbul.DTO
{
    public class VehicleDTO
    {
        public int Id { get; set; }
        public string Image { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string FuelTypes { get; set; } = string.Empty;
        public int Capacity { get; set; }

        public float Price { get; set; }
        public VehicleDTO() { }
        public VehicleDTO(int id, string image, string model, string fuelTypes, int capacity, float price)
        {
            Id = id;
            Image = image;
            Model = model;
            FuelTypes = fuelTypes;
            Capacity = capacity;
            Price = price;
            
        }
    }
}
