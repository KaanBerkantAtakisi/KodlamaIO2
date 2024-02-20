using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstract
{
    public interface IInstructorDal
    {

        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int id);
        List<Instructor> GetAll();
        Instructor GetById(int id);
    }
}
