using KodlamaIo.Entities;
using KodlamaIo.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concrete
{
    public class CourseDal:ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>
            {

                new Course{Id=1,CoName="Course A",Description="Description A",CategoryId=1,InstructorId=1},
                new Course{Id=2,CoName="Course B",Description="Description B",CategoryId=2,InstructorId=2},
                new Course{Id=3,CoName="Course C",Description="Description C",CategoryId=3,InstructorId=3}

            };

        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int id)
        {
            Course courseToDelete = _courses.FirstOrDefault(k => k.Id == id);
            if (courseToDelete != null)
            {
                _courses.Remove(courseToDelete);
            }
        }

        public List<Course> GetAll()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine($"Kurs Adı: {course.CoName}, Açıklama: {course.Description}");
            }

            return _courses;

        }

        public Course GetById(int id)
        {
            return _courses.FirstOrDefault(k => k.Id == id);

        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.FirstOrDefault(k => k.Id == course.Id);
            if (courseToUpdate != null)
            {

                courseToUpdate.CoName = course.CoName;
                courseToUpdate.Description = course.Description;
                courseToUpdate.CategoryId = course.CategoryId;
                courseToUpdate.InstructorId = course.InstructorId;
            }

        }
    }
}
