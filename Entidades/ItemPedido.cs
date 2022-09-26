using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint02.Entidades
{
    internal class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public Produto Produto { get; set; }

        public Funcionario Funcionario { get; set; }


        public double SubTotal()
        {
            return Valor * Quantidade;
        }

        public override string ToString()
        {
            return $"{Produto} x {Quantidade}: {SubTotal()}";
        }
    }
}
