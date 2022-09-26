using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint02.Entidades
{
    internal class Funcionario
    {

        public String Nome { get; set; }

        public String Matricula { get; set; }

        public double Salario { get; set; }


        public override string ToString()
        {
            return $" {Nome} | {Matricula} | {Salario} " ;
        }

      





    }
}
