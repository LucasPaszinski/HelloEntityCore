using Intro;
using System;
using System.Linq;

namespace HelloEntityCore
{
    class Program
    {
        static void Main()
        {
            using (var db = new BloggingContext())
            {
                // Create
                Console.WriteLine("Inserting a new blog");

                var blog = new Blog { Url = "http://blogs.msdn.com/adonet" };

                db.Add(blog);
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var queriedBlog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                queriedBlog.Url = "https://devblogs.microsoft.com/dotnet";

                var post = new Post
                {
                    Title = "Hello World",
                    Content = "I wrote an app using EF Core!"
                };


                queriedBlog.Posts.Add(post);
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();
            }
        }
    }
}
