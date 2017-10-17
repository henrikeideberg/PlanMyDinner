using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class PastaCarbonareMedSpenatOchTomat
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Pasta carbonare med spenat och tomat",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name = "Spaghetti",
                        Quantity = 340,
                        Measure = "gram"
                    },
                    new Ingredient
                    {
                        Name = "YellowOnion Onion",
                        Quantity = 1,
                        Measure = "piece"
                    },
                    new Ingredient
                    {
                        Name = "Bacon",
                        Quantity = 280,
                        Measure = "gram"
                    }
                },
                Instructions = "Koka pastan<br>" +
                               "Hacka lök<br>" +
                               "Skär bacon i mindre bitar och stek i smör tills det blir knaprigt<br>" +
                               "Blanda äggulor med creme fraiche, mjölk och ost<br>" +
                               "etc etc",
                Time = 30,
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = "Pork"
                    },
                    new Category
                    {
                        Name = "Pasta"
                    }
                },
                Contexts = new List<Context>
                {
                    new Context
                    {
                        Name = "Kids"
                    },
                    new Context
                    {
                        Name = "Weekdays"
                    }
                }
            };
        }
    }
}