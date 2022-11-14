using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;
public class OwnerDTO
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public AddressDTO Address { get; set; }
    /*public ContactDTO Contact { get; set; }*/
    public ICollection<BuildingGroupDTO> BuildingGroups { get; set; }
}