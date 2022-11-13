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

public class SqlAddressRepository : IAddressRepository
{

    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public SqlAddressRepository(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Address>> GetAddressesAsync()
    {
        return await _context.Addresses
            .ToListAsync();
    }

    public async Task<Address> GetAddressAsync(int addressId)
    {
        return await _context.Addresses
            .FirstOrDefaultAsync(a => a.Id == addressId);
    }

    public async Task<Address> CreateAddressAsync(Address address)
    {
        var newAddress = await _context.Addresses.AddAsync(address);
        await _context.SaveChangesAsync();

        return newAddress.Entity;
    }

    public async Task<Address> UpdateAddressAsync(int addressId, AddressCreationDTO addressCreationDTO)
    {
        var existingAddress = await GetAddressAsync(addressId);

        if (existingAddress == null)
        {
            return null;
        }
        else
        {
            existingAddress = _mapper.Map(addressCreationDTO, existingAddress);
            await _context.SaveChangesAsync();
        }

        return existingAddress;
    }

    public async Task<Address> DeleteAddressAsync(int addressId)
    {
        var addressToDelete = await GetAddressAsync(addressId);

        if (addressToDelete == null)
        {
            return null;
        }
        else
        {
            _context.Addresses.Remove(addressToDelete);
            await _context.SaveChangesAsync();
        }

        return addressToDelete;
    }

    /*public async Task<Address> SoftDeleteAddressAsync(int addressId)
    {
        var addressToDelete = await GetAddressAsync(addressId);

        if (addressToDelete == null)
        {
            return null;
        }
        else
        {
            addressToDelete.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        return addressToDelete;
    }*/

    public async Task<bool> Exists(int addressId)
    {
        return await _context.Addresses.AnyAsync(a => a.Id == addressId);
    }
}