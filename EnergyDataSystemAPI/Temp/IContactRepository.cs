using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystemAPI.Temp;

public interface IContactRepository
{
    Task<List<Contact>> GetContactsAsync();
    Task<Contact> GetContactAsync(int contactId);
    Task<Contact> CreateContactAsync(Contact contact);
    Task<Contact> UpdateContactAsync(int contactId, ContactCreationDTO contactCreationDTO);
    Task<Contact> DeleteContactAsync(int contactId);
    //Task<Building> SoftDeleteContactAsync(int contactId);
    //Task<bool> Exists(int contactId);
}