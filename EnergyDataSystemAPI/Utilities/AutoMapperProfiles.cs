using AutoMapper;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDataSystem.Utilities;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {        
        CreateMap<Address, AddressDTO>()
            .ReverseMap();

        CreateMap<Owner, OwnerDTO>()
            .ReverseMap();
        /*.ForMember(dto => dto.BuildingGroups,
           ent => ent.MapFrom(p => p.BuildingGroups
           .OrderByDescending(b => b.Name)));*/

        CreateMap<BuildingGroup, BuildingGroupDTO>()
            .ReverseMap();
        
        CreateMap<Building, BuildingDTO>()
            .ReverseMap();        

        CreateMap<EnergyMeter, EnergyMeterDTO>()
            .ReverseMap();

        CreateMap<Measurement, MeasurementDTO>()
            .ReverseMap();

        /*CreateMap<Contact, ContactDTO>()
            .ReverseMap();

        CreateMap<Email, EmailDTO>()
            .ReverseMap();

        CreateMap<Phonenumber, PhonenumberDTO>()
            .ReverseMap();*/

        CreateMap<AddressCreationDTO, Address>();
        CreateMap<BuildingCreationDTO, Building>();
        CreateMap<BuildingGroupCreationDTO, BuildingGroup>();        
        CreateMap<EnergyMeterCreationDTO, EnergyMeter>();
        CreateMap<OwnerCreationDTO, Owner>();
        CreateMap<MeasurementCreationDTO, Measurement>();

        /*CreateMap<ContactCreationDTO, Contact>();
        CreateMap<EmailCreationDTO, Email>();
        CreateMap<PhonenumberCreationDTO, Phonenumber>();*/
    }
}