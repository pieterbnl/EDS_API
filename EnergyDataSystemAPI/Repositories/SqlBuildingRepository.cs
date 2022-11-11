using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public class SqlBuildingRepository : IBuildingRepository
{
    public Task<Building> CreateBuildingAsync(Building building)
    {
        throw new NotImplementedException();
    }

    public Task<Building> DeleteBuildingAsync(int buildingId)
    {
        throw new NotImplementedException();
    }

    public Task<Building> GetBuildingAsync(int buildingId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Building>> GetBuildingsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Building> UpdateBuildingAsync(int buildingId, BuildingCreationDTO buildingCreationDTO)
    {
        throw new NotImplementedException();
    }
}