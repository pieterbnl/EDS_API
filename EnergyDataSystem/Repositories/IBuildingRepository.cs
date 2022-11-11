using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public interface IBuildingRepository
{
    Task<List<Building>> GetBuildingsAsync();
    Task<Building> GetBuildingAsync(int buildingId);
    Task<Building> CreateBuildingAsync(Building building);
    Task<Building> UpdateBuildingAsync(int buildingId, BuildingCreationDTO buildingCreationDTO);
    Task<Building> DeleteBuildingAsync(int buildingId);
    //Task<Building> SoftDeleteBuildingAsync(int buildingId);
    //Task<bool> Exists(int buildingId);
}