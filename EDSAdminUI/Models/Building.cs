using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class Building
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }    
    public int AddressId { get; set; }
    public int? BuildingGroupId { get; set; }

    // Navigation properties
    public Address Address { get; set; } // A building has a single location    
    public BuildingGroup BuildingGroup { get; set; } // A building belongs to a single building group        
    public ICollection<EnergyMeter> EnergyMeters { get; set; } // A building can have multiple energy meters
}