using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystemAPI.Temp;

public class Email
{
    public int Id { get; set; }
    public string Address { get; set; }
    public int ContactId { get; set; }

    // Navigation properties
    public Contact Contact { get; set; } // An email address can belong to one single contact only
}