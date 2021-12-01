using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Models
{
    public class CarOwnerModel
    {
        public int CarId { get; set; }
        public CarModel Car { get; set; }

        public string OwnerId { get; set; }

        public OwnerModel Owner { get; set; }
    }
}
