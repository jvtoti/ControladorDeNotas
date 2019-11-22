using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDeNotas.entidade
{
    public class ControladorDeNotasContexto : DbContext
    {
            public ControladorDeNotasContexto()
                : base(nameOrConnectionString: "ControladorDeNotas")
            {
               // Database.SetInitializer<ControladorDeNotasContexto>(new ControladorDeNotasContextoInitializer());
            }
            public DbSet<Aluno> alunos { get; set; }

        }
        public class ControladorDeNotasContextoInitializer :
            DropCreateDatabaseAlways<ControladorDeNotasContexto>
        {

        }
    }

