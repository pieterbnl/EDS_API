using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class Address
{
    public int Id { get; set; }
    public string Type { get; set; } // Type of address: buisiness, shipping, billing, .. ?
    public string Description { get; set; }
    public string StreetName { get; set; }
    public string StreetNumber { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
}