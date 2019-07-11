﻿using Model;
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
        public SistemaContext():base("DefaultConnection")
        {

        }

        public DbSet<Hospital> Hospitais;
        


    }
}
