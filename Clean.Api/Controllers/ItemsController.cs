using Clean.Application;
using Clean.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Api;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }
        // GET: <ItemsController>
        [HttpGet]
        public ActionResult<List<Item>> Get()
        {
            var itemsFromService = _itemService.GetAllItems();
            return Ok(itemsFromService);
        }

    }
