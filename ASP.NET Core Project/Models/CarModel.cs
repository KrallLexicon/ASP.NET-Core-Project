using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Models
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [MaxLength(10)]
        public string RegNumber { get; set; }
        
        [Required]
        public int Mileage { get; set; }

        public List<CarOwnerModel> CarOwners { get; set; }
    }
}
