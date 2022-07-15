using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Domain.Entities
{
    public class WorkoutDto
    {
        public string CustomerName { get; set; }
        public string WorkoutName { get; set; }
        public string Repeat { get; set; }
        public string Set { get; set; }
        public string TrainerName { get; set; }
    }
}
