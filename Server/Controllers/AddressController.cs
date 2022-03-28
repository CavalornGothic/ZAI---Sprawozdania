using Microsoft.AspNetCore.Mvc;
using ZAI.Server.DTO;

namespace ZAI.Server.Controllers;
[Route("api/address")]
[ApiController]
public class AddressController : ControllerBase
{
    [Route("getall")]
    [HttpGet]
    public ICollection<AddressDTO> GetAllAddress()
    {
        ICollection<AddressDTO> addresses = new List<AddressDTO>();
        addresses.Add(new AddressDTO { City = "Warszawa", District = "Warszawa", Province = "Mazowieckie", Address = "Słoneczna 1", ZipCode = "00-001" });
        addresses.Add(new AddressDTO { City = "Poznań", District = "Poznań", Province = "Wielkopolskie", Address = "Słoneczna 2", ZipCode = "00-002" });
        addresses.Add(new AddressDTO { City = "Kraków", District = "Kraków", Province = "Małopolskie", Address = "Słoneczna 3", ZipCode = "00-003" });
        addresses.Add(new AddressDTO { City = "Gorzów Wielkopolski", District = "Gorzowski", Province = "Lubuskie", Address = "Słoneczna 4", ZipCode = "00-004" });
        addresses.Add(new AddressDTO { City = "Drezdenko", District = "Strzelecko-Drezdenecki", Province = "Lubuskie", Address = "Słoneczna 5", ZipCode = "00-005" });
        addresses.Add(new AddressDTO { City = "Strzelce Krajeńskie", District = "Strzelecko-Drezdenecki", Province = "Lubuskie", Address = "Słoneczna 6", ZipCode = "00-006" });
        addresses.Add(new AddressDTO { City = "Dobiegniew", District = "Strzelecko-Drezdenecki", Province = "Lubuskie", Address = "Słoneczna 7", ZipCode = "00-007" });
        addresses.Add(new AddressDTO { City = "Trzcianka", District = "Czarnkowsko-Trzcianecki", Province = "Wielkopolska", Address = "Słoneczna 8", ZipCode = "00-008" });
        addresses.Add(new AddressDTO { City = "Czarnków", District = "Czarnkowsko-Trzcianecki", Province = "Wielkopolska", Address = "Słoneczna 9", ZipCode = "00-009" });
        addresses.Add(new AddressDTO { City = "Piła", District = "Pilski", Province = "Wielkopolska", Address = "Słoneczna 10", ZipCode = "00-010" });
        return addresses;
    }
}

