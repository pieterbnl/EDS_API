using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class Address
{
    public int Id { get; set; }
    public AddressType Type { get; set; } // Type of address: buisiness, shipping, billing, .. ?
    public string Description { get; set; }
    public string StreetName { get; set; }
    public string StreetNumber { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }

    // Navigation properties
    public Building Building { get; set; } // An address can only belong to a single building    
}