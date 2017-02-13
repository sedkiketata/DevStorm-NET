using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Showroom
    {
        private int showroomId;
        public int ShowRoomerId { get; set; }
        public int productId { get; set; }
        public virtual Showroomer Showroomer { get; set; }
        public virtual Product Product { get; set; }

        public int ShowroomId
        {
            get
            {
                return showroomId;
            }

            set
            {
                showroomId = value;
            }
        }
    }
}
