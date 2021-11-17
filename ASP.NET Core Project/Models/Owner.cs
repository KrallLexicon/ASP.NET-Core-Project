using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Models
{
    public class Owner
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public static List<Owner> listOfOwners = new List<Owner>();
        
        public static void GenerateOwners()
        {
            listOfOwners.AddRange(new List<Owner> {
            new Owner {Name="Kalle", Phone="123454562131"},
            new Owner {Name="Anna", Phone="8451231123123"},
            new Owner {Name="Robin", Phone="845612195413"}
            });
        }
    }
}
