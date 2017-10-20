using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PlanMyDinner
{
    public partial class _Default : Page
    {
        /// <summary>
        /// Func to include html-breaks in to a text/string.
        /// </summary>
        Func<string, string> addHtmlBreakTags = s => s.Replace(".", ".<br><br>");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//Prevent to GUI reset at reload
            {
                ClearAllGridviews();

                using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
                {
                    //Using TemplateFields in the GridView Control 
                    // https://msdn.microsoft.com/en-us/library/bb288032.aspx
                    UpdateRecipeGrid(database.Recipes);
                }
                ltRecipe.Text = "Showing all available recipes";
            }
        }

        /*************************************************************************
         * 
         *                          GUI update methods
         * 
         * ***********************************************************************/
        protected void ClearAllGridviews()
        {
            RecipeGridView.DataSource = null;
            RecipeGridView.DataBind();
            IngredientGridView.DataSource = null;
            IngredientGridView.DataBind();
            CategoryGridView.DataSource = null;
            CategoryGridView.DataBind();
            ContextGridView.DataSource = null;
            ContextGridView.DataBind();
            ltInstructions.Text = "Please select recipe to view recipe details.";
            Gv_imgs.DataSource = null;
            Gv_imgs.DataBind();
        }

        protected void UpdateReceipeDetailsGridViews(int recipeId)
        {
            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                IngredientGridView.DataSource = database.Recipes.Find(recipeId).Ingredients.ToList();
                IngredientGridView.DataBind();

                CategoryGridView.DataSource = database.Recipes.Find(recipeId).Categories.ToList();
                CategoryGridView.DataBind();

                ContextGridView.DataSource = database.Recipes.Find(recipeId).Contexts.ToList();
                ContextGridView.DataBind();

                ltInstructions.Text = addHtmlBreakTags(database.Recipes.Find(recipeId).Instructions);

                string CurrentDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
                string ImagePath = System.IO.Path.Combine(CurrentDir, "Media/" + database.Recipes.Find(recipeId).ThumbFileName);
                List<ListItem> Imgs = new List<ListItem>();
                string ImgName = Path.GetFileName(ImagePath);
                Imgs.Add(new ListItem(ImgName, "~/Media/" + ImgName));
                Gv_imgs.DataSource = Imgs;
                Gv_imgs.DataBind();
            }
        }

        protected void UpdateRecipeGrid(IQueryable<Models.Recipe> recipes)
        {
            RecipeGridView.DataSource = recipes.ToList();
            RecipeGridView.DataBind();
        }

        protected void SearchCleanUp(IQueryable<Models.Recipe> recipes)
        {
            ClearAllGridviews();
            UpdateRecipeGrid(recipes);
            ltRecipe.Text = "Showing result of search";
        }

        protected void RecipeGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int recipeId = (int)RecipeGridView.SelectedDataKey.Value;
            UpdateReceipeDetailsGridViews(recipeId);
        }

        /*************************************************************************
         * 
         *                         Button methods
         * 
         * ***********************************************************************/

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchInput.Text.Length > 1)
            {
                //Include search string in search/filter submit
                SearchIngredientAndRecipeNames(TextBoxSearchInput.Text);
            }
            else //Only look for the categories and contexts
            {
                SearchCategoriesAndContexts();
            }
        }

        protected void ButtonSetUnsetAllCategories_Click(object sender, EventArgs e)
        {
            if (CheckboxPork.Checked) UnSetAllCategoryCheckboxes();
            else SetAllCategoryCheckboxes();
        }

        protected void ButtonSetUnsetAllContexts_Click(object sender, EventArgs e)
        {
            if (CheckboxKids.Checked) UnSetAllContextCheckboxes();
            else SetAllContextCheckboxes();
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearAllGridviews();
            SetAllCheckBoxes();
            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                //Using TemplateFields in the GridView Control 
                // https://msdn.microsoft.com/en-us/library/bb288032.aspx
                RecipeGridView.DataSource = database.Recipes.ToList();
                RecipeGridView.DataBind();
            }
            ltRecipe.Text = "Showing all available recipes";
        }

        /*************************************************************************
         * 
         *                    Database/model search methods
         * 
         * ***********************************************************************/
        /// <summary>
        /// Method to search the database for recipes and/or ingrerdients matching the
        /// given search string. The search algortihm considers
        ///  - if checkbox 'Recipes' is checked - include only matches which include the search string in recipe name
        ///  - if checkbox 'Ingredients' is check - include only matches which include the search string in ingredient names
        ///  - if both checkboxs 'Recipes' and 'Ingredients' are checked - inlcude only matches which contain the search string in'
        ///    recipe name AND ingredient names.
        ///  - if neither checkbox 'Recipes' or 'Ingredients' are checked - the search result will be empty
        ///  
        /// The search algorithm also filters the search so that
        ///  - only selected categories are included in the search result
        ///  - only selected contextx are included in the search result
        /// https://stackoverflow.com/questions/16993962/searching-multiple-fields-with-linq-contains-or-other
        /// https://stackoverflow.com/questions/41333535/using-if-else-in-lambda-expression-in-where-clause
        /// https://stackoverflow.com/questions/3177113/lambda-expression-for-exists-within-list
        /// </summary>
        /// <param name="searchString"></param>
        protected void SearchIngredientAndRecipeNames(string searchString)
        {
            List<string> categories = GetCategories();
            List<string> contexts = GetContexts();

            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                var recipes = database.Recipes.Where(p =>
                ((categories.Count > 0 && p.Categories.Any(c => categories.Contains(c.Name.ToString()))) &&//filter selected categories
                (contexts.Count > 0 && p.Contexts.Any(c => contexts.Contains(c.Name.ToString())))) &&//filter selected categories
                ((CheckboxRecipe.Checked && p.Name.Contains(searchString)) ||//filter recipe name
                (CheckboxIngredient.Checked && p.Ingredients.Any(c => c.Name.Contains(searchString))))).Select(p => p);//filter ingredient names
                SearchCleanUp(recipes);
            }
        }

        /// <summary>
        /// Method to search the database for recipes matching the given categories and/or contexts.
        /// </summary>
        protected void SearchCategoriesAndContexts()
        {
            List<string> categories = GetCategories();
            List<string> contexts = GetContexts();

            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                var recipes = database.Recipes.Where(p =>
                (categories.Count > 0 && p.Categories.Any(c => categories.Contains(c.Name.ToString()))) &&
                (contexts.Count > 0 && p.Contexts.Any(c => contexts.Contains(c.Name.ToString())))).Select(p => p);
                SearchCleanUp(recipes);
            }
        }

        /*************************************************************************
         * 
         *                    Checkbox related methods
         * 
         * ***********************************************************************/

        protected List<string> GetContexts()
        {
            List<string> enums = new List<string>();

            if (CheckboxKids.Checked) enums.Add(Models.EnumTypes.enumContext.Kids.ToString());
            if (CheckboxWeekdays.Checked) enums.Add(Models.EnumTypes.enumContext.Weekdays.ToString());
            if (CheckboxWeekends.Checked) enums.Add(Models.EnumTypes.enumContext.Weekends.ToString());
            if (CheckboxParty.Checked) enums.Add(Models.EnumTypes.enumContext.Party.ToString());
            if (CheckboxStarter.Checked) enums.Add(Models.EnumTypes.enumContext.Starter.ToString());
            return enums;
        }

        protected List<string> GetCategories()
        {
            List<string> enums = new List<string>();

            if (CheckboxPork.Checked) enums.Add(Models.EnumTypes.enumCategory.Pork.ToString());
            if (CheckboxBeef.Checked) enums.Add(Models.EnumTypes.enumCategory.Beef.ToString());
            if (CheckboxChicken.Checked) enums.Add(Models.EnumTypes.enumCategory.Chicken.ToString());
            if (CheckboxFisk.Checked) enums.Add(Models.EnumTypes.enumCategory.Fisk.ToString());
            if (CheckboxSeafood.Checked) enums.Add(Models.EnumTypes.enumCategory.Seafood.ToString());
            if (CheckboxVegetarian.Checked) enums.Add(Models.EnumTypes.enumCategory.Vegetarian.ToString());
            if (CheckboxVegan.Checked) enums.Add(Models.EnumTypes.enumCategory.Vegan.ToString());
            if (CheckboxPasta.Checked) enums.Add(Models.EnumTypes.enumCategory.Pasta.ToString());
            if (CheckboxRice.Checked) enums.Add(Models.EnumTypes.enumCategory.Rice.ToString());
            if (CheckboxPotato.Checked) enums.Add(Models.EnumTypes.enumCategory.Potato.ToString());
            if (CheckboxSoup.Checked) enums.Add(Models.EnumTypes.enumCategory.Soup.ToString());
            if (CheckboxPizza.Checked) enums.Add(Models.EnumTypes.enumCategory.Pizza.ToString());
            return enums;
        }

        private void SetAllContextCheckboxes()
        {
            CheckboxKids.Checked = true;
            CheckboxWeekdays.Checked = true;
            CheckboxWeekends.Checked = true;
            CheckboxParty.Checked = true;
            CheckboxStarter.Checked = true;
        }

        private void UnSetAllContextCheckboxes()
        {
            CheckboxKids.Checked = false;
            CheckboxWeekdays.Checked = false;
            CheckboxWeekends.Checked = false;
            CheckboxParty.Checked = false;
            CheckboxStarter.Checked = false;
        }

        protected void SetAllCategoryCheckboxes()
        {
            CheckboxPork.Checked = true;
            CheckboxBeef.Checked = true;
            CheckboxChicken.Checked = true;
            CheckboxFisk.Checked = true;
            CheckboxSeafood.Checked = true;
            CheckboxVegetarian.Checked = true;
            CheckboxVegan.Checked = true;
            CheckboxPasta.Checked = true;
            CheckboxRice.Checked = true;
            CheckboxPotato.Checked = true;
            CheckboxSoup.Checked = true;
            CheckboxPizza.Checked = true;
        }

        protected void UnSetAllCategoryCheckboxes()
        {
            CheckboxPork.Checked = false;
            CheckboxBeef.Checked = false;
            CheckboxChicken.Checked = false;
            CheckboxFisk.Checked = false;
            CheckboxSeafood.Checked = false;
            CheckboxVegetarian.Checked = false;
            CheckboxVegan.Checked = false;
            CheckboxPasta.Checked = false;
            CheckboxRice.Checked = false;
            CheckboxPotato.Checked = false;
            CheckboxSoup.Checked = false;
            CheckboxPizza.Checked = false;
        }

        protected void SetAllCheckBoxes()
        {
            SetAllCategoryCheckboxes();
            SetAllContextCheckboxes();
        }
    }
}