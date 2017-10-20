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
        Func<string, string> addHtmlBreakTags = s => s.Replace(".", ".<br><br>");
        Action<object> updateGui;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearGui();

                using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
                {
                    //Using TemplateFields in the GridView Control 
                    // https://msdn.microsoft.com/en-us/library/bb288032.aspx
                    RecipeGridView.DataSource = database.Recipes.ToList();
                    RecipeGridView.DataBind();
                }
                ltRecipe.Text = "Showing all available recipes";
            }
        }

        protected void ClearGui()
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

        protected void UpdateGui(int recipeId)
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

        protected void UpdatedRecipeGrid(IQueryable<Models.Recipe> recipes)
        {
            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                RecipeGridView.DataSource = recipes.ToList();
                RecipeGridView.DataBind();
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string searchInput;
            Action<string> search;
            if (TextBoxSearchInput.Text.Length > 1)
            {
                searchInput = TextBoxSearchInput.Text;
                if (CheckboxRecipe.Checked && CheckboxIngredient.Checked)
                    search = SearchIngredientAndRecipeNames;
                else if (CheckboxRecipe.Checked)
                    search = SearchRecipeNames;
                else if (CheckboxIngredient.Checked)
                    search = SearchIngredientNames;
                else
                    search = SearchIngredientAndRecipeNames;
            }
            else //Only look for the categories and contexts
            {
                searchInput = "";
                search = DoSomethingElse;
            }
            search(searchInput);
        }

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

        protected void SearchCleanUp(IQueryable<Models.Recipe> recipes)
        {
            ClearGui();
            UpdatedRecipeGrid(recipes);
            ltRecipe.Text = "Showing result of search";
        }

        protected void SearchRecipeNames(string searchString)
        {
            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                var recipes = from x in database.Recipes where x.Name.Contains(searchString) select x;
                SearchCleanUp(recipes);
            }
        }

        protected void SearchIngredientNames(string searchString)
        {
            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                var recipes = database.Recipes.Where(p => p.Ingredients.Any(c => c.Name.Contains(searchString))).Select(p => p);
                SearchCleanUp(recipes);
            }
        }

        protected void SearchIngredientAndRecipeNames(string searchString)
        {
            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                var recipes = database.Recipes.Where(p => p.Name.Contains(searchString)).Select(p => p);
                var ingredients = database.Recipes.Where(p => p.Ingredients.Any(c => c.Name.Contains(searchString))).Select(p => p);
                var combined = recipes.Union(ingredients);//Union is a set operation - it returns distinct values.
                SearchCleanUp(combined);
            }
        }

        protected void DoSomethingElse(string emptystring)
        {
            List<string> categories = GetCategories();
            List<string> contexts = GetContexts();

            if(categories.Count > 0)
            {
                using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
                {
                    var categorySearchResult = database.Recipes.Where(p => p.Categories.Any(c => c.Name.ToString().Equals("invalid"))).Select(p => p);
                    var combinedSearchResult = database.Recipes.Where(p => p.Categories.Any(c => c.Name.ToString().Equals("invalid"))).Select(p => p);
                    foreach (var enumString in categories)
                    {
                        var recipes = database.Recipes.Where(p => p.Categories.Any(c => c.Name.ToString().Equals(enumString))).Select(p => p);
                        categorySearchResult = categorySearchResult.Union(recipes);
                    }
                    if (contexts.Count > 0)
                    {
                        foreach (var enumString in contexts)
                        {
                            var recipes = categorySearchResult.Where(p => p.Contexts.Any(c => c.Name.ToString().Equals(enumString))).Select(p => p);
                            combinedSearchResult = combinedSearchResult.Union(recipes);
                        }
                    }
                    else combinedSearchResult = categorySearchResult;
                    SearchCleanUp(combinedSearchResult);
                }
            }

        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearGui();

            using (Models.PlanMyDinnerDbContext database = new Models.PlanMyDinnerDbContext())
            {
                //Using TemplateFields in the GridView Control 
                // https://msdn.microsoft.com/en-us/library/bb288032.aspx
                RecipeGridView.DataSource = database.Recipes.ToList();
                RecipeGridView.DataBind();
            }
            ltRecipe.Text = "Showing all available recipes";
        }

        protected void RecipeGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int recipeId = (int)RecipeGridView.SelectedDataKey.Value;
            UpdateGui(recipeId);
        }
    }
}