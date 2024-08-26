using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02
{
    [Table("Course", Schema = "dbo")]
    internal class Course
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public int Duration { get; set; }
        public string Description { get; set; }

        [ForeignKey("Topic")]
        public int Top_ID { get; set; }
    }
}
