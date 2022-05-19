namespace ZAI.Shared.Database;
public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    public DateTime AddTime { get; set; } = DateTime.Now;
    public virtual List<RoleLinks> RoleUsers { get; set; }

}
