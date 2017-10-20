using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class KottbullarMedKramigPotatisOchAggsalladWokadeGronsaker
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Köttbullar med krämig potatis och äggsallad, wokade grönsaker",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name = "Potatis",
                        Quantity = 800,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Ägg",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Majonnäs",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Gräddfil",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Cayennepeppar",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.krm
                    },
                    new Ingredient
                    {
                        Name = "Curry",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.krm
                    },
                    new Ingredient
                    {
                        Name = "Mjölk",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Ströbröd",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Blandfärs",
                        Quantity = 600,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Gul lök",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Broccoli",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Paprika",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Olivolja",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    }
                },
                Instructions = "Tvätta och tärna potatisen.Koka potatisen mjuk.Koka äggen minst 7 minuter.Skölj äggen och hacka dem.Rör ihop majonnäs, gräddfil,cayennepeppar och curry.Rör i hackat ägg och potatis och låt stå.Blanda samman mjölk och ströbröd, låt stå i 5 minuter.Blanda med färs, salt, peppar, skalad och en riven gul lök. Rulla köttbullar och stek dem i smör.Skala och strimla löken.Dela broccolin i buketter, dela stammen.Strimla paprikan.Hetta upp olja i en stekpanna och woka alla grönsaker.Servera.",
                Time = 40,
                ThumbFileName = "kottbullar-med-kramig-potatis-och-aggsallad-wokade-gronsaker.jpg",
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Pork
                    },
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Beef
                    },
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Potato
                    }
                },
                Contexts = new List<Context>
                {
                    new Context
                    {
                        Name = EnumTypes.enumContext.Weekdays
                    },
                    new Context
                    {
                        Name = EnumTypes.enumContext.Kids
                    },
                    new Context
                    {
                        Name = EnumTypes.enumContext.Weekends
                    }
                }
            };
        }
    }
}