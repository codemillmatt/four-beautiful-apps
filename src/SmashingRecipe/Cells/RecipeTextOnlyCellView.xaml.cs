using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SmashingRecipe
{
    public partial class RecipeTextOnlyCellView : ContentView
    {
        public RecipeTextOnlyCellView()
        {
            InitializeComponent();
        }
    }

    public class RecipeTextOnlyCell : ViewCell
    {
        public RecipeTextOnlyCell()
        {
            View = new RecipeTextOnlyCellView();
        }
    }
}
