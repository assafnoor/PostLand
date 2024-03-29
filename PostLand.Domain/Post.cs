﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Domain
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Titel { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId  { get; set; }
    }
}
