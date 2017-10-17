using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PlanMyDinner.Models
{
    public class MySeedingStrategy : DropCreateDatabaseIfModelChanges<PlanMyDinnerDbContext>
    {
        protected override void Seed(PlanMyDinnerDbContext context)
        {
            //Create a bunch of recipes and seed in to database
            context.Recipes.Add(SeedingData.PastaCarbonareMedSpenatOchTomat.GetRecipe());
            base.Seed(context);
        }
    }
}