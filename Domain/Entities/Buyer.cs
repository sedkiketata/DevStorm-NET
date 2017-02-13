using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Buyer : User
    {
        private string deliveryAddress;

        public Buyer():base()
        {

        }
        public string DeliveryAddress
        {
            get
            {
                return deliveryAddress;
            }

            set
            {
                deliveryAddress = value;
            }
        }
    }
}
