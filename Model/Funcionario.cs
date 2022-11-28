using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCalculoSalario.Model
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Cargo Cargo { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, double salario, Cargo cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        //public Funcionario(double salario)
        //{
        //    Nome = "Ricardo";
        //    Salario = salario;
        //    Cargo = Cargo.DESENVOLVEDOR;
        //}
    }
}