using JWTAuth.IdendityAuth;
using JWTAuth.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWTAuth.DbContext
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentHobby> StudentHobbies { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");
                entity.HasOne(d => d.Gender)
                .WithMany(d => d.Students)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK_Student_Gender");
            }); 

            builder.Entity<StudentHobby>(entity =>
            {
                entity.HasKey(d => new { d.StudentId, d.HobbyId });
                entity.ToTable("StudentHobby");


                entity.HasOne(d => d.Student)
                .WithMany(d => d.StudentHobbies)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentHobby_Student");

                entity.HasOne(d => d.Hobby)
              .WithMany(d => d.StudentHobbies)
              .HasForeignKey(d => d.HobbyId)
              .HasConstraintName("FK_StudentHobby_Hobby");


            });

            builder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.Property(e => e.FileName)
                .HasMaxLength(500)
                .IsUnicode(false);

                entity.Property(e => e.ContentType)
               .HasMaxLength(100)
               .IsUnicode(false);


            });





            base.OnModelCreating(builder);  
        }
    }
}
