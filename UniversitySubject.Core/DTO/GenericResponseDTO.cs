using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySubject.Core.DTO
{
    public  class GenericResponseDTO
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
    }
}
