using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options): base(options)
        {

        }
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        //DBSet-Modelo-BaseDatos-getset
    }
}
