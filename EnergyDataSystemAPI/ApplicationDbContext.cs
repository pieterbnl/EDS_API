using EnergyDataSystem.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        // Specific conventions can be added here
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {        
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    // DbSets for each table
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Building> Buildings { get; set; }
    public DbSet<BuildingGroup> BuildingGroups { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<EnergyMeter> EnergyMeters { get; set; }        
    public DbSet<Measurement> Measurements { get; set; }

    /*public DbSet<Contact> Contacts { get; set; }
    public DbSet<Email> Emails { get; set; }
    public DbSet<Phonenumber> Phonenumbers { get; set; }*/
}