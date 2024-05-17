using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySubject.Core.Entities;

namespace UniversitySubject.Infrastructure.DBConection
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> contextOptions)
            : base(contextOptions)
        {
        }




    }
}
