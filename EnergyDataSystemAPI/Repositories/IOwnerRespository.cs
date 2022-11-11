using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public interface IOwnerRepository
{
    Task<List<Owner>> GetContactsAsync();
    Task<Owner> GetContactAsync(int ownerId);
    Task<Owner> CreateContactAsync(Owner owner);
    Task<Owner> UpdateContactAsync(int ownerId, OwnerCreationDTO ownerCreationDTO);
    Task<Owner> DeleteContactAsync(int ownerId);
    //Task<Building> SoftDeleteOwnerAsync(int ownerId);
    //Task<bool> Exists(int ownerId);
}