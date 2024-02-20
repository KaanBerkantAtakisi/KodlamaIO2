using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concrete
{
    public class InstructorDal:IInstructorDal
    {
        private List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {

                new Instructor {Id=1,FirstName="Engin ",LastName="Demiroğ"},
                new Instructor {Id=2,FirstName="Atıl ",LastName="Samancıoğlu"},
                new Instructor { Id = 3, FirstName = "Halit Enes ", LastName = "Kalaycı"},
                new Instructor {Id=4,FirstName="Kasım",LastName="Adalan"}
        };

        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(int id)
        {
            Instructor instructorToDelete = _instructors.FirstOrDefault(i => i.Id == id);
            if (instructorToDelete != null)
            {
                _instructors.Remove(instructorToDelete);
            }

        }

        public List<Instructor> GetAll()
        {
            foreach (var instructor in _instructors)
            {
                Console.WriteLine($"ID: {instructor.Id}, Adı: {instructor.FirstName}, Soyadı: {instructor.LastName}");
            }
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            return _instructors.FirstOrDefault(k => k.Id == id);
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.FirstOrDefault(k => k.Id == instructor.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.FirstName = instructor.FirstName;
                instructorToUpdate.LastName = instructor.LastName;
            }
        }

    }
}
