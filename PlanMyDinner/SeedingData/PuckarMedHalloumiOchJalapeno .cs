using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class PuckarMedHalloumiOchJalapeno
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Puckar med halloumi och jalapeno",
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
                        Name = "Olja",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Halloumi",
                        Quantity = 200,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Morötter",
                        Quantity = 250,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Ägg",
                        Quantity = 2,
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
                        Name = "Jalapeno",
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
                        Name = "Röd lök",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Avokado",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Yoghurt",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Majonnär",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Chilisås",
                        Quantity = 2,
                        Measure = EnumTypes.enumMeasure.msk
                    }
                },
                Instructions = "Sätt ugn på 250 grader.Tvätta och klyfta potatisen.Lägg potatisen på en plåt, ringla över olja och salt.Laga i ugnen i ca 30min.Riv ner halloumi i en bunke.Skala och riv morötterna.Knäck ner äggen och rör ner ströbröd, smaka av med salt och hackad jalapeno.Låt stå i 5 minuter innan du formar till puckar och steker i smör.Strimla salladen.Skala och strimla löken.Hacka jalapenos.Tärna avokado. Blanda salladen, löken, jalapenos och avokado i en skål.Blanda samman yoghurt med majonnäs, chilisås och smaka av med salt.Servera.",
                Time = 40,
                ThumbFileName = "puckar-med-halloumi-och-jalapeno.jpg",
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
                        Name = EnumTypes.enumContext.Weekdays
                    }
                }
            };
        }
    }
}