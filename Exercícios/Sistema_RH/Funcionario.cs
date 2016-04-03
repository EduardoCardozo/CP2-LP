using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRH
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public DateTime DataDeNacimento { get; set; }
        public virtual decimal Salario { get; set; }
        public string Matricula { get; set; }
        

    }
}
