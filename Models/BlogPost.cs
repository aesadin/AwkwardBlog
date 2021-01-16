using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace AwkwardBlog.Models
{
    public class BlogPost
    {
        public int BlogPostId {get; set;}
        public string Title {get; set;}
        public string Image {get; set;}
        public string Description {get; set;}
        public string Category {get; set;}
        public string Ingredients {get; set;}
        public string Instructions {get; set;}
    }
}