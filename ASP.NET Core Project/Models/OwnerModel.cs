using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Models
{
    public class OwnerModel
    {
        [Key]
        [MaxLength(10, ErrorMessage ="Need to be valid SSN!")]
        public string SSN { get; set; }

        [Required]
        public string Name { get; set; }

        public List<CarOwnerModel> CarOwners { get; set; }
    }
}
