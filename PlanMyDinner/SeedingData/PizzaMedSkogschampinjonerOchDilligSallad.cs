using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class PizzaMedSkogschampinjonerOchDilligSallad
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Pizza med skogschampinjoner och dillig sallad",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name = "Vitkål",
                        Quantity = 400,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Citron",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Olja",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Dill",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Pizzadeg",
                        Quantity = 1,
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
                        Name = "Fänkål",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Skogschampinjoner",
                        Quantity = 250,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Spenat",
                        Quantity = 50,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Mozzarella",
                        Quantity = 150,
                        Measure = EnumTypes.enumMeasure.gr
                    }
                },
                Instructions = "Sätt ugn på 250 grader.Hyvla kålen med en osthyvel eller i en matberedare.Lägg i ett durkslag och häll kokande vatten över.Skölj sedan med iskallt vatten tills kålen svalnat.Låt rinna av medan du blandar ihop citronsaft, olja, salt, och svartpeppat.Klipp ner dillen och smaka av med mer kryddor.Rulla ut pizzadegen på plåt.Rör ihop creme fraiche med rivet citronskal, krydda med salt och peppar.Strimla fänkålen.Skiva svampen.Bred på creme fraiche och toppa pizzan med fänkål, svamp och speant.Avsluta med ost.Laga i ugn i ca tio minuter.Servera.",
                Time = 40,
                ThumbFileName = "hostpizza-med-skogschampinjoner-dillig-sallad.jpg",
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Pizza
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
                        Name = EnumTypes.enumContext.Party
                    },
                    new Context
                    {
                        Name = EnumTypes.enumContext.Starter
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