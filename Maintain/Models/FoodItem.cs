using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maintain.Models
{
    public class FoodItem
    {
        public FoodItem(string name, int protein_, int fat_, int carbs_) {
            itemName = name;
            protein = protein_;
            fat = fat_;
            carbs = carbs_;
        }

        private int id { get;set; }
        private string itemName { get;set; }

        // Numbers per 100g
        private int protein { get;set; }
        private int fat { get;set; }
        private int carbs { get;set; }

        public int getId() { return id; }
        public string getItemName() { return itemName; }
        public int getTotalCalories100g() { return (9 * fat + 4 * (carbs + protein)); }

        public int getTotalCaloriesServVal(int ServingSize) { return (9 * fat + 4 * (carbs + protein) * (ServingSize/100));}
    }
}
