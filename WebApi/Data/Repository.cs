using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public class Repository : IRepository
    {

        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Aluno[]> GetAllAlunosAsync()
        {
            IQueryable<Aluno> query = _context.Alunos;

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }
        public async Task<Aluno> GetAlunoAsyncById(int alunoId)
        {
            IQueryable<Aluno> query = _context.Alunos;

            query = query.AsNoTracking()
                         .OrderBy(aluno => aluno.Id)
                         .Where(aluno => aluno.Id == alunoId);

            return await query.FirstOrDefaultAsync();
        }







    }
}
