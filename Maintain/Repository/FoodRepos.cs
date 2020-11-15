using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Maintain.Models;

namespace Maintain.Repository {
    public class FoodRepos : Repos {
        public FoodRepos(IConfiguration configuration) : base(configuration) { }

        public bool AddExercise() {
            return false;
        }

        public bool DeleteExercise() {
            return false;
        }

        public bool UpdateExercise() {
            return false;
        }

        public FoodItem getFoodById(int id) {
            return new FoodItem("Name", 1,1,1);
        }

        public List<FoodItem> getAllFoods() {
            return new List<FoodItem>();
        }
    }
}
