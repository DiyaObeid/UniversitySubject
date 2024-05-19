using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySubject.Core.DTO;
using UniversitySubject.Core.Entities;
using UniversitySubject.Core.IRepositories;
using UniversitySubject.Services.Contract;

namespace UniversitySubject.Services.Implemintation
{
    public class SubjectsServices : ISubjectsServices
    {
        private IRepository<Subject> _subjectRepository;
        public SubjectsServices(IRepository<Subject> repository)
        {
            _subjectRepository = repository;
        }
        public async Task<GenericResponseDTO> AddSubject(AddSubjectDTO subject)
        {
            try
            {

                Subject new_subject = new Subject()
                {
                    Id = Guid.NewGuid(),
                    Name = subject.Name,
                    Description = subject.Description,
                   
                };
                var result = await _subjectRepository.Add(new_subject);
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<GenericResponseDTO> DeleteSubject(Subject obj)
        {
            var result = await _subjectRepository.Delete(obj);

            return result;
        }

        public async Task<List<SubjectResponseDto>> getAll()
        {
            try
            {

                List<SubjectResponseDto> dtoList = new List<SubjectResponseDto>();

                var subject = await _subjectRepository.GetAll();
                if (subject != null)
                {
                    foreach (var student_item in subject)
                    {
                        var subjectdto = new SubjectResponseDto()
                        {
                            Name = subject.Name,
                            Description = subject.Description,
                        };
                        dtoList.Add(subjectdto);
                    }

                }

                return dtoList;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<List<SubjectResponseDto>> ISubjectsServices.AddSubject(AddSubjectDTO subject)
        {
            try
            {

                Subject new_subject = new Subject()
                {
                    Id = Guid.NewGuid(),
                    Name = subject.Name,
                    Description = subject.Description,

                };
                var result = await _subjectRepository.Add(new_subject);
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
