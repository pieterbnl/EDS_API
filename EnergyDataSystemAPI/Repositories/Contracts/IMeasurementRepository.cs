using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystemAPI.Repositories.Contracts;

public interface IMeasurementRepository
{
    Task<List<Measurement>> GetMeasurementsAsync();
    Task<Measurement> GetMeasurementAsync(int measurementId);
    Task<Measurement> CreateMeasurementAsync(Measurement measurement);
    /*Task<Measurement> UpdateMeasurementAsync(int measurementId, MeasurementCreationDTO measurementCreationDTO);*/
    Task<Measurement> DeleteMeasurementAsync(int measurementId);
    //Task<Measurement> SoftDeleteAddressAsync(int measurementId);
    //Task<bool> Exists(int addressId);
}