using EnergyDataSystem.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystemAPI.Temp;

public class SqlContactRepository : IContactRepository
{
    public Task<Contact> CreateContactAsync(Contact contact)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> DeleteContactAsync(int contactId)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> GetContactAsync(int contactId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Contact>> GetContactsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Contact> UpdateContactAsync(int contactId, ContactCreationDTO contactCreationDTO)
    {
        throw new NotImplementedException();
    }
}