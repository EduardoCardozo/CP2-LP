using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_RepetiçãoEConceitosPOO
{
    class Empregado
    {
        public string primeiroNome;
        public string sobrenome;
        public double salario;

        public Empregado(string primeiroNome, string sobrenome, double salario)
        {
            this.primeiroNome = primeiroNome;
            this.sobrenome = sobrenome;
            if (salario < 0.0) this.salario = 0.0;
            else this.salario = salario;
        }
        public double Aumento()
        {
            return salario + salario *0.1;
        }
    }
}
