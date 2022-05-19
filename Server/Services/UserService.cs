using Microsoft.EntityFrameworkCore;
using ZAI.Server.Database;
using ZAI.Shared.Database;

namespace ZAI.Server.Services;

public class UserService
{
    private readonly ZAIDbContext _dbContext;

    public UserService(ZAIDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public ICollection<User>? GetUser()
    {
        var userData = _dbContext.Users
            .Include(rolelinks => rolelinks.RoleUsers)
                .ThenInclude(role => role.Role)
            .OrderBy(x => x.Id)
            .ToList();

        if (userData.Any())
            return userData;

        return null;
    }

    public User? GetUser(int id)
    {
        var userData = _dbContext.Users
           .Include(rolelinks => rolelinks.RoleUsers)
               .ThenInclude(role => role.Role)
           .Where(x => x.Id == id).ToList();

        if(userData.Any())
            return userData.First();

        return null;
    }

    public User? GetUser(string token)
    {
        var userData = _dbContext.Tokens
            .Where(x => x.IsCanceled == false && x.Value == token && x.Expired.Ticks >= DateTime.Now.Ticks)
            .Select(x => x.User);

        if (userData.Any())
            return userData.First();

        return null;
    }

    public ICollection<string>? GetUserRoles(int id)
    {
        var userData = _dbContext.Users
            .Where(x => x.Id == id)
            .Join(
                _dbContext.RolesLinks,
                user => user.Id,
                role => role.UserID,
                (user, role) => new
                {
                    RoleID = role.RoleID
                }
            )
            .Join(
                _dbContext.Roles,
                role => role.RoleID,
                role2 => role2.Id,
                (role, role2) => new
                {
                    RoleName = role2.Name
                }
            )
            .Select(x => x.RoleName)
            .ToList();

        if (userData.Any())
            return (ICollection<string>?)userData;

        return null;
    }
}
