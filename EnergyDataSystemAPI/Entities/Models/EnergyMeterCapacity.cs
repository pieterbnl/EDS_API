using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Entities.Models;
public enum EnergyMeterCapacity
{
    Elec_3x25A = 0,
    Elec_3x35A = 1,
    Elec_3x50A = 2,
    Elec_3x60A = 3,
    Elec_3x80A = 4,
    Gas_G4 = 5,
    Gas_G6 = 6,
    Water_QN15 = 7,
    Water_QN25 = 8,
    Water_QN35 = 9,
    Water_QN50 = 10,
    Water_QN100 = 11,
    Heat_100kW = 12,
    Heat_200kW = 13
}