using System;
using Xamarin.Forms;
namespace SmashingRecipe
{
    public class RecipeDataTemplateSelector : DataTemplateSelector
    {
        readonly DataTemplate RecipeCellWithImage;
        readonly DataTemplate RecipeCellTextOnly;

        public RecipeDataTemplateSelector()
        {
            RecipeCellWithImage = new DataTemplate(typeof(RecipeCell));
            RecipeCellTextOnly = new DataTemplate(typeof(RecipeTextOnlyCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var recipe = (Recipe)item;

            if (string.IsNullOrEmpty(recipe.Picture))
                return RecipeCellTextOnly;
            else
                return RecipeCellWithImage;
        }
    }
}
