using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCalculoSalario.Model;

namespace TDDCalculoSalario
{
    public class CalculadoraSalario
    {
        public double CalcularSalario(Funcionario funcionario)
        {
            return funcionario.Cargo.Regra.Calcula(funcionario);
        }
    }
}