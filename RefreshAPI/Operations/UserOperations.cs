using Microsoft.EntityFrameworkCore;
using RefreshAPI.Data;
using RefreshAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshAPI.Operations
{
    public class UserOperations
    {
        public static List<User> Show(AppDbContext database)
        {
            var persons = database.User.Include(x => x.Exercises).ToList();

            return persons;
        }

        public static string Add(AppDbContext database, User user)
        {
            User newUser = new User
            {
                Name = user.Name,
                Age = user.Age,
                Exercises = new List<Exercise>()
            };

            database.Add(newUser);
            database.SaveChanges();

            return "User Created";
        }

        public static string Delete(AppDbContext database, int id)
        {
            var userToRemove = database.User.First(x => x.ID == id);
            database.Remove(userToRemove);
            database.SaveChanges();

            return "User Deleted";
        }
    }
}
