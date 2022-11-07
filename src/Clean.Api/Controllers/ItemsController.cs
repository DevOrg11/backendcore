using Clean.Application;
using Clean.Domain;

using Microsoft.AspNetCore.Mvc;

namespace Clean.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IItemService _itemService;
    public ItemsController(IItemService itemService)
    {
        _itemService = itemService;
    }

    /// <summary>
    /// Get All items
    /// </summary>
    /// <returns>All the items</returns>
    [HttpGet]
    public ActionResult<List<Item>> Get()
    {
        var itemsFromService = _itemService.GetAllItems();
        return Ok(itemsFromService);
    }

    /// <summary>
    /// Create a new item
    /// </summary>
    /// <param name="item"></param>
    /// <returns>Created item</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /Items
    ///     {
    ///         "name": "Blender",
    ///         "category": 1,
    ///         "amount": 1,
    ///         "description": "for parts",
    ///         "price": 4200,
    ///         "availability": 1
    ///     }
    ///
    /// </remarks>
    /// <response code="201">Returns the newly created item</response>
    /// <response code="400">If the item is null</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Item))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult PostItem(Item item)
    {
        var Item = _itemService.CreateItem(item);
        return Ok(item);
    }

}