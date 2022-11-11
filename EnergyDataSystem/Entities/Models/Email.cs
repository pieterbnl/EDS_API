using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class Email
{
    public int Id { get; set; }
    public string EmailAddress { get; set; }

    // Navigation properties
    public Contact Contact { get; set; } // An email address can belong to one single contact only
}