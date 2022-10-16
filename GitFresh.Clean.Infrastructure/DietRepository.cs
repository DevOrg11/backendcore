using GitFresh.Clean.Application;
using GitFresh.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFresh.Clean.Infrastructure
{
    public class DietRepository : IDietRepository
    {

        public static List<Diet> diets = new()
        {

            new Diet{Id = 31, Quantity = 4, ItemId = 11, SubscriptionId = 0001},
            new Diet{Id = 32, Quantity = 2, ItemId = 13, SubscriptionId = 0001},
            new Diet{Id = 33, Quantity = 5, ItemId = 12, SubscriptionId = 0002},
            new Diet{Id = 41, Quantity = 6, ItemId = 21, SubscriptionId = 0001},
            new Diet{Id = 42, Quantity = 8, ItemId = 22, SubscriptionId = 0002},
            new Diet{Id = 43, Quantity = 7, ItemId = 23, SubscriptionId = 0001}

        };


        public static List<Vegetable> veges = new()
        {
            new Vegetable{VegetableId = 11, Name = "Carrot", GlycemicIndex = 67, Carbs = 34, Protein = 2},
            new Vegetable{VegetableId = 12, Name = "Tomato", GlycemicIndex = 24, Carbs = 15, Protein = 4},
            new Vegetable{VegetableId = 13, Name = "Potato", GlycemicIndex = 64, Carbs = 77, Protein = 1}
        };

        public static List<Meat> meats = new()
        {
            new Meat{MeatId = 21, Name = "Chicken", Protein = 92},
            new Meat{MeatId = 22, Name = "Fish", Protein = 87},
            new Meat{MeatId = 23, Name = "Beaf", Protein = 85}
        };


        public static List<Subscription> subs = new()
        {
            new Subscription{SubscriptionId = 0001, CustomerId = 1001, SubscriptionType = "Self", SubscribedDate = "07,07,2001" }
        };


        public List<Diet> GetAllDiet()
        {
            return diets;
        }

    }
}
