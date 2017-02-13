﻿using Domain.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Showroomer : User
    {
        private String description;
        private Location location;
        public virtual ICollection<Voucher> Vouchers { get; set; }

        public Showroomer():base()
        {
                
        }
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public Location Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
    }
}
