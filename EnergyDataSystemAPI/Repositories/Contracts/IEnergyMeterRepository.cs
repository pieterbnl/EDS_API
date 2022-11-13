using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystemAPI.Repositories.Contracts;

public interface IEnergyMeterRepository
{
    Task<List<EnergyMeter>> GetEnergyMetersAsync();
    Task<EnergyMeter> GetEnergyMeterAsync(int energyMeterId);
    Task<EnergyMeter> CreateEnergyMeterAsync(EnergyMeter energyMeter);
    Task<EnergyMeter> UpdateEnergyMeterAsync(int energyMeterId, EnergyMeterCreationDTO energyMeterCreationDTO);
    Task<EnergyMeter> DeleteEnergyMeterAsync(int energyMeterId);
    //Task<EnergyMeter> SoftDeleteEnergyMeterAsync(int energyMeterId);
    //Task<bool> Exists(int energyMeterId);
}