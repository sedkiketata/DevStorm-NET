using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment : Interaction
    {
        private int commentId;
        private DateTime date;
        private string text;

        public Comment():base()
        {

        }

        public int CommentId
        {
            get
            {
                return commentId;
            }

            set
            {
                commentId = value;
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

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
    }
}
