using Domains.Base;

namespace Domains.Menu;

public class MenuCategory : BaseDomain
{
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<MenuItem> MenuItems { get; set; }
}
