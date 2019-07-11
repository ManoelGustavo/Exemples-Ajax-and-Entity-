using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository.Interfaces
{
    interface IHospitalRepository
    {
        List<Hospital> ObtertTodos(string busca);

        int Inserir(Hospital hospital);

        bool Alterar(Hospital hospital);

        Hospital ObterPeloId(int id);

        bool Apagar(int id);
    }
}
