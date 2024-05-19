using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySubject.Core.DTO;
using UniversitySubject.Core.IRepositories;
using UniversitySubject.Infrastructure.DBConection;

namespace UniversitySubject.Infrastructure.Repo
{
    internal class GenericRepo<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDBContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepo(ApplicationDBContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }
        public async  Task<GenericResponseDTO> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return new GenericResponseDTO { Success = true, Message = "Entity added successfully." };
        }

        public async Task<GenericResponseDTO> Delete(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return new GenericResponseDTO { Success = true, Message = "Entity removed successfully." };
        }

        public async Task<IEnumerable<T?>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
