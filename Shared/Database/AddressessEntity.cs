namespace ZAI.Shared.Database;

public class AddressessEntity
{
    public int Id { get; set; }
    public string ZipCode { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string District { get; set; }

    public static explicit operator AddressDTO(AddressessEntity address)
    {
        return new AddressDTO
        {
            ID = address.Id,
            Address = address.Address,
            City = address.City,
            Province = address.Province,
            District = address.District,
            ZipCode = address.ZipCode
        };
    }
}
