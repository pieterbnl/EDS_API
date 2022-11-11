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
        return await _context.Addresses.ToListAsync();
    }

    public Task<Address> GetAddressAsync(int addressId)
    {
        throw new NotImplementedException();
    }
    public Task<Address> CreateAddressAsync(Address address)
    {
        throw new NotImplementedException();
    }

    public Task<Address> DeleteAddressAsync(int addressId)
    {
        throw new NotImplementedException();
    }
    public Task<Address> UpdateAddressAsync(int addressId, AddressCreationDTO addressCreationDTO)
    {
        throw new NotImplementedException();
    }
}