using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanMyDinner.Models
{
    public class Context
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Foreign key to Recipe. With this I am telling Recipe to be responsible for this child collection, i.e.
        /// when I save Recipe also Context should be saved in database.
        /// Also, when I remove item from collection and save Recipe, removed item will also be removed from database.
        /// </summary>
        public int RecipeId { get; set; }
    }
}