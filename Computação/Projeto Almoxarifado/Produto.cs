using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Almoxarifado
{
    class Produto
    {
        public string nome, fornecedor;
        public int quantidade, x;
        public float valor;

          
        public Produto()
        {
            nome = "";
            fornecedor = "";
            quantidade = 0;
            valor = 0;
            x = 0;
          
        }

        public void Adicionar()
        {
            quantidade = quantidade + x;
        }

        public void Retirar()
        {
            quantidade = quantidade - x;
        }

        public void Deletar()
        {

        }

        public void Valor()
        {
            valor = quantidade * valor;
        }
    }

}
