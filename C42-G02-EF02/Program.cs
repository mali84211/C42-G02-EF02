using System.Reflection.Emit;

namespace C42_G02_EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region v1
            //internal class Employee
            //{
            //    public int Id { get; set; }
            //    public string Name { get; set; }
            //    public double Salary { get; set; }
            //    public int? Age { get; set; }
            //    public string Address { get; set; }
            //}

            //Data Annotation
            //[Table("Employee",Schema ="dbo")]
            //internal class Employee
            //{
            //    [Key]
            //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
            //    public int EmpId { get; set; }
            //    [Required]
            //    [Column(TypeName="varchar")]
            //    [MaxLength(50)]
            //    [StringLength(50,MinimumLength =10, ErrorMessage ="")]
            //    public string Name { get; set; }
            //    [Column(TypeName = "money")]
            //    public double Salary { get; set; }
            //    [Required]
            //    [Range(20,60)]
            //    public int? Age { get; set; }
            //    public string Address { get; set; }
            //    [Phone]
            //    public string Phone { get; set; }
            //    [EmailAddress]
            //    public string Email { get; set; }
            //    [NotMapped]
            //    public double TotalSalary { get; set; }
            //}

            //Fluent API
            //public int EmpId { get; set; }

            //public string Name { get; set; }

            //public double Salary { get; set; }

            //public int? Age { get; set; }
            //public string Address { get; set; }

            //public string Phone { get; set; }

            //public string Email { get; set; }

            //public double TotalSalary { get; set; }

            //modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);
            //modelBuilder.Entity<Employee>()
            //    .Property(E => E.EmpId)
            //.UseIdentityColumn(1, 1);

            //modelBuilder.Entity<Employee>()
            //   .Property(E => E.EmpId)
            //   .HasColumnType("varchar")
            //   .HasMaxLength(50)
            //.HasDefaultValue("mo");

            //base.OnModelCreating(modelBuilder);
            #endregion
        }
    }
}
