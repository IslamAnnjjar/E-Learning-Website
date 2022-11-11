using Microsoft.AspNetCore.Mvc;
using BackEnd.Models;
using Microsoft.AspNetCore.Http;

namespace BackEnd.Services
{
    public class CourseService
    {
        private readonly ProjectContext ctx;

        public CourseService(ProjectContext projectContext)
        {
            ctx = projectContext;
        }

        public List<Course> GetService()
        {
            return ctx.Courses.ToList();
            

        }
        public Course SelectByNameService(string name)
        {
            return ctx.Courses.FirstOrDefault(c => c.CrsTitle == name);
        }
        public int AddService(CourseWithVideoInstructorUserDTO crsDTO)
        {
            var courses = new Course();
            courses.CrsId = crsDTO.CrsID;
            courses.CrsTitle = crsDTO.CrsTitle;
            courses.CrsDesc = crsDTO.CrsDesc;
            courses.InsId = crsDTO.InsID;
            courses.Price = crsDTO.Price;
            ctx.Courses.Add(courses);
            ctx.SaveChanges();
            return 1;
        }

        public void UpdateService(int id, CourseWithVideoInstructorUserDTO newCourse)
        {
            var currentCourse = ctx.Courses.FirstOrDefault(c => c.CrsId == id);
            currentCourse.CrsTitle = newCourse.CrsTitle;
            currentCourse.CrsDesc = newCourse.CrsDesc;
            ctx.SaveChanges();
        }

        public void DeleteService(int id)
        {
            var currentCourse = ctx.Courses.FirstOrDefault(c => c.CrsId == id);
            ctx.Courses.Remove(currentCourse);
            ctx.SaveChanges();
        }

    }
}
