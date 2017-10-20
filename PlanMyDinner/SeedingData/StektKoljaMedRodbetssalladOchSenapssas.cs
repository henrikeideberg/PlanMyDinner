using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class StektKoljaMedRodbetssalladOchSenapssas
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Stekt kolja med rödbetssallad och senapssås",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name = "Rödbetor",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.kg
                    },
                    new Ingredient
                    {
                        Name = "Röd lök",
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
                        Name = "Olivolja",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Mjölk",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Maizena",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.tsk
                    },
                    new Ingredient
                    {
                        Name = "Senap",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Kolja",
                        Quantity = 500,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Ströbröd",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Ägg",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Citron",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Sallad",
                        Quantity = 70,
                        Measure = EnumTypes.enumMeasure.gr
                    }
                },
                Instructions = "Sätt ugn på 225 grader.Skala och klyfta rödbetorna.Skala och klyfta löken.Rör ihop skalad och pressad vitlök, olja och salt.Blanda med rödbetorna och löken.Laga i ugnen i 30min.Koka upp mjölk och red sedan med maizena.Smaka av med senap, salt och vitpeppar.Skär fisken i portionsbitar.Blanda samman salt, vitpeppar och ströbröd.Vispa upp ägget på ett fat.Doppa fisken först i ägg sedan i ströbröd.Stek fisken krispig i olja och smör.Servera med pressad citron och sallad",
                Time = 40,
                ThumbFileName = "stekt-kolja-med-rodbetssallad-och-senapssas.jpg",
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Fisk
                    }
                },
                Contexts = new List<Context>
                {
                    new Context
                    {
                        Name = EnumTypes.enumContext.Weekdays
                    }
                }
            };
        }
    }
}