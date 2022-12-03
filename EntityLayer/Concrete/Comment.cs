﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string? CommentMail { get; set; }
        public string? CommentTitle { get; set; }
        public string? CommentText { get; set; }
        public bool CommentStatus { get; set; }


        public int NeedId { get; set; }
        public Need Need { get; set; }

    }
}
