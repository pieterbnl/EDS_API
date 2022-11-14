using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;
public class MeasurementDTO
{
    public int Id { get; set; }
    public int EnergyMeterId { get; set; }
    public DateTime TimeStamp { get; set; }
    public int Value { get; set; }    
    public EnergyMeterDTO EnergyMeter { get; set; } 
}