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

    // Navigation properties
    public BuildingGroup BuildingGroup { get; set; } // A building belongs to a single building group
    public Address Address { get; set; } // A building has a single location
    public ICollection<Contact> Contacts { get; set; } // A building can have multiple contacts
    public Owner Owner { get; set; } // A building has a single owner
    public ICollection<EnergyMeter> EnergyMeters { get; set; } // A building can have multiple energy meters
}