using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        public DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>
                (new DropCreateDatabaseAlways<DatabaseContext>());
        }
        public System.Data.Entity.DbSet<Student> Students { get; set; }
        public System.Data.Entity.DbSet<Standard> Standards { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("admin");
            modelBuilder.Entity<Models.Student>().ToTable("StudentInfo");
            modelBuilder.Entity<Models.Standard>().ToTable("StandardInfo", "dbo");

            modelBuilder.Entity<Models.Standard>()
                .HasKey<int>(current => current.StandardKey);
            modelBuilder.Entity<Models.Student>()
                .Property(current => current.DateOfBirth)
                .HasColumnName("Column01")
                .HasColumnOrder(3)
                .HasColumnType("datetime2");
            modelBuilder.Entity<Models.Student>()
                .Property(current => current.Height)
                .IsOptional()
                .HasPrecision(2, 2);
            modelBuilder.Entity<Models.Student>()
                .Property(current => current.Weight)
                .IsRequired();
            modelBuilder.Entity<Models.Student>()
                .Property(current => current.StudentName)
                .HasMaxLength(50)
                .IsConcurrencyToken(); //Optimistic Concurrency != Pessimistic Concurrency

            //CHAR
            //.IsFixedLength()
            //.IsUnicode(false);

            //NCHAR
            //.IsFixedLength()
            //.IsUnicode();

            //NVARCHAR(MAX)
            //.IsVariableLength()
            //.IsUnicode()
            //.IsMaxLength();

            //NVARCHAR(Number)
            //.IsUnicode()
            //.IsVariableLength()
            //.HasMaxLength(50);

            //VARCHAR(MAX)
            //.IsVariableLength()
            //.IsUnicode(false)
            //.IsMaxLength();

            //VARCHAR(Number)
            //.IsVariableLength()
            //.HasMaxLength(50);

            // One to One
            modelBuilder.Entity<StudentAddress>()
                .HasKey(s => s.Id);
            modelBuilder.Entity<Student>()
                .HasOptional(s => s.StudentAddress)
                .WithRequired(ad => ad.Student);
            
            // One to Many
            modelBuilder.Entity<Student>()
                .HasRequired<Standard>(s => s.Standard)
                .WithMany(st => st.Students)
                .HasForeignKey(s => s.Standard);
            
            // Many to Many
            modelBuilder.Entity<Student>()
                .HasMany<Course>(s => s.Courses)
                .WithMany(c => c.Students)
                .Map(cs =>
            {
                cs.MapLeftKey("StudentId");
                cs.MapRightKey("CourseId");
                cs.ToTable("StudentCourse");
            });

        }
    }
}