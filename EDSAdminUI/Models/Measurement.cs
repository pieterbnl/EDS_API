using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class Measurement
{
    public int Id { get; set; }
    public int EnergyMeterId { get; set; }
    public DateTime TimeStamp { get; set; }
    public int Value { get; set; }

    // Navigation properties
    public EnergyMeter EnergyMeter { get; set; } // A measurement belongs to a single energy meter
}