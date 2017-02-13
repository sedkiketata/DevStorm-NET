﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rate : Interaction
    {
        private int rateId;
        private int mark;
        public Rate():base()
        {

        }
        public int Mark
        {
            get
            {
                return mark;
            }

            set
            {
                mark = value;
            }
        }

        public int RateId
        {
            get
            {
                return rateId;
            }

            set
            {
                rateId = value;
            }
        }
    }
}
