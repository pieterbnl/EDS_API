using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public class Contact
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Role { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }    
    public int AddressId { get; set; }    

    // Navigation properties
    public Owner Owner { get; set; }
    public Address Address { get; set; }    
    public ICollection<Email> Emails { get; set; } // Contact can have multiple email addresses
    public ICollection<Phonenumber> Phonenumbers { get; set; } // Contact can have multiple phonenumbers
    public ICollection<Building> Buildings { get; set; } // Contact can be contact for multiple buildings
}