namespace Shared.Models;

public class BaseDomainViewModel
{
    public Guid Id { get; set; } 
    public string CreatedBy { get; set; } 
    public DateTime? CreatedAt { get; set; } 
    public string UpdatedBy { get; set; } 
    public DateTime? UpdatedAt { get; set; } 
}