using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcTrainingHub.Entities.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingID { get; set; } // Foreign key property for the relationship with Heading
        public virtual Heading Heading { get; set; } // Navigation property for the relationship with Heading

        public int? WriterID { get; set; } // Foreign key property for the relationship with Writer
        public virtual Writer Writer { get; set; } // Navigation property for the relationship with Writer



    }
}
