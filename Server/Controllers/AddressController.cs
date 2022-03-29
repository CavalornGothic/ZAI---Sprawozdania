using Microsoft.AspNetCore.Mvc;
using ZAI.Server.Database;
using ZAI.Shared;

namespace ZAI.Server.Controllers;
[Route("api/address")]
[ApiController]
public class AddressController : ControllerBase
{
    private readonly ZAIDbContext _dbContext;

    public AddressController(ZAIDbContext dbContext)
    {
        this._dbContext = dbContext;
    }
    [Route("getall")]
    [HttpGet]
    public ICollection<AddressDTO> GetAllAddress()
    {
        ICollection<AddressDTO> _addressess = new List<AddressDTO>();
        foreach(var x in _dbContext.Adressess.Where(x => x.Id > 0))
        {
            _addressess.Add((AddressDTO)x);
        }
        return _addressess;
    }
}

