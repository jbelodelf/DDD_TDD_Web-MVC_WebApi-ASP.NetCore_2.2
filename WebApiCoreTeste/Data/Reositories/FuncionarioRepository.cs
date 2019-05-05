using Data.Contexts;
using Domain.Entities;
using Domain.Interfaces.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Reositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DbContextOptionsBuilder<DataBaseContext> _OptionsBuider;
        protected DataBaseContext _context = null;

        public FuncionarioRepository()
        {
            _OptionsBuider = new DbContextOptionsBuilder<DataBaseContext>();
            //_context = new DataBaseContext(_OptionsBuider.Options);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Funcionario>> Get()
        {
            using (var context = new DataBaseContext(_OptionsBuider.Options))
            {
                var retorno = await context.Funcionario.ToListAsync();
                return retorno;
            }
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
