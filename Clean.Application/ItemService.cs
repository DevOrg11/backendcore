using Clean.Domain;

namespace Clean.Application;
public class ItemService : IItemService
{
    private readonly IItemRepository _itemRepository;

    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public Item CreateItem(Item item)
    {
        _itemRepository.CreateItem(item);
        return item;
    }

    public List<Item> GetAllItems()
    {
        var items = _itemRepository.GetAllItems();
        return items;
    }
}
