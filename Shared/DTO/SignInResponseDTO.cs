using ZAI.Shared.Database;

namespace ZAI.Shared.DTO;

public class SignInResponseDTO
{
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
    public ICollection<string>? Roles { get; set; }
    public string? Message { get; set; }
}
