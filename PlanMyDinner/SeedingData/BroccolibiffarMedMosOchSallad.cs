using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class BroccolibiffarMedMosOchSallad
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Broccolibiffar med mos och sallad",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name = "Potatis",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.kg
                    },
                    new Ingredient
                    {
                        Name = "Mjölk",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Broccoli",
                        Quantity = 500,
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
                        Name = "Ströbröd",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Riven ost",
                        Quantity = 150,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Chiliflakes",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.krm
                    },
                    new Ingredient
                    {
                        Name = "Vitlök",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Romansallad",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Körsbärstomat",
                        Quantity = 250,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Gurka",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    }
                },
                Instructions = "Skala och koka potatisen.Dela och koka broccolin i några minuter.Häll av vattnet och grovhacka ner broccolin i en skål.Vispa äggen med en gaffel och vänd ner i broccoliskålen.Rör ner ströbröd, riven ost, chiliflakes, salt, skalad och riven lök.Klicka ut biffar i en stekpanna med smör.Stek tills de stelnar och har fin färg.Mosa och vispa potatisen fluffig tillsammans med smör och mjölk.Smaka av med salt och peppar.Strimla salladen.Dela tomaterna.Tärna gurkan.Blanda allt i en skål.Servera med mos.",
                Time = 40,
                ThumbFileName = "broccolibiffar-med-mos-och-sallad.jpg",
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Potato
                    },
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Vegetarian
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