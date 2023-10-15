using SocialMedia_kata.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia_kata.Implementations
{
    public class Post : IPost
    {
        // Id of post. Must be unique and sequential.
        public int Id { get; set; }
        // Member that made this post
        public IMember Member { get; set; }
        // The post message
        public string Message { get; set; }
        // Date and time post was made
        public DateTime Date { get; set; }
        // Likes for post
        public int Likes { get; set; }
    }
}
