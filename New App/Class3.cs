//ST10341842 Mvinjelwa Buhle 
//ProgPOE part 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPOEPart1;

    public class RecipeBase
    {
        // Encapsulated fields
        private string dishName;
        private string[] ingredients;
        private double[] quantities;
        private string[] units;
        private string[] steps;

        // Property for dishName
        public string DishName
        {
            get { return dishName; }
            set { dishName = value; }
        }
        // Constructor
        public RecipeBase()
        {
            dishName = string.Empty;
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
        }
        // Properties for encapsulation
        public string[] Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public double[] Quantities
        {
            get { return quantities; }
            set { quantities = value; }
        }
        public string[] Units
        {
            get { return units; }
            set { units = value; }
        }
        public string[] Steps
        {
            get { return steps; }
            set { steps = value; }
        }
    }

