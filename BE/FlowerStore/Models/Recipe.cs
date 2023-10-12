using System;
using System.Collections.Generic;

namespace FlowerStore.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            Products = new HashSet<Product>();
        }

        public int RecipeId { get; set; }
        public string? RecipeDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
