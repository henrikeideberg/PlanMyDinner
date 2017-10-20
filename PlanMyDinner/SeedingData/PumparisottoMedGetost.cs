using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanMyDinner.Models;

namespace PlanMyDinner.SeedingData
{
    public class PumparisottoMedGetost
    {
        public static Recipe GetRecipe()
        {
            return new Recipe
            {
                Name = "Pumparisotto med getost",
                Ingredients = new List<Ingredient>
                {
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
                        Name = "Grönsaksfond",
                        Quantity = 3,
                        Measure = EnumTypes.enumMeasure.msk
                    },
                    new Ingredient
                    {
                        Name = "Arborioris",
                        Quantity = 4,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Vitt matlagningsvin",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.dl
                    },
                    new Ingredient
                    {
                        Name = "Butternpumpa",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Getost",
                        Quantity = 140,
                        Measure = EnumTypes.enumMeasure.gr
                    },
                    new Ingredient
                    {
                        Name = "Gurka",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Fänkål",
                        Quantity = 1,
                        Measure = EnumTypes.enumMeasure.st
                    },
                    new Ingredient
                    {
                        Name = "Spenat",
                        Quantity = 50,
                        Measure = EnumTypes.enumMeasure.gr
                    }
                },
                Instructions = "Skala och hacka lök och vitlök.Stek i smör i en gryta på medelvärme utan att det tar färg.Värm upp vatten och fond i en gryta.Rör i riset i grytan med lök, låt det steka med under omrörning i ca 1 minut.Häll på det vita matlagningsvinet och låt det koka in under omrörning i ett par minuter.Börja sen skopa i buljongen.Låt den koka in och fyll sen på med mer tills riset är klart och mjukt.Skala och riv butternutpumpan grovt.Fräs den mjukt i en kastrull tillsammans med smör.När pumpan är så mjuk att den går att mosa, mixa den slät med en stavmixer.Smaka av med salt och svartpeppar.Rör ner pumpapurén i risotton, smaka av med mer salt och peppar.Om risotton blir för tjock, späd med mer buljong.Servera risotton toppad med smulad getost, gurkstrimlor, tunt skivad fänkål och spenat.",
                Time = 40,
                ThumbFileName = "a-pumparisotto-med-getost.jpg",
                Categories = new List<Category>
                {
                    new Category
                    {
                        Name = EnumTypes.enumCategory.Rice
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