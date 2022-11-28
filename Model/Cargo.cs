using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCalculoSalario;

namespace TDDCalculoSalario.Model
{
    public class Cargo
    {
        public Cargo DESENVOLVEDOR => new Cargo(new DezOuVintePorCento());

        public Cargo DBA => new Cargo(new QuinzeOuVinteCincoPorCento());

        public Cargo TESTADOR => new Cargo(new QuinzeOuVinteCincoPorCento());

        public IRegraDeCalculo Regra { get; private set; }

        private Cargo(IRegraDeCalculo regra)
        {
            Regra = regra;
        }
    }
}