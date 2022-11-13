using AutoMapper;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using EnergyDataSystemAPI.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public class SqlMeasurementRepository : IMeasurementRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public SqlMeasurementRepository(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Measurement>> GetMeasurementsAsync()
    {
        return await _context.Measurements            
            .ToListAsync();
    }
    public async Task<Measurement> GetMeasurementAsync(int measurementId)
    {
        return await _context.Measurements            
            .FirstOrDefaultAsync(em => em.Id == measurementId);
    }

    public async Task<Measurement> CreateMeasurementAsync(Measurement measurement)
    {
        var newMeasurement = await _context.Measurements.AddAsync(measurement);
        await _context.SaveChangesAsync();

        return newMeasurement.Entity;
    }

    public async Task<Measurement> UpdateMeasurementAsync(int measurementId, MeasurementCreationDTO measurementCreationDTO)
    {
        var existingMeasurement = await GetMeasurementAsync(measurementId);

        if (existingMeasurement == null)
        {
            return null;
        }
        else
        {
            existingMeasurement = _mapper.Map(measurementCreationDTO, existingMeasurement);
            await _context.SaveChangesAsync();
        }

        return existingMeasurement;
    }

    public async Task<Measurement> DeleteMeasurementAsync(int measurementId)
    {
        var measurementToDelete = await GetMeasurementAsync(measurementId);

        if (measurementToDelete == null)
        {
            return null;
        }
        else
        {
            _context.Measurements.Remove(measurementToDelete);
            await _context.SaveChangesAsync();
        }

        return measurementToDelete;
    }

    /*public async Task<Measurement> SoftDeleteMeasurementAsync(int measurementId)
    {
        var measurementToDelete = await GetMeasurementAsync(measurementId);

        if (measurementToDelete == null)
        {
            return null;
        }
        else
        {
            measurementToDelete.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        return measurementToDelete;
    }*/

    public async Task<bool> Exists(int measurementId)
    {
        return await _context.Measurements.AnyAsync(em => em.Id == measurementId);
    }
}