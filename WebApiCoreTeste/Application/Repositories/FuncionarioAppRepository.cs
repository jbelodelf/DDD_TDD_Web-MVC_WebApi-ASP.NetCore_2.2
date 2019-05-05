using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class FuncionarioAppRepository : IFuncionarioApp
    {
        private IFuncionarioService _service;

        public FuncionarioAppRepository(IFuncionarioService service)
        {
            _service = service;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Task<List<Funcionario>> Get()
        {
            return _service.Get();
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
