using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02
{
    internal class ITIContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>()
                        .HasKey(t => t.ID);
            modelBuilder.Entity<Topic>()
                        .Property(t => t.Name)
                        .IsRequired()
                        .HasMaxLength(100);

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Stud_Course>()
                .Property(sc => sc.Grade)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
    }
}
