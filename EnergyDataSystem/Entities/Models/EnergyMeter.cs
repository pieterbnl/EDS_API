using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class EnergyMeter
{
    public int Id { get; set; }
    public string Name { get; set; }            
    public string Model { get; set; } // For example: "double rate", "single rate"
    public EnergyMeterStatus Status { get; set; }
    public EnergyMeterType Type { get; set; } // For example: "Electricity", "Gas", "Heat", ...
    public EnergyMeterCapacity Capacity { get; set; } // For example: "high capacity", "low capcity"    
    public EnergyMeterMeasurementUnit Unit { get; set; } // For example: "kWH", "m3", "liter", ...

    // Navigation properties
    public Building Building { get; set; } // An energy meter can belong to one building only
}