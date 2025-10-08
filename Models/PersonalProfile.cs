using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    class PersonalProfile
    {
        private List<Recipe>? favorites;

        public PersonalProfile()
        {
            favorites = new List<Recipe>();
        }
    }
}
