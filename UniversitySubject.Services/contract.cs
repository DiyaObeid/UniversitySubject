using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySubject.Services
{
    public interface IContract
    {

        public Task<bool> AddSubject(string subject);
        public Task<bool> DeleteSubject(Guid subjectId);
        //public Task<bool> UpdateSubject(Update Subject);






    }
}
