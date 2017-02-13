﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Interaction
    {
        
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public virtual User  User { get; set; }
        public virtual Product Product { get; set; }

        public Interaction()
        {

        }
       
    }
}
