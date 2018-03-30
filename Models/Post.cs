using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Post
    {
        public string Body {
            get; set;
        }
        public IEnumerable<Comment> Comments {
            get; set;
        }
        public DateTime CreatedDate {
            get; set;
        }
        public string Header {
            get; set;
        }
        public int PostId {
            get; set;
        }
        public IEnumerable<Tag> Tags {
            get; set;
        }
        public void New() {

        }
    }
}
