using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Models
{
    public class CarOwnerViewModel
    {       
        public List<Car> Cars = new List<Car>();
        public List<Owner> Owners = new List<Owner>(); 
    }
}
