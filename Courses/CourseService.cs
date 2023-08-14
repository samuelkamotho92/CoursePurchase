using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Usermodel;

namespace Authentication.Courses
{
    public class  CourseService
    {
        public List<CourseDTO> GetCourses()
        {
            List<CourseDTO> list = new List<CourseDTO>()
            {
                new CourseDTO() {Id=1, Name="C# Full Stack Development" ,Plans=Plans.Csharp,Price=50000},
                new CourseDTO() {Id=2, Name="Javascript Full-Stack Development",Plans=Plans.Javascript,Price=40000},
                new CourseDTO() {Id=3, Name="QA/QE",Plans=Plans.QAQE ,Price=20000},
                new CourseDTO() {Id=4, Name="WordPress Full Stack Development",Plans=Plans.Wordpress,Price=30000}
                };
            return list;
        }
    }
}
