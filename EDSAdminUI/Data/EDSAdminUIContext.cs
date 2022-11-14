using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnergyDataSystem.Entities.Models;

namespace EDSAdminUI.Data
{
    public class EDSAdminUIContext : DbContext
    {
        public EDSAdminUIContext (DbContextOptions<EDSAdminUIContext> options)
            : base(options)
        {
        }

        public DbSet<EnergyDataSystem.Entities.Models.Address> Address { get; set; } = default!;
    }
}
