using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maintain.Repository;
using Maintain.Models;
using Microsoft.Extensions.Configuration;

namespace Maintain.Service {
    public class ExerciseService {
        ExerciseRepos er;
        public ExerciseService(IConfiguration config) {
            er = new ExerciseRepos(config);
        }

        public List<Exercise> GetAllExercises() {
            return er.GetAllExercises();
        }

        public void AddExerciseToMuscleGroup(int ex_id, int musc_id) {
            er.AddExerciseToMuscleGroup(ex_id, musc_id);
        }
        public void DeleteMuscleTrained(int ex_id, int musc_id) {
            er.DeleteMuscleTrained(ex_id, musc_id);
        }
        public List<Exercise> GetExercisesByMuscle(int id) {
            return er.GetExercisesByMuscleId(id);
        }
        public List<Exercise> GetExercisesByMuscleGroup(int id) {
            return er.GetExercisesByMuscleGroup(id);
        }
    }
}
