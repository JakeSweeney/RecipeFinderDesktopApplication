using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeFinderPrototype
{
    internal class Recipe : IComparable<Recipe>
    {
        public Recipe(string Name,string Region,string WebLink) 
        { 
            this.Name = Name;
            this.Region = Region;
            ingredientList = new LinkedList<string>();
            ingredientQuantityList = new LinkedList<float>();
            allergenList = new LinkedList<string>();
            this.WebLink = WebLink;
        }
        private string name = string.Empty;
        private string region = string.Empty;
        private LinkedList<string> ingredientList;
        private LinkedList<float> ingredientQuantityList;
        private LinkedList<string> allergenList;
        private string webLink;
        private int match;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        public LinkedList<string> IngredientList
        {
            get { return ingredientList; }
        }

        public LinkedList<float> IngredientQuantityList
        {
            get { return ingredientQuantityList; }
        }

        public LinkedList<string> AllergenList
        {
            get { return allergenList; }
        }

        public string WebLink
        {
            get { return webLink; }
            set { webLink = value; }
        }

        public int Match
        {
            get { return match;}
            set { match = value; }
        }

        public override string ToString()
        {
            string ingredientBuffer = string.Empty;
            string ingredientQuantityBuffer = string.Empty;
            string allergenBuffer = string.Empty;
            foreach (string ingredient in ingredientList)
            {
                ingredientBuffer += $"{ingredient} \n";
            }
            foreach (float quantity in ingredientQuantityList)
            {
                
                ingredientQuantityBuffer += $"{quantity} \n";
            }
            if(allergenList != null)
            {
                foreach (string allergy in allergenList)
                {
                    allergenBuffer += $"{allergy} \n";
                }
            }
            
            return $"{Name} \n {ingredientBuffer}  {ingredientQuantityBuffer} {allergenBuffer} {WebLink}";
        }

        public string GetIngredientAt(int index)
        {
            if (index < 0 || index > ingredientList.Count - 1)
            {
                return string.Empty ;
            }
            else
            {
                return ingredientList.ElementAt(index);
            }
        }

        public int FindIngredientIndex(string ingredient)
        {
            int index = 0;
            foreach(string food in  ingredientList)
            {
                if (food == ingredient)
                {
                    return index+1;
                }
                index++;
            }
            return -1; //if ingredient not found
        }

        public bool ContainsIngredient(string fridgeIngredient)
        {
            if (fridgeIngredient == null || ingredientList == null) return false;
            else
            {
                foreach(string ingredient in ingredientList) 
                {
                    if(ingredient.Equals(fridgeIngredient)) return true ;
                }
                return false;
            }
        }
        
        public bool ContainsAllergen(string userAllergen)
        {
            if (userAllergen == null || ingredientList == null) return false;
            else
            {
                foreach (string recipeAllergen in allergenList)
                {
                    if (recipeAllergen.Equals(userAllergen)) return true;
                }
                return false;
            }
        }

        public void AddIngredient(string ingredient)
        {
            if (ingredient != null)
            {
                ingredientList.AddLast(ingredient);
            }
            else
            {
                return;
            }
        }

        public void AddQuantity(float quantity)
        {
            if (quantity > 0)
            {
                ingredientQuantityList.AddLast(quantity);
            }
            else
            {
                return;
            }
        }

        public void AddAllergen(string allergen)
        {
            if (allergen != null)
            {
                allergenList.AddLast(allergen);
            }
            else
            {
                return;
            }
        }

        public int CompareTo(Recipe? other)
        {
            if (other == null) return 1;
            else
            {
                return String.Compare(this.Name, other.Name);
            }
        }
    }
}
