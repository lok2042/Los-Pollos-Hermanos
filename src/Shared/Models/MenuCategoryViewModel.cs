namespace Shared.Models;

public class MenuCategoryViewModel : BaseDomainViewModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<MenuItemViewModel> MenuItems { get; set; }
}
