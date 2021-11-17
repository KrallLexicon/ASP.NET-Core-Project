using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Models
{
    public class Car
    {
        public string CarModel { get; set; }
        public string Brand { get; set; }
        public string RegNumber { get; set; }

        public static List<Car> listOfCars = new List<Car>();

        public static void GenerateCars()
        {
            listOfCars.AddRange(new List<Car> {
            new Car {Brand="Volvo", CarModel="V70", RegNumber="ABC-123"},
            new Car{Brand="SAAB", CarModel="93", RegNumber="DEF-456"},
            new Car{Brand="BMW", CarModel="E66", RegNumber="GHI-789"}
            });
        }
    }
}
