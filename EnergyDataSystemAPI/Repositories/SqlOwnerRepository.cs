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

public class SqlOwnerRepository : IOwnerRepository
{

    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public SqlOwnerRepository(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Owner>> GetOwnersAsync()
    {
        return await _context.Owners
            .Include(o => o.Address)
            .Include(o => o.BuildingGroups)
            .ToListAsync();
    }

    public async Task<Owner> GetOwnerAsync(int ownerId)
    {
        return await _context.Owners
            .Include(o => o.Address)
            .Include(o => o.BuildingGroups)
            .FirstOrDefaultAsync(o => o.Id == ownerId);
    }

    public async Task<Owner> CreateOwnerAsync(Owner owner)
    {
        var newOwner = await _context.Owners.AddAsync(owner);
        await _context.SaveChangesAsync();

        return newOwner.Entity;
    }

    public async Task<Owner> UpdateOwnerAsync(int ownerId, OwnerCreationDTO ownerCreationDTO)
    {
        var existingOwner = await GetOwnerAsync(ownerId);

        if (existingOwner == null)
        {
            return null;
        }
        else
        {
            existingOwner = _mapper.Map(ownerCreationDTO, existingOwner);
            await _context.SaveChangesAsync();
        }

        return existingOwner;
    }

    public async Task<Owner> DeleteOwnerAsync(int ownerId)
    {
        var ownerToDelete = await GetOwnerAsync(ownerId);

        if (ownerToDelete == null)
        {
            return null;
        }
        else
        {
            _context.Owners.Remove(ownerToDelete);
            await _context.SaveChangesAsync();
        }

        return ownerToDelete;
    }

    /*public async Task<Owner> SoftDeleteOwnerAsync(int ownerId)
    {
        var ownerToDelete = await GetOwnersAsync(ownerId);

        if (ownerToDelete == null)
        {
            return null;
        }
        else
        {
            ownerToDelete.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        return ownerToDelete;
    }*/

    public async Task<bool> Exists(int ownerId)
    {
        return await _context.Owners.AnyAsync(o => o.Id == ownerId);
    }
}