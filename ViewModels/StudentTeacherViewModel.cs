using TestDotNetWebApplication.Models;

namespace TestDotNetWebApplication.ViewModels
{
    public class StudentTeacherViewModel
    {
        public Student Student { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
