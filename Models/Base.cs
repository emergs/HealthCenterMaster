using System.Data;

namespace HealthCenterMaster.Models;

public class Team
{
    public string? Image { get; set; }
    public string? Name { get; set; }
    public string? Specialty { get; set; }  
    public string? Phone { get; set; }
    public string? Email { get; set; }
}

public class News
{
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? Specialty { get; set; }  
    public string? Author { get; set; }
    public string? Author_Specialty { get; set; }
    public DateTime Data {get; set;}
    public string? Image { get; set; }
}