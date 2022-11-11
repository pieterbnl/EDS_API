using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;
public class BuildingCreationDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int BuildingGroupId { get; set; }
    public int AddressId { get; set; }
    
    // note: addition of energy meters follows seperately, after creation of building ?
}