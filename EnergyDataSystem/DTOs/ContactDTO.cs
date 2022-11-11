using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;
public class ContactDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Role { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsDeleted { get; set; }
    public int OwnerId { get; set; }
    public int AddressId { get; set; }
    public OwnerDTO Owner { get; set; }
    public AddressDTO Address { get; set; }
    public ICollection<EmailDTO> Emails { get; set; } // Contact can have multiple email addresses
    public ICollection<PhonenumberDTO> Phonenumbers { get; set; } // Contact can have multiple phonenumbers
    public ICollection<BuildingDTO> Buildings { get; set; } // Contact can be contact for multiple buildings
}