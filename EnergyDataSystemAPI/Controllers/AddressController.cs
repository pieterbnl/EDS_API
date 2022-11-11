using AutoMapper;
using EnergyDataSystem;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EnergyDataSystemAPI.Controllers;

[ApiController]
[Route("api/addresses")]
public class AddressController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IAddressRepository _addressRepository;
    
    public AddressController(ApplicationDbContext _context, IMapper _mapper, IAddressRepository _addressRepository)
    {
        this._context = _context;
        this._mapper = _mapper;
        this._addressRepository = _addressRepository;
    }

    // GET api/addresses
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAddresses()
    {
        var addresses = await _addressRepository.GetAddressesAsync();

        return Ok(_mapper.Map<List<AddressDTO>>(addresses));
    }
}