using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class Phonenumber
{
    public int Id { get; set; }
    public string TypeOfPhonenumber { get; set; }
    public string Number { get; set; }

    // Navigation properties
    public Contact Contact { get; set; } // A phonenumber can belong to one contact only
}