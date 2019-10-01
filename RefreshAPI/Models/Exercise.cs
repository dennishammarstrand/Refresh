using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshAPI.Models
{
    public class Exercise
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}
