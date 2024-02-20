using KodlamaIo.Business.Concrete;
using KodlamaIo.DataAccess.Concrete;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo
{
    public class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new CourseDal());
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());

            Console.WriteLine("Tüm kurslar:");
            courseManager.GetAll();


            Course newCourse = new Course { Id = 4, CoName = "Course D", Description = "Description D", CategoryId = 4, InstructorId = 4 };
            courseManager.Add(newCourse);
            Console.WriteLine("Yeni kurs eklendi.");
            courseManager.GetAll();


            Course courseToUpdate = courseManager.GetById(1);
            courseManager.Update(courseToUpdate);
            Console.WriteLine("Kurs güncellendi.");
            courseManager.GetAll();


            int courseIdToDelete = 2;
            courseManager.Delete(courseIdToDelete);
            Console.WriteLine($"ID'si {courseIdToDelete} olan kurs silindi.");
            courseManager.GetAll();


            Console.WriteLine("Tüm kategoriler:");
            categoryManager.GetAll();

            Category newCategory = new Category { Id = 5, Name = "Category D" };
            categoryManager.Add(newCategory);
            Console.WriteLine("Yeni kategori eklendi.");
            categoryManager.GetAll();

            Category categoryToUpdate = categoryManager.GetById(1);
            categoryToUpdate.Name = "Updated Category";
            categoryManager.Update(categoryToUpdate);
            Console.WriteLine("Kategori güncellendi.");
            categoryManager.GetAll();

            int categoryIdToDelete = 2;
            categoryManager.Delete(categoryIdToDelete);
            Console.WriteLine($"ID'si {categoryIdToDelete} olan kategori silindi.");
            categoryManager.GetAll();


            Console.WriteLine("Tüm eğitmenler:");
            instructorManager.GetAll();


            Instructor newInstructor = new Instructor { Id = 5, FirstName = "Akın", LastName = "Kaldıroğlu" };
            instructorManager.Add(newInstructor);
            Console.WriteLine("Yeni eğitmen eklendi.");
            instructorManager.GetAll();


            Instructor instructorToUpdate = instructorManager.GetById(5);
            instructorToUpdate.FirstName = "Keanu ";
            instructorToUpdate.LastName = "Reeves";
            instructorManager.Update(instructorToUpdate);
            Console.WriteLine("Eğitmen güncellendi.");
            instructorManager.GetAll();


            int instructorIdToDelete = 2;
            instructorManager.Delete(instructorIdToDelete);
            Console.WriteLine($"ID'si {instructorIdToDelete} olan eğitmen silindi.");
            instructorManager.GetAll();
            Console.ReadLine();
        }
    }
}
