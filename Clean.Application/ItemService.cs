using Clean.Domain;

namespace Clean.Application;
public class ItemService : IItemService
{
    private readonly IItemRepository _itemRepository;

    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }
    public List<Item> GetAllItems()
    {
        var items = _itemRepository.GetAllItems();
        return items;
    }
}
