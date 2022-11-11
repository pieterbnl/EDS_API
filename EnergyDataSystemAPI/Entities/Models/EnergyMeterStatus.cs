using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;

public enum EnergyMeterStatus
{
    ToBeInstalled = 0,
    Installed = 1,
    Active = 2,    
    Broken = 3,
    Disabled = 4
}