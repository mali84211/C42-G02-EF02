using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02
{
    [Table("Course_Inst", Schema = "dbo")]
    internal class CourseInst
    {
        [Key]
        public int inst_ID { get; set; }

        [Key]
        public int Course_ID { get; set; }

        public string Evaluate { get; set; }
    }
}
