using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanMyDinner
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                //Using TemplateFields in the GridView Control 
                // https://msdn.microsoft.com/en-us/library/bb288032.aspx
                RecipeGridView.DataSource = database.Recipes.ToList();
                RecipeGridView.DataBind();

                IngredientGridView.DataSource = database.Recipes.Find(1).Ingredients.ToList();
                IngredientGridView.DataBind();

                CategoryGridView.DataSource = database.Recipes.Find(1).Categories.ToList();
                CategoryGridView.DataBind();

                ContextGridView.DataSource = database.Recipes.Find(1).Contexts.ToList();
                ContextGridView.DataBind();

                ltInstructions.Text = database.Recipes.Find(1).Instructions;
            }
        }

        protected void RecipeGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get current user id from gridview
            int recipeId = (int)RecipeGridView.SelectedDataKey.Value;
            //perform a search by its primary key (User.ID)
            //the following line is equavalant to:
            //var user = ctx.Users.First(x=>x.ID == UserID)
            //var person = ctx.People.Find(personId);
            //Placing data from database on page
            //txtFName.Text = person.FirstName;
            //txtLName.Text = person.LastName;
            //txtEmail.Text = person.Email;
            //txtLine1.Text = person.Address.Line1;
            //txtLine2.Text = person.Address.Line2;
            //txtZIP.Text = person.Address.ZIP;
            //txtCity.Text = person.Address.City;
            //change button caption
            //btnSubmit.Text = "Edit";
        }
    }
}