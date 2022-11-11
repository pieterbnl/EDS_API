using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class BuildingGroup
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Navigation properties
    public ICollection<Building> Buildings  { get; set; } // A building group can contain multiple buildings
    public ICollection<Contact> Contacts { get; set; } // A building group can have multiple contacts
}