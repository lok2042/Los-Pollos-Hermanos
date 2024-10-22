namespace Shared.Models;

public class MenuItemViewModel : BaseDomainViewModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; } = true;
    public Guid MenuCategoryId { get; set; }

    public virtual MenuCategoryViewModel MenuCategory { get; set; }
}