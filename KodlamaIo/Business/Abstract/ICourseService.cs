using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);

        Course GetById(int id);
        List<Course> GetAll();

    }
}
