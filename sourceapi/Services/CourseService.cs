using sourceapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourceapi.Services
{
    public class CourseService
    {
        public List<Course> listCourse;

        public CourseService()
        {
            listCourse = new List<Course>()
            {
                new Course(){CourseID=1,CourseName="AZ-204"},
                new Course(){CourseID=2,CourseName="AZ-303"},
                new Course(){CourseID=3,CourseName="AZ-304"}
            };
        }

        public IEnumerable<Course> GetCourses()
        {
            return (listCourse);
        }
    }
}
