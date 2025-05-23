﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcTrainingHub.Entities.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }

        public ICollection<Heading> Headings { get; set; } // Navigation property for the relationship with Heading 

        public ICollection<Content> Contents { get; set; } // Navigation property for the relationship with Content

    }
}
