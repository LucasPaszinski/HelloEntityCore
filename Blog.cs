using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Intro
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }

        public Blog()
        {
            // List need initialization, 
            // if not a exception will be throw 
            // when adding a new list on the blog
            Posts = new List<Post>();
        }
    }
}