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

public class SqlBuildingGroupRepository : IBuildingGroupRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public SqlBuildingGroupRepository(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<BuildingGroup>> GetBuildingGroupsAsync()
    {
        return await _context.BuildingGroups
            .Include(bg => bg.Buildings)
            .ToListAsync();
    }

    public async Task<BuildingGroup> GetBuildingGroupAsync(int buildingGroupId)
    {
        return await _context.BuildingGroups
            .Include(bg => bg.Buildings)
            .FirstOrDefaultAsync(bg => bg.Id == buildingGroupId);
    }

    public async Task<BuildingGroup> CreateBuildingGroupAsync(BuildingGroup buildingGroup)
    {
        var newBuildingGroup = await _context.BuildingGroups.AddAsync(buildingGroup);
        await _context.SaveChangesAsync();

        return newBuildingGroup.Entity;
    }

    public async Task<BuildingGroup> UpdateBuildingGroupAsync(int buildingGroupId, BuildingGroupCreationDTO buildingGroupCreationDTO)
    {
        var existingBuildingGroup = await GetBuildingGroupAsync(buildingGroupId);

        if (existingBuildingGroup == null)
        {
            return null;
        }
        else
        {
            existingBuildingGroup = _mapper.Map(buildingGroupCreationDTO, existingBuildingGroup);
            await _context.SaveChangesAsync();
        }

        return existingBuildingGroup;
    }

    public async Task<BuildingGroup> DeleteBuildingGroupAsync(int buildingGroupId)
    {
        var buildingGroupToDelete = await GetBuildingGroupAsync(buildingGroupId);

        if (buildingGroupToDelete == null)
        {
            return null;
        }
        else
        {
            _context.BuildingGroups.Remove(buildingGroupToDelete);
            await _context.SaveChangesAsync();
        }

        return buildingGroupToDelete;
    }

    /*public async Task<BuildingGroup> SoftDeleteBuildingGroupAsync(int buildingGroupId)
    {
        var buildingGroupToDelete = await GetBuildingGroupAsync(buildingGroupId);

        if (buildingGroupToDelete == null)
        {
            return null;
        }
        else
        {
            buildingGroupToDelete.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        return buildingGroupToDelete;
    }*/

    public async Task<bool> Exists(int buildingGroupId)
    {
        return await _context.BuildingGroups.AnyAsync(a => a.Id == buildingGroupId);
    }
}