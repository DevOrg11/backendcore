using Clean.Domain;

namespace Clean.Application;

public interface IItemService
{
    List<Item> GetAllItems();
}