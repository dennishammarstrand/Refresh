using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshAPI.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}
