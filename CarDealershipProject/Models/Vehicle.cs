using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CarDealershipProject.Models
{
    public class Vehicle
    {
        [Key]
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double MilePerGallon { get; set; }
        public double MSRP { get; set; }

        public string VehicleImage { get; set; }
    }

    public class VehicleDBContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}