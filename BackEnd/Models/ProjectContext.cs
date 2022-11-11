using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {

        }
        public ProjectContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=eLearningXProject; Integrated Security=True");
        }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
    }

    
}

