using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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

        public bool AddExerciseToMuscleGroup(int musc_id, int ex_id) {
            if (OpenConnection()) {

                string query = "INSERT INTO muscles_trained VALUES (" + ex_id + ", " + musc_id + ");";
                SqlCommand cmd  = new SqlCommand(query, getConn());
                cmd.ExecuteNonQuery();
            } 
            return CloseConnection();
        }
        public bool DeleteMuscleTrained(int musc_id, int ex_id) {
            if (OpenConnection()) {

                string query = "DELETE FROM muscles_trained WHERE ex_id IN (" + ex_id + ") AND musc_id IN (" + musc_id + ");";
                SqlCommand cmd = new SqlCommand(query, getConn());
                cmd.ExecuteNonQuery();
            }
            return CloseConnection();
        }

        public List<Exercise> GetExercisesByMuscleId(int id) {

            List<Exercise> exercises = new List<Exercise>();
            string selectQuery = "SELECT ex_id, ex_nm FROM EXERCISES WHERE ex_id IN (SELECT ex_id FROM MUSCLES_TRAINED WHERE musc_id = '" + id + "');";

            OpenConnection();
            SqlCommand command = new SqlCommand(selectQuery, getConn());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                exercises.Add(new Exercise(Int32.Parse(reader[0].ToString()), reader[1].ToString()));
            }
            CloseConnection();

            return exercises;
        }

        public List<Exercise> GetExercisesByMuscleGroup(int id) {
            List<Exercise> exercises = new List<Exercise>();
            string selectQuery = 
                "SELECT DISTINCT ex.ex_id, name " +
                "FROM EXERCISES ex " +
                "INNER JOIN MUSCLES_TRAINED mt ON ex.ex_id = mt.ex_id " +
                "WHERE musc_id IN (SELECT musc_id FROM MUSCLES WHERE musc_cat_id = '" + id + "');";
            OpenConnection();
            SqlCommand command = new SqlCommand(selectQuery, getConn());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                exercises.Add(new Exercise(Int32.Parse(reader[0].ToString()), reader[1].ToString()));
            }
            CloseConnection();
            return exercises;
        }
             
        public List<Exercise> GetAllExercises() {

            List<Exercise> exercises = new List<Exercise>();
            string selectQuery = "SELECT ex_id, name FROM EXERCISES;";

            OpenConnection();
            SqlCommand command = new SqlCommand(selectQuery, getConn());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                exercises.Add(new Exercise(Int32.Parse(reader[0].ToString()), reader[1].ToString()));
            }
            CloseConnection();
            return exercises;
        }
    }
}
