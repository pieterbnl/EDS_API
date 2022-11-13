using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using EnergyDataSystemAPI.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public class SqlEnergyMeterRespository : IEnergyMeterRepository
{
    public Task<EnergyMeter> CreateEnergyMeterAsync(EnergyMeter energyMeter)
    {
        throw new NotImplementedException();
    }

    public Task<EnergyMeter> DeleteEnergyMeterAsync(int energyMeterId)
    {
        throw new NotImplementedException();
    }

    public Task<EnergyMeter> GetEnergyMeterAsync(int energyMeterId)
    {
        throw new NotImplementedException();
    }

    public Task<List<EnergyMeter>> GetEnergyMetersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EnergyMeter> UpdateEnergyMeterAsync(int energyMeterId, EnergyMeterCreationDTO energyMeterCreationDTO)
    {
        throw new NotImplementedException();
    }
}