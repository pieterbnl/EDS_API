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

public class SqlBuildingRepository : IBuildingRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public SqlBuildingRepository(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<List<Building>> GetBuildingsAsync()
    {
        return await _context.Buildings
            .Include(b => b.Address)
            .Include(b => b.BuildingGroup)
            .Include(b => b.BuildingGroup.Owner)
            .Include(b => b.EnergyMeters)
            .ToListAsync();
    }
    public async Task<Building> GetBuildingAsync(int buildingId)
    {
        return await _context.Buildings
            .Include(b => b.Address)
            .Include(b => b.BuildingGroup)
            .Include(b => b.BuildingGroup.Owner)
            .Include(b => b.EnergyMeters)
            .FirstOrDefaultAsync(b => b.Id == buildingId);
    }

    public async Task<Building> CreateBuildingAsync(Building building)
    {
        var newBuilding = await _context.Buildings.AddAsync(building);
        await _context.SaveChangesAsync();

        return newBuilding.Entity;
    }

    public async Task<Building> UpdateBuildingAsync(int buildingId, BuildingCreationDTO buildingCreationDTO)
    {
        var existingBuilding = await GetBuildingAsync(buildingId);

        if (existingBuilding == null)
        {
            return null;
        }
        else
        {
            existingBuilding = _mapper.Map(buildingCreationDTO, existingBuilding);
            await _context.SaveChangesAsync();
        }

        return existingBuilding;
    }

    public async Task<Building> DeleteBuildingAsync(int buildingId)
    {
        var buildingToDelete = await GetBuildingAsync(buildingId);

        if (buildingToDelete == null)
        {
            return null;
        }
        else
        {
            _context.Buildings.Remove(buildingToDelete);
            await _context.SaveChangesAsync();
        }

        return buildingToDelete;
    }

    /*public async Task<Building> SoftDeleteBuildingAsync(int buildingId)
    {
        var buildingToDelete = await GetBuildingsAsync(buildingId);

        if (buildingToDelete == null)
        {
            return null;
        }
        else
        {
            buildingToDelete.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        return buildingToDelete;
    }*/

    public async Task<bool> Exists(int buildingId)
    {
        return await _context.Buildings.AnyAsync(o => o.Id == buildingId);
    }
}