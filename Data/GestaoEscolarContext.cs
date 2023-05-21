using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestãoEscolar.Models;

namespace GestaoEscolar.Data
{
    public class GestaoEscolarContext : DbContext
    {
        public GestaoEscolarContext (DbContextOptions<GestaoEscolarContext> options)
            : base(options)
        {
        }

        public DbSet<GestãoEscolar.Models.Alunos> Alunos { get; set; } = default!;
    }
}
