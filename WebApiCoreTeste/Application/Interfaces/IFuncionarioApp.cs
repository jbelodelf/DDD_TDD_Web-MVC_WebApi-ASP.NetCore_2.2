using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFuncionarioApp
    {
        Task<List<Funcionario>> Get();

        void Insert();

        void Update();

        void Delete();
    }
}
