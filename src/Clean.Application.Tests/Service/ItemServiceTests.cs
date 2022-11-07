using Clean.Domain;
using FakeItEasy;
using FluentAssertions;

namespace Clean.Application.Tests;

public class ItemServiceTests
{
    private readonly ItemService _itemService;
    private readonly IItemRepository _itemRepository;

    public ItemServiceTests()
    {
        //Dependancies
        _itemRepository = A.Fake<IItemRepository>();

        //SUT
        _itemService = new ItemService(_itemRepository);

    }

    [Fact]
    public void ItemService_GetAllItems_ReturnsSuccess()
    {   
        //TODO: Have items on a separate method. Not sure how to do this.
        var items = new List<Item>{

             new Item
             { 
                ItemId = 01, 
                Name = "Hair dryer", 
                Category = CategoryList.Hair , 
                amount = 1, 
                Description = "Item in mint condition", 
                Prise = 2500, 
                Availability = Workflow.Available
             }
        };

        A.CallTo(() => _itemRepository.GetAllItems()).Returns(items);

        var result = _itemService.GetAllItems();

        result.Should().BeOfType<List<Item>>();

    }

    [Fact]
    public void ItemService_GetAllItems_DoesntReturnEmptyObject()
    {
        _itemService.GetAllItems();

        A.CallTo(() => _itemRepository.GetAllItems()).MustHaveHappened();
    }

    [Fact]
    public void ItemService_CreateItem_ReturnsSuccess()
    {
        //Note: If I call the API with ItemId it will give error which wont show here as it needs to be tested on a db level
        var item = A.Fake<Item>();

        _itemService.CreateItem(item);

        A.CallTo(() => _itemRepository.CreateItem(item)).MustHaveHappened();
    }
}