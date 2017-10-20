using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class WokadGronkalMedIngefarOchRis
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Wokad grönkål med ingefära och ris",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name = "Ris",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Morötter",
                        Quantity = 250,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Grönkål",
                        Quantity = 250,
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
                        Name = "Vitlök",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Ingefära",
                        Quantity = 30,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Röd chili",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Rapsolja",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Sesamolja",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Vitvinsvinäger",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Socker",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Soja",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Spenat",
                        Quantity = 100,
                        Measure = EnumTypes.enumMeasure.gr
                    }
                },
                Instructions = "Koka ris.Skala och strimla morötterna.Strimla grönkålen.Skala och strimla gul lök.Skala och riv vitlök och ingefära.Hacka chilin fint.Hetta upp rapsolja och sesamolja i en stekpanna och stek allt snabbt.Rör i vinäger, socker och soja.Servera med spenat.",
                Time = 40,
                ThumbFileName = "wokad-gronkal-med-ingerfara-och-ris.jpg",
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Rice
                    },
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Vegetarian
                    },
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Vegan
                    }
                },
                Contexts = new List<Context>
                {
                    new Context
                    {
                        Name = EnumTypes.enumContext.Starter
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