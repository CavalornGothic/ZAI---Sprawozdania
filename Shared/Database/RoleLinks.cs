using System.ComponentModel.DataAnnotations.Schema;

namespace ZAI.Shared.Database;
public class RoleLinks
{
    public int Id { get; set; }
    public int UserID { get; set; }
    [ForeignKey(nameof(UserID))]
    public virtual User User { get; set; }
    public int RoleID { get; set; }
    [ForeignKey(nameof(RoleID))]
    public virtual Role Role { get; set; }
}
