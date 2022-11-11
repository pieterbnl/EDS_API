using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;
public class EnergyMeterDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; } 
    public EnergyMeterStatus Status { get; set; }
    public EnergyMeterType Type { get; set; } 
    public EnergyMeterCapacity Capacity { get; set; } 
    public EnergyMeterMeasurementUnit Unit { get; set; } 
    public int BuildingId { get; set; } 
    public BuildingDTO Building { get; set; }
    public ICollection<MeasurementDTO> Measurements { get; set; } 
}