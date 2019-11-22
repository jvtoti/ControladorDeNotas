using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDeNotas.entidade
{
    public class Aluno
    {
        public Int32 alunoId { get; set; }
        public String nome { get; set; }
        public String ra { get; set; }
        public Decimal notaB1 { get; set; }
        public Decimal notaB2 { get; set; }
        public Decimal notaPim { get; set; }
    }
}
