using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Domain.Entities
{

    public class Training
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Repeat { get; set; }
        public string Set { get; set; }
    }
}
