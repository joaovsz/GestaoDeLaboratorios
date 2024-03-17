using GestaoDeLaboratorios.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace GestaoDeLaboratorios.DAL
{
    public class InfnetDbContext : DbContext { 
        public InfnetDbContext(DbContextOptions options): base(options) { }
        public DbSet<Computador> Computadores { get; set; }
        
    }
}
