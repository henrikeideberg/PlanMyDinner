using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanMyDinner.Models
{
    /// <summary>
    /// Enum type which lists different measures used in recipes.
    /// </summary>
    public class EnumTypes
    {
        public enum enumMeasure
        {
            st, //styck
            tsk,//tesked
            msk,//matsked
            krm,//kryddmått
            dl, //deciliter
            l,  //liter
            gr, //gram
            kg  //kilogram
        }

        /// <summary>
        /// Enum type which lists different applicable recipe-categories
        /// </summary>
        public enum enumCategory
        {
            Pork,
            Beef,
            Chicken,
            Fisk,
            Seafood,
            Vegetarian,
            Vegan,
            Pasta,
            Rice,
            Potato,
            Soup,
            Pizza
        }

        /// <summary>
        /// Enum type which lists different applicable contexts.
        /// </summary>
        public enum enumContext
        {
            Kids,
            Weekdays,
            Weekends,
            Party,
            Starter
        }
    }
}