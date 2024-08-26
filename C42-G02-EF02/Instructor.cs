using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02
{
    [Table("Instructor", Schema = "dbo")]
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRateBonus { get; set; }

        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
    }
}
