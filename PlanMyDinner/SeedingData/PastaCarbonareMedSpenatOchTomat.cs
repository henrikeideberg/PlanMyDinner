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
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Gul lök",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Bacon",
                        Quantity = 280,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Äggulor",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Creme fraiche",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Mjölk",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Peccorino ost",
                        Quantity = 60,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Tomat",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Spenat",
                        Quantity = 35,
                        Measure = EnumTypes.enumMeasure.gr
                    }
                },
                Instructions = "Koka pastan.Hacka lök.Skär bacon i mindre bitar och stek i smör tills det blir knaprigt.Blanda äggulor med creme fraiche, mjölk och ost.Häll av pastan och lägg tillbaka i grytan.Lägg i lök, bacon och äggkräm.Värm försiktigt så pastan krämar till sig. Smaka av med salt och peppar.Tärna tomaterna och blanda med spenat och olivolja.Servera.",
                Time = 30,
                ThumbFileName = "pasta-carbonara-med-spenat-och-tomat.jpg",
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Pork
                    },
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Pasta
                    }
                },
                Contexts = new List<Context>
                {
                    new Context
                    {
                        Name = EnumTypes.enumContext.Kids
                    },
                    new Context
                    {
                        Name = EnumTypes.enumContext.Weekdays
                    }
                }
            };
        }
    }
}