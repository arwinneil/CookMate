using System.Collections.Generic;

namespace CookMate
{
    public class Recipe
    {
        public string Name;
        public List<string> Ingredients;
        public int Time;
        public List<string> Steps;

        public Recipe(string name, List<string> ingredients, int time, List<string> steps)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.Time = time;
            this.Steps = steps;
        }
    }
}