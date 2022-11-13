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

public class SqlEnergyMeterRepository : IEnergyMeterRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public SqlEnergyMeterRepository(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<EnergyMeter>> GetEnergyMetersAsync()
    {
        return await _context.EnergyMeters
            .Include(em => em.Building)
            .Include(em => em.Measurements)
            .ToListAsync();
    }
    public async Task<EnergyMeter> GetEnergyMeterAsync(int energyMeterId)
    {
        return await _context.EnergyMeters
            .Include(em => em.Building)
            .Include(em => em.Measurements)
            .FirstOrDefaultAsync(em => em.Id == energyMeterId);
    }

    public async Task<EnergyMeter> CreateEnergyMeterAsync(EnergyMeter energyMeter)
    {
        var newEnergyMeter = await _context.EnergyMeters.AddAsync(energyMeter);
        await _context.SaveChangesAsync();

        return newEnergyMeter.Entity;
    }

    public async Task<EnergyMeter> UpdateEnergyMeterAsync(int energyMeterId, EnergyMeterCreationDTO energyMeterCreationDTO)
    {
        var existingEnergyMeter = await GetEnergyMeterAsync(energyMeterId);

        if (existingEnergyMeter == null)
        {
            return null;
        }
        else
        {
            existingEnergyMeter = _mapper.Map(energyMeterCreationDTO, existingEnergyMeter);
            await _context.SaveChangesAsync();
        }

        return existingEnergyMeter;
    }

    public async Task<EnergyMeter> DeleteEnergyMeterAsync(int energyMeterId)
    {
        var energyMeterToDelete = await GetEnergyMeterAsync(energyMeterId);

        if (energyMeterToDelete == null)
        {
            return null;
        }
        else
        {
            _context.EnergyMeters.Remove(energyMeterToDelete);
            await _context.SaveChangesAsync();
        }

        return energyMeterToDelete;
    }

    /*public async Task<EnergyMeter> SoftDeleteEnergyMeterAsync(int energyMeterId)
    {
        var energyMeterToDelete = await GetEnergyMeterAsync(energyMeterId);

        if (energyMeterToDelete == null)
        {
            return null;
        }
        else
        {
            energyMeterToDelete.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        return energyMeterToDelete;
    }*/

    public async Task<bool> Exists(int energyMeterId)
    {
        return await _context.EnergyMeters.AnyAsync(em => em.Id == energyMeterId);
    }
}