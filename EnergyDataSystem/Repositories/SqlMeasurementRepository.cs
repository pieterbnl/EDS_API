using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public class SqlMeasurementRepository : IMeasurementRepository
{
    public Task<Measurement> CreateMeasurementAsync(Measurement measurement)
    {
        throw new NotImplementedException();
    }

    public Task<Measurement> DeleteMeasurementAsync(int measurementId)
    {
        throw new NotImplementedException();
    }

    public Task<Measurement> GetMeasurementAsync(int measurementId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Measurement>> GetMeasurementsAsync()
    {
        throw new NotImplementedException();
    }
}