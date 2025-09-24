using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class RecipeDetails
    {
        public string? Description { get; set; }
        public List<string>? Ingredients { get; set; }
        public string? Instructions { get; set; }
    }
}
