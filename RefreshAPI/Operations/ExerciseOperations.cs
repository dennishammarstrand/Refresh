using Microsoft.EntityFrameworkCore;
using RefreshAPI.Data;
using RefreshAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshAPI.Operations
{
    public class ExerciseOperations
    {
        public static void Add(AppDbContext database, Exercise exercise)
        {
            var person = database.User.First(x => x.ID == exercise.User.ID);

            Exercise newRecord = new Exercise
            {
                Name = exercise.Name,
                Weight = exercise.Weight,
                Date = DateTime.Now,
                User = person
            };

            database.Exercises.Add(newRecord);
            database.SaveChanges();
        }

        public static string Delete(AppDbContext database, Exercise exercise)
        {
            var record = database.Exercises.First(x => x.ID == exercise.ID);

            database.Exercises.Remove(record);
            database.SaveChanges();

            return "Record Deleted";
        }
    }
}
