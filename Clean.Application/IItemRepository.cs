using Clean.Domain;

namespace Clean.Application;

public interface IItemRepository
{
    List<Item> GetAllItems();
}