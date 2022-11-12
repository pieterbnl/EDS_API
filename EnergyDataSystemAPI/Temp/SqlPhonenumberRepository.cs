using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystemAPI.Temp;

public class SqlPhonenumberRepository : IPhonenumberRepository
{
    public Task<Phonenumber> CreatePhonenumberAsync(Phonenumber phonenumber)
    {
        throw new NotImplementedException();
    }

    public Task<Phonenumber> DeletePhonenumberAsync(int phonenumberId)
    {
        throw new NotImplementedException();
    }

    public Task<Phonenumber> GetPhonenumberAsync(int phonenumberId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Phonenumber>> GetPhonenumbersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Phonenumber> UpdatePhonenumberAsync(int phonenumberId, PhonenumberCreationDTO phonenumberCreationDTO)
    {
        throw new NotImplementedException();
    }
}