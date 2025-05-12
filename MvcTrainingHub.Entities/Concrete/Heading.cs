using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcTrainingHub.Entities.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryID { get; set; } // Foreign key property for the relationship with Category
        public virtual Category Category { get; set; } // Navigation property for the relationship with Category

        public ICollection<Content> Contents { get; set; } // Navigation property for the relationship with Content 

        public int? WriterID { get; set; } // Foreign key property for the relationship with Writer    
        public virtual Writer Writer { get; set; } // Navigation property for the relationship with Writer
    }
}
