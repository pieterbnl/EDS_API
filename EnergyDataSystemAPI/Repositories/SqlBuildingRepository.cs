using AutoMapper;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
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
        return await _context.Buildings.ToListAsync();
    }
    public Task<Building> GetBuildingAsync(int buildingId)
    {
        throw new NotImplementedException();
    }
       
    public Task<Building> CreateBuildingAsync(Building building)
    {
        throw new NotImplementedException();
    }

    public Task<Building> DeleteBuildingAsync(int buildingId)
    {
        throw new NotImplementedException();
    }    

    public Task<Building> UpdateBuildingAsync(int buildingId, BuildingCreationDTO buildingCreationDTO)
    {
        throw new NotImplementedException();
    }
}