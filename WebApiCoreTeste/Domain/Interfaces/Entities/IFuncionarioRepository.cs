using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Entities
{
    public interface IFuncionarioRepository
    {
        Task<List<Funcionario>> Get();

        void Insert();

        void Update();

        void Delete();
    }
}
