using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class QuicheLorraineMedTomatsallad
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Quiche Lorraine med tomatsallad",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name = "Vetemjöl",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Smör",
                        Quantity = 125,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Kallt vatten",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Ägg",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Mjölk",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Skinka",
                        Quantity = 180,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Röd lök",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Ost",
                        Quantity = 150,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Tomater",
                        Quantity = 4,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Ruccola",
                        Quantity = 35,
                        Measure = EnumTypes.enumMeasure.gr
                    }
                },
                Instructions = "Sätt ugn på 250 grader.Arbeta samman mjöl, smör och vatten till en deg. Tryck ut den i en pajform.Tryck fast remsor av aluminiumfolie på kanterna så att degen inte sjunker ner vid gräddning.Picka botten med en gaffel.Förgrädda i ugn i 10min.Sänk ugn till 200 grader.Gör fyllningen.Vispa ihop ägg, mjölk och smaksätt med salt och peppar.Blanda skinka, halv skalad och strimlad lök, ost och lägg allt i pajskalet. Häll över äggstanningen.Grädda i mitten i ugnen i 30min tills fyllningen stannat.Tärna tomaterna, hacka halv röd lök, lägg dem i skål och rör ner ruccola.Servera",
                Time = 60,
                ThumbFileName = "quiche-lorraine-med-tomatsallad.jpg",
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Pork
                    },
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Pizza
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
                        Name = EnumTypes.enumContext.Starter
                    },
                    new Context
                    {
                        Name = EnumTypes.enumContext.Kids
                    }
                }
            };
        }
    }
}