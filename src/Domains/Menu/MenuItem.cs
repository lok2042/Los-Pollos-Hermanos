using Domains.Base;

namespace Domains.Menu;

public class MenuItem : BaseDomain
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; } = true;
    public int MenuCategoryId { get; set; }

    public virtual MenuCategory MenuCategory { get; set; }
}
