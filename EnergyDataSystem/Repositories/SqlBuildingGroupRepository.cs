using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public class SqlBuildingGroupRepository : IBuildingGroupRepository
{
    public Task<BuildingGroup> CreateBuildingGroupAsync(BuildingGroup buildingGroup)
    {
        throw new NotImplementedException();
    }

    public Task<BuildingGroup> DeleteBuildingGroupAsync(int buildingGroupdId)
    {
        throw new NotImplementedException();
    }

    public Task<BuildingGroup> GetBuildingGroupAsync(int buildingGroupId)
    {
        throw new NotImplementedException();
    }

    public Task<List<BuildingGroup>> GetBuildingGroupsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<BuildingGroup> UpdateBuildingGroupAsync(int buildingGroupId, BuildingGroupCreationDTO buildingGroupCreationDTO)
    {
        throw new NotImplementedException();
    }
}