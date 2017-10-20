using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanMyDinner.Models
{
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