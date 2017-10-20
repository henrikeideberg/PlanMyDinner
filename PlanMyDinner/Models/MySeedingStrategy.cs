using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PlanMyDinner.Models
{
    /// <summary>
    /// Used to seed data in to the model/database when run for the first time.
    /// In this version of the application it is not possible to add recipes, hence the data
    /// seeded here is the data we have to work with.
    /// </summary>
    public class MySeedingStrategy : DropCreateDatabaseIfModelChanges<PlanMyDinnerDbContext>
    {
        protected override void Seed(PlanMyDinnerDbContext context)
        {
            //Create a bunch of recipes and seed in to database
            context.Recipes.Add(SeedingData.BroccolibiffarMedMosOchSallad.GetRecipe());
            context.Recipes.Add(SeedingData.KottbullarMedKramigPotatisOchAggsalladWokadeGronsaker.GetRecipe());
            context.Recipes.Add(SeedingData.PastaCarbonareMedSpenatOchTomat.GetRecipe());
            context.Recipes.Add(SeedingData.PizzaMedSkogschampinjonerOchDilligSallad.GetRecipe());
            context.Recipes.Add(SeedingData.PuckarMedHalloumiOchJalapeno.GetRecipe());
            context.Recipes.Add(SeedingData.PumparisottoMedGetost.GetRecipe());
            context.Recipes.Add(SeedingData.QuicheLorraineMedTomatsallad.GetRecipe());
            context.Recipes.Add(SeedingData.SotsaltKyckling.GetRecipe());
            context.Recipes.Add(SeedingData.StektKoljaMedRodbetssalladOchSenapssas.GetRecipe());
            context.Recipes.Add(SeedingData.StrimladKarreIDragonstektKålMedSenapshonung.GetRecipe());
            context.Recipes.Add(SeedingData.WokadGronkalMedIngefarOchRis.GetRecipe());
            base.Seed(context);
        }
    }
}