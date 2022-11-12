using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystemAPI.Temp;
public class ContactCreationDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Role { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsDeleted { get; set; }
    public int OwnerId { get; set; }
    public int AddressId { get; set; }
}