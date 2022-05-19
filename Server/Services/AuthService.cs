using JWT.Algorithms;
using JWT.Builder;
using ZAI.Server.Database;
using ZAI.Shared.Database;

namespace ZAI.Server.Services;

public class AuthService
{
    private readonly IConfiguration _configuration;
    private readonly ZAIDbContext _dbContext;

    public AuthService(IConfiguration configuration, ZAIDbContext dbContext)
    {
        this._configuration = configuration;
        this._dbContext = dbContext;
    }

    public enum TokenType
    {
        Access = 0,
        Refresh = 1,
    }

    public string GenerateJWToken(User user, TokenType type = TokenType.Access)
    {
        var jwtToken = JwtBuilder.Create()
                       .WithAlgorithm(new HMACSHA256Algorithm())
                       .WithSecret(_configuration[type == TokenType.Access ? "secretkey" : "secretRefreshKey"])
                       .AddClaim("exp", DateTimeOffset.UtcNow.AddMinutes(Convert.ToDouble(_configuration[type == TokenType.Access ? "tokenMinuteTTL" : "tokenMinuteRefreshTTL"])).ToUnixTimeSeconds().ToString())
                       .AddClaim("id", user.Id)
                       .Encode();

        _dbContext.Tokens.Add(new Token
        {
            IsCanceled = false,
            Type = (int)type,
            BrowserAgent = "",
            IP = "",
            User = user,
            Value = jwtToken,
            Start = DateTime.Now,
            Expired = DateTime.Now.AddMinutes(Convert.ToDouble(_configuration[type == TokenType.Access ? "tokenMinuteTTL" : "tokenMinuteRefreshTTL"])),
        });
        _dbContext.SaveChanges();

        return jwtToken;
    }

    //public bool VerifyToken()
}
