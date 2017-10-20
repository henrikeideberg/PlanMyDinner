using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class SotsaltKyckling
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Sötsalt kyckling",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name = "Kycklingbröstfile",
                        Quantity = 600,
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
                        Name = "Vitlök",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Japansk soja",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Mörk sirap",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Äggnudlar",
                        Quantity = 250,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Vitkål",
                        Quantity = 200,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Rödlök",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Sweet chili",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Ruccola",
                        Quantity = 35,
                        Measure = EnumTypes.enumMeasure.gr
                    }
                },
                Instructions = "Sätt ugnen på 200 grader.Salta och peppra kycklingen.Bryn dem i en stekpanna med smör.Lägg kycklingen i en ugnsfast form.Skala och hacka chilin.Skala och hacka vitlöken.Rör ihop chilin, vitlöken, soja och sirap.Håll såsen över kycklingen.Laga i ugn i 20minuter.Koka nudlar.Strimla kålen fint.Krama kålen med händerna så att den blir mjuk.Skala och strimla löken fint.Rör samman löken, kålen, sweet chilin och ruccola.Skiva kycklingen.Blanda nudlar med hälften av såsen och servera reseten av såsen till maten.",
                Time = 30,
                ThumbFileName = "sotsalt-kyckling.jpg",
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Chicken
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
                        Name = EnumTypes.enumContext.Weekdays
                    },
                    new Context
                    {
                        Name = EnumTypes.enumContext.Weekends
                    },
                    new Context
                    {
                        Name = EnumTypes.enumContext.Party
                    }
                }
            };
        }
    }
}