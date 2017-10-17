using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanMyDinner.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public int Time { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Context> Contexts { get; set; }

        //Dictionary in Entity is not supported
        // One example implementation would be;
        // https://stackoverflow.com/questions/28949019/entity-framework-create-a-model-from-dictionarytkey-tvalue-to-be-mapped-to-a
        // but I prefer above data structure. Hope that is ok.

    }
}