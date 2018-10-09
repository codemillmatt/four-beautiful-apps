using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SmashingRecipe
{
    public partial class RecipeCellView : ContentView
    {
        public RecipeCellView()
        {
            InitializeComponent();
        }
    }

    public class RecipeCell : ViewCell
    {
        public RecipeCell()
        {
            View = new RecipeCellView();
        }
    }
}
