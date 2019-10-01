using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RefreshAPI.Data;
using RefreshAPI.Models;
using RefreshAPI.Operations;

namespace RefreshAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private AppDbContext database;

        public ExerciseController(AppDbContext _database)
        {
            database = _database;
        }

        [HttpPost]
        public string Add(Exercise exercise)
        {
            ExerciseOperations.Add(database, exercise);
            return "Exercise added";
        }

        [HttpDelete]
        public ActionResult<string> Delete(Exercise exercise)
        {
            return ExerciseOperations.Delete(database, exercise);
        }
    }
}