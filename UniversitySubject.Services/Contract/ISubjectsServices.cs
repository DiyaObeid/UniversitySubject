using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySubject.Core.DTO;
using UniversitySubject.Core.Entities;

namespace UniversitySubject.Services.Contract
{
    public interface ISubjectsServices
    {
        public Task<List<SubjectResponseDto>> AddSubject(AddSubjectDTO subject);
        public Task<GenericResponseDTO> DeleteSubject(Subject obj);
        public Task<SubjectResponseDto> getAll();
    }
}
