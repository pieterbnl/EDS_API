using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class Owner
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public int AddressId { get; set; }
    /*public int ContactId { get; set; }*/

    // Navigation properties
    public Address Address { get; set; }
    /*public Contact Contact { get; set; }    */
    public ICollection<BuildingGroup> BuildingGroups { get; set; } // Owner can own multiple building groups, each containing one or more buildings
}