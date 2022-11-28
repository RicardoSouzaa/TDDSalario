using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCalculoSalario.Model;

namespace TDDCalculoSalario
{
    public interface IRegraDeCalculo
    {
        double Calcula(Funcionario funcionario);
    }

    public class DezOuVintePorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.Salario > 3000 ? funcionario.Salario * 0.8 : funcionario.Salario * 0.9;
        }
    }

    public class QuinzeOuVinteCincoPorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.Salario < 2500 ? funcionario.Salario * 0.85 : funcionario.Salario * 0.75;
        }
    }
}