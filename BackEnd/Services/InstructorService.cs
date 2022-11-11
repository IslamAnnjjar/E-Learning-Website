
namespace BackEnd.Services
{
    public class InstructorService
    {
        private readonly ProjectContext ctx;

        public InstructorService(ProjectContext projectContext)
        {
            ctx = projectContext;
        }


        public Instructor GetService(int id)
        {
            return ctx.Instructors.Where(i => i.InsId == id).FirstOrDefault();
        }

        public Instructor AddService(InstructorDTO instructor)
        {
            var ins = new Instructor();
            ins.FirstName = instructor.FirstName;
            ins.LastName = instructor.LastName;
            ins.InsUserName = instructor.UserName;
            ins.InsPassword = instructor.Password;

            ctx.Instructors.Add(new Instructor { FirstName = ins.FirstName, LastName = ins.LastName, InsUserName = ins.InsUserName, InsPassword = ins.InsPassword });
            ctx.SaveChanges();
            return new Instructor { FirstName = ins.FirstName, LastName = ins.LastName, InsUserName = ins.InsUserName };
        }

        public Instructor UpdateService(int id, InstructorDTO instructor)
        {
            var currentInstructor = ctx.Instructors.Where(i => i.InsId == id).FirstOrDefault();
            currentInstructor.LastName = instructor.LastName;
            currentInstructor.FirstName = instructor.FirstName;
            currentInstructor.InsPassword = instructor.Password;

            ctx.Instructors.Add(new Instructor { FirstName = currentInstructor.FirstName, LastName = currentInstructor.LastName, InsPassword = currentInstructor.InsPassword });
            ctx.SaveChanges();
            return new Instructor { FirstName = currentInstructor.FirstName, InsUserName = currentInstructor.InsUserName, InsPassword = currentInstructor.InsPassword };
        }



    }
}
