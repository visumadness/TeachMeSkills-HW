using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramEmulator
{
    public class Post
    {
        public string Caption { get; set; }
        public DateTime CreatedAt { get; set; }

        public Post(string caption, DateTime createdAt)
        {
            Caption = caption;
            CreatedAt = createdAt;
        }
    }
}
