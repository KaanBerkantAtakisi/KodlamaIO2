using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstract
{
    public interface IInstructorService
    {

        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int id);

        Instructor GetById(int id);
        List<Instructor> GetAll();
    }
}
