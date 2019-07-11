using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataBase
{
    public class SistemaContext : DbContext
    {
        public DbSet<Hospital> Hospitais;


    }
}
