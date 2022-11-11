using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public interface IBuildingGroupRepository
{
    Task<List<BuildingGroup>> GetBuildingGroupsAsync();
    Task<BuildingGroup> GetBuildingGroupAsync(int buildingGroupId);
    Task<BuildingGroup> CreateBuildingGroupAsync(BuildingGroup buildingGroup);
    Task<BuildingGroup> UpdateBuildingGroupAsync(int buildingGroupId, BuildingGroupCreationDTO buildingGroupCreationDTO);
    Task<BuildingGroup> DeleteBuildingGroupAsync(int buildingGroupId);
    //Task<BuildingGroup> SoftDeleteBuildingGroupAsync(int buildingGroupId);
    //Task<bool> Exists(int buildingGroupId);
}