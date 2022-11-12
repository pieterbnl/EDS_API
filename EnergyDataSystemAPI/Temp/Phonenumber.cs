using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystemAPI.Temp;

public class Phonenumber
{
    public int Id { get; set; }
    public string TypeOfPhonenumber { get; set; } // For example: "office", "business", "facility", ...
    public string Description { get; set; }
    public string Number { get; set; }
    public int ContactId { get; set; }

    // Navigation properties
    public Contact Contact { get; set; } // A phonenumber can belong to one contact only
}