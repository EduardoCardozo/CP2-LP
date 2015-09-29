using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRH
{
    public class Gerente : Empregado
    {
        public string AreaDeGerencia { get; set; }
        public decimal ValorAdicionalSalario { get; set; }

        
        public decimal SalarioTotal
        {
            get
            {
                return this.Salario += ValorAdicionalSalario;
            }
            protected set { }
        }

        public override decimal ValeAlimentacao
        {
            get
            {
                valeAlimentacao = this.SalarioTotal * (6.5M / 100);

                if (valeAlimentacao > 750)
                {
                    return valeAlimentacao = 750;
                }
                else
                    return valeAlimentacao;
            }
            protected set { }
        } 


    }
}
