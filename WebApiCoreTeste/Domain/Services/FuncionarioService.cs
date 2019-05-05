using Domain.Entities;
using Domain.Interfaces.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private IFuncionarioRepository _repository;
        public FuncionarioService(IFuncionarioRepository repository)
        {
            _repository = repository;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Task<List<Funcionario>> Get()
        {
            return _repository.Get();
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
