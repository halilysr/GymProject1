using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Domain.Entities
{

    public class Workout
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TrainingId { get; set; }
        public int TrainerId { get; set; }
    }
}
