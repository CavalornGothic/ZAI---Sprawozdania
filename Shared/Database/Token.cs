using System.ComponentModel.DataAnnotations.Schema;

namespace ZAI.Shared.Database;

public class Token
{
    public int Id { get; set; }
    public string Value { get; set; }
    public int Type { get; set; }
    public int UserID { get; set; }
    [ForeignKey(nameof(UserID))]
    public virtual User User { get; set; }
    public bool IsCanceled { get; set; }
    public DateTime Start { get; set; }
    public DateTime Expired { get; set; }
    public string? IP { get; set; }
    public string? BrowserAgent { get; set; }
}
