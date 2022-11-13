using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystemAPI.Repositories.Contracts;

public interface IOwnerRepository
{
    Task<List<Owner>> GetOwnersAsync();
    Task<Owner> GetOwnerAsync(int ownerId);
    Task<Owner> CreateOwnerAsync(Owner owner);
    Task<Owner> UpdateOwnerAsync(int ownerId, OwnerCreationDTO ownerCreationDTO);
    Task<Owner> DeleteOwnerAsync(int ownerId);
    //Task<Building> SoftDeleteOwnerAsync(int ownerId);
    //Task<bool> Exists(int ownerId);
}