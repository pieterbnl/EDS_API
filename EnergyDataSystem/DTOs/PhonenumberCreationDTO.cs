using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;
public class PhonenumberCreationDTO
{
    public int Id { get; set; }
    public string TypeOfPhonenumber { get; set; }
    public string Description { get; set; }
    public string Number { get; set; }
    public int ContactId { get; set; }
}