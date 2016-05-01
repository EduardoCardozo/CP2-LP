using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_RepetiçãoEConceitosPOO
{
    class Data
    {
        public int dia;     
        public int mes;
        public int ano;

        public Data(int dia, int mes, int ano)
        {
            if (dia < 32 && dia > 0)
                this.dia = dia;
            if (mes > 0 && mes < 13)
                this.mes = mes;
            if (ano > -1)
                this.ano = ano;
        }
        public string toString()
        {
            string data = "{0}/{1}/{2}";

            return String.Format(data, dia, mes, ano); 
        }
        public void AvancarData()
        {
            int[] diasDoMes = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (diasDoMes[mes - 1] == dia)
            {
                dia = 1;
                if (mes == 12)
                {
                    mes = 1;
                    ano += 1;
                }
                else
                    mes += 1;
            }
            else dia += 1;                
        }
    }
}
