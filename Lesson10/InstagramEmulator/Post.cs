using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramEmulator
{
    class Post
    {
        public string Caption { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

        public Post(string caption, DateTime date, User user)
        {
            Caption = caption;
            Date = date;
            User = user;
        }
    }
}
