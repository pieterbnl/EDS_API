using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public class SqlEmailRepository : IEmailRepository
{
    public Task<Email> CreateEmailAddressAsync(Email emailAddress)
    {
        throw new NotImplementedException();
    }

    public Task<Email> DeleteEmailAddressAsync(int emailId)
    {
        throw new NotImplementedException();
    }

    public Task<Email> GetEmailAddressAsync(int emailId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Email>> GetEmailAddressesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Email> UpdateEmailAddressAsync(int emailId, EmailCreationDTO emailCreationDTO)
    {
        throw new NotImplementedException();
    }
}