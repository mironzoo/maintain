using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Maintain.Models;

namespace Maintain.Repository {
    public class ExerciseRepos : Repos {
        public ExerciseRepos(IConfiguration configuration) : base(configuration) { }

        public bool AddExercise() { 
            return false;
        }

        public bool DeleteExercise() {
            return false;
        }

        public bool UpdateExercise() {
            return false;
        }

        public List<Exercise> getExerciseByMuscleId(int id) {
            return new List<Exercise>();
        }

        public List<Exercise> getAllExercises() { 
            return new List<Exercise>();
        }
    }
}
