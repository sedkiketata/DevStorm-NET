using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Purchase
    {
        private int purchaseId;
        private DateTime date;
        private float total;
        public int BuyerId { get; set; }
        public int productId { get; set; }
        public virtual Buyer Buyer { get; set; }
        public virtual Product Product { get; set; }
        public int PurchaseId
        {
            get
            {
                return purchaseId;
            }

            set
            {
                purchaseId = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}
