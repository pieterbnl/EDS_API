using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public interface IEmailRepository
{
    Task<List<Email>> GetEmailAddressesAsync();
    Task<Email> GetEmailAddressAsync(int emailId);
    Task<Email> CreateEmailAddressAsync(Email emailAddress);
    Task<Email> UpdateEmailAddressAsync(int emailId, EmailCreationDTO emailCreationDTO);
    Task<Email> DeleteEmailAddressAsync(int emailId);
    //Task<Email> SoftDeleteEmailAddressAsync(int emailId);
    //Task<bool> Exists(int emailId);
}