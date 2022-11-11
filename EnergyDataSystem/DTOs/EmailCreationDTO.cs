﻿using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.DTOs;
public class EmailCreationDTO
{
    public int Id { get; set; }
    public string Address { get; set; }
    public int ContactId { get; set; }
}