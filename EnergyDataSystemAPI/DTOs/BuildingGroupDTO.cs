using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;

public class BuildingGroupDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int OwnerId { get; set; }
    public OwnerDTO Owner { get; set; }
    public ICollection<BuildingDTO> Buildings { get; set; }
}