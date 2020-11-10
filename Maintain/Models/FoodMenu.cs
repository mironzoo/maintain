using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maintain.Models
{
    public class FoodMenu
    {
        private int id { get;set; }
        private string title { get;set; }
        private string desc { get; set; }
        private List<FoodItem> menu;
        
        public int getId() { return id; }
        public string getTitle() { return title; }
        public List<FoodItem> getMenu() { return menu; }

        public void addFood(string name, int protein, int fats, int carbs) { 
            menu.Add(new FoodItem(name, protein, fats, carbs));
        }
    }
}
