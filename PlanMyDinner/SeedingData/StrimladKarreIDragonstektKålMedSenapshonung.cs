using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class StrimladKarreIDragonstektKålMedSenapshonung
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Strimlad karré i dragonstekt kål med senapshonung",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name = "Pasta",
                        Quantity = 340,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Karré",
                        Quantity = 600,
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
                        Name = "Vitkål",
                        Quantity = 200,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Äpple",
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
                        Name = "Dragon",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.tsk
                    },
                    new Ingredient
                    {
                        Name = "Dijonsenap",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.tsk
                    },
                    new Ingredient
                    {
                        Name = "Honung",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.tsk
                    },
                    new Ingredient
                    {
                        Name = "Citron",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Vatten",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.dl
                    }
                },
                Instructions = "Koka pastan.Strimla köttet fint.Strimla skalad lök.Strimla skalad kål.Skiva äpplet.Skala vitlöken.Hetta upp stekpanna med smör.Stek köttet tillsammans med salt och peppar.Rör i lök, kål, sallad, pressad vitlök, äpple, dragon, senap och honung.Stek i ett par minuter till.Pressa över citron och rör ner vatten.Servera",
                Time = 30,
                ThumbFileName = "e-strimlad-karre-i-ljummen-sallad.jpg",
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
                        Name = EnumTypes.enumContext.Weekdays
                    },
                    new Context
                    {
                        Name = EnumTypes.enumContext.Weekends
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