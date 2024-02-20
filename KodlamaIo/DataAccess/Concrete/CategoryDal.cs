using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concrete
{
    public class CategoryDal:ICategoryDal
    {

        private List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category{Id=1,Name="Category A"},
                new Category{Id=2,Name="Category B"},
                new Category{Id=3,Name="Category C"}
            };

        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int id)
        {
            Category categoryToDelete = _categories.FirstOrDefault(k => k.Id == id);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }



        }

        public List<Category> GetAll()
        {

            foreach (var category in _categories)
            {

                Console.WriteLine($"Kategori Adı: {category.Name}");
            }
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(k => k.Id == id);
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.FirstOrDefault(k => k.Id == category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
            }

        }
    }
}
