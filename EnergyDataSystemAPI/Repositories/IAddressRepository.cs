using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public interface IAddressRepository
{
    Task<List<Address>> GetAddressesAsync();
    Task<Address> GetAddressAsync(int addressId);
    Task<Address> CreateAddressAsync(Address address);
    Task<Address> UpdateAddressAsync(int addressId, AddressCreationDTO addressCreationDTO);
    Task<Address> DeleteAddressAsync(int addressId);
    //Task<Address> SoftDeleteAddressAsync(int addressId);
    //Task<bool> Exists(int addressId);
}