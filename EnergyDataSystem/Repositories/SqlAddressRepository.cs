using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public class SqlAddressRepository : IAddressRepository
{
    public Task<Address> CreateAddressAsync(Address address)
    {
        throw new NotImplementedException();
    }

    public Task<Address> DeleteAddressAsync(int addressId)
    {
        throw new NotImplementedException();
    }

    public Task<Address> GetAddressAsync(int addressId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Address>> GetAddressesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Address> UpdateAddressAsync(int addressId, AddressCreationDTO addressCreationDTO)
    {
        throw new NotImplementedException();
    }
}