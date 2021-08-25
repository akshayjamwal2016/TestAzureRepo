using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Workout> Get()
        {
            return CreateWorkoutList();
        }

        private List<Workout> CreateWorkoutList()
        {
            List<Workout> workoutList = new List<Workout>()
            {
                new Workout() { Area = "Chest", Exercise = "Bench Press", Freequency = "4"  },
                new Workout() { Area = "Chest", Exercise = "DB Fly", Freequency = "4"  },
                new Workout() { Area = "Shoulders", Exercise = "Military Press", Freequency = "4"  },
                new Workout() { Area = "Triceps", Exercise = "DB Skull Crushers", Freequency = "4"  }
            };

            return workoutList;
        }
    }
}
