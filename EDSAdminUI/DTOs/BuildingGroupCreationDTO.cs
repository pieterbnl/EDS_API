﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;

public class BuildingGroupCreationDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int OwnerId { get; set; }    
}