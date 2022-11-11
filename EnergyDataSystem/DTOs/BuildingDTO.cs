using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;
public class BuildingDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int BuildingGroupId { get; set; }
    public int AddressId { get; set; }    
    public AddressDTO Address { get; set; }
    public BuildingGroupDTO BuildingGroup { get; set; }
    public ICollection<EnergyMeterDTO> EnergyMeters { get; set; }
}