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

    // Navigation properties
    public Address Address { get; set; }
    public ICollection<Contact> Contacts { get; set; }    
    public ICollection<BuildingGroup> BuildingGroups { get; set; } // Owner can own multiple building groups, each containing one or more buildings
}