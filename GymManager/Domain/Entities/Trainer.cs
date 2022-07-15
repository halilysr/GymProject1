﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Domain.Entities
{
 
    public class Trainer 

    {

        public int Id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
    }
}
