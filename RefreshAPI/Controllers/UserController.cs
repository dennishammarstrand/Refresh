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
    public class UserController : ControllerBase
    {
        private AppDbContext database;
        public UserController(AppDbContext _database)
        {
            database = _database;
        }

        [HttpGet]
        public List<User> ShowUsers()
        {
            return UserOperations.Show(database);
        }

        [HttpPost]
        public string Add(User user)
        {
            return UserOperations.Add(database, user);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return UserOperations.Delete(database, id);
        }
    }
}