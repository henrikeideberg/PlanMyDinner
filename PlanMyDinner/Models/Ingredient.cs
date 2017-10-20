using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanMyDinner.Models
{
    /// <summary>
    /// Class to describe the ingredients included in a recipe
    /// </summary>
    public class Ingredient
    {
        //Composite key
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public EnumTypes.enumMeasure Measure { get; set; }
        public string IngredientToString()
        {
            return "string";//TBD how to format string nicely?
        }
        /// <summary>
        /// Foreign key to Recipe. With this I am telling Recipe to be responsible for this child collection, i.e.
        /// when I save Recipe also Ingredient should be saved in database.
        /// Also, when I remove item from collection and save Recipe, removed item will also be removed from database.
        /// </summary>
        public int RecipeId { get; set; }
    }
}