using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_RepetiçãoEConceitosPOO
{
    class Pedido
    {
        public int n_item;
        public string descricao;
        public int qtdComprada;
        public double preco;

        public Pedido(int n_item, string descricao, int qtd, double preco)
        {
            this.n_item = n_item;
            this.descricao = descricao;
            if (qtd < 1) qtdComprada = 1;
            else qtdComprada = qtd;

            if (preco < 0.0) this.preco = 0.0;
            else this.preco = preco;
        }
        public double ValorTotal()
        {
            return qtdComprada * preco;
        }
    }
}
