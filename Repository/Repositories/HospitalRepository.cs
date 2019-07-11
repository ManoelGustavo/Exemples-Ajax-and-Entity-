using Model;
using Repository.DataBase;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        public SistemaContext context;

        //Construtor
        public HospitalRepository()
        {
            //Instancia um objeto da classse sistema context que nos permite ter acesso as tabelas do banco de dados
            context = new SistemaContext();
        }

        public bool Alterar(Hospital hospital)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Hospital hospital)
        {
            context.Hospitais.Add(hospital);
            context.SaveChanges();
            return hospital.Id;
        }

        public Hospital ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hospital> ObtertTodos(string busca)
        {
            throw new NotImplementedException();
        }
    }
}
