﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }
        public string CommentText { get; set; }  
        public int StarCount { get; set; }
        public string Image { get; set; }
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
