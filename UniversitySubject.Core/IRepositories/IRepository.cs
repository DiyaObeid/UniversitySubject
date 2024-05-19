using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySubject.Core.DTO;

namespace UniversitySubject.Core.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T?>> GetAll();
        Task<GenericResponseDTO> Delete(T entity);
        Task<GenericResponseDTO> Add(T entity);

    }
}
