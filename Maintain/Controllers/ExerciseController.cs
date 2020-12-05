﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Maintain.Service;
using Maintain.Models;
using Maintain.Requests;
using System.Text.Json;
using System.Diagnostics;

namespace Maintain.Controllers
{
    [Route("api/exercise")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        ExerciseService service;
        public ExerciseController(IConfiguration config) {
            _configuration = config;
            service = new ExerciseService(config);
        }
        
        [HttpGet]
        [Route("all")]
        public string GetExercises() {
            return JsonSerializer.Serialize(service.GetAllExercises());
        }

        [HttpGet]
        [Route("muscle/{id}")]
        public string GetExerciseByMuscleId(int id) {
            return JsonSerializer.Serialize(service.GetExercisesByMuscle(id));
        }

        [HttpGet]
        [Route("muscle/group/{id}")]
        public string GetExerciseByMuscleGroup(int id) {
            return JsonSerializer.Serialize(service.GetExercisesByMuscleGroup(id));
        }

        [HttpPost]
        [Route("muscle/addex")]
        public void AddExerciseToMuscleGroup([FromBody] MuscleTrainedRequest trained) {
            service.AddExerciseToMuscleGroup(trained.ex_id, trained.musc_id);
        }

        [HttpPost]
        [Route("muscle/delex")]
        public void DelExerciseFromMuscleGroup([FromBody] MuscleTrainedRequest trained) {
            service.DeleteMuscleTrained(trained.ex_id, trained.musc_id);
        }
    }
}