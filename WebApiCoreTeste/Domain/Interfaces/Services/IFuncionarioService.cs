using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IFuncionarioService
    {
        Task<List<Funcionario>> Get();

        void Insert();

        void Update();

        void Delete();
    }
}
