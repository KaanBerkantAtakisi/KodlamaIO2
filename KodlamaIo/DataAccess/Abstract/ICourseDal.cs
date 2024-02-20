using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
        List<Course> GetAll();
        Course GetById(int id);
    }
}
