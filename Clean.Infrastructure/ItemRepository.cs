﻿using Clean.Domain;
using Clean.Application;

namespace Clean.Infrastructure;
public class ItemRepository: IItemRepository
{
    public static List<Item> items = new()
    {
        new Item{ ItemId = 01, Name = "Hair dryer", Category = CategoryList.Hair , amount = 1, Description = "Item in mint condition", Prise = 2500, Availability = Workflow.Available},
        new Item{ ItemId = 02, Name = "Frying Pan", Category = CategoryList.Kitchen , amount = 1, Description = "Almost brand new", Prise = 1500, Availability = Workflow.Available},
        new Item{ ItemId = 03, Name = "Lipstick kit", Category = CategoryList.Cosmetic , amount = 1, Description = "Item in mint condition", Prise = 1400, Availability = Workflow.Available},
        new Item{ ItemId = 04, Name = "Toaster", Category = CategoryList.Kitchen , amount = 1, Description = "Item in mint condition", Prise = 2300, Availability = Workflow.Available},
        new Item{ ItemId = 05, Name = "Blender", Category = CategoryList.Kitchen , amount = 1, Description = "Item in mint condition", Prise = 5600, Availability = Workflow.Available}
    };

        public List<Item> GetAllItems()
        {
            return items;
        }
}
