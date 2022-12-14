using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Repositories;

public interface IPhonenumberRepository
{
    Task<List<Phonenumber>> GetPhonenumbersAsync();
    Task<Phonenumber> GetPhonenumberAsync(int phonenumberId);
    Task<Phonenumber> CreatePhonenumberAsync(Phonenumber phonenumber);
    Task<Phonenumber> UpdatePhonenumberAsync(int phonenumberId, PhonenumberCreationDTO phonenumberCreationDTO);
    Task<Phonenumber> DeletePhonenumberAsync(int phonenumberId);
    //Task<Phonenumber> SoftDeleteEmailAddressAsync(int emailId);
    //Task<bool> Exists(int emailId);
}