﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Models
{
    public class Brand : Entity
    {
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }

    }
}
