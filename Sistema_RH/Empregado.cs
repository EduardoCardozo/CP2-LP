
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRH
{
    public class Empregado : Funcionario 
    {
        protected decimal valeAlimentacao;

        public virtual decimal ValeAlimentacao
        {
           
            get
            {
                valeAlimentacao = this.Salario * (8 / 100);
                if (valeAlimentacao > 750)
                {
                    return 750;
                }
                else
                {
                    return valeAlimentacao;
                }
            }
            protected set { }
        }

    }
}
