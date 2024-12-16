using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class Chiave : OggettoSegreto
    {
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Chiave(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            this.tipo = tipo;
            CalcolaValoreAssicurato();
        }

        public override void CalcolaValoreAssicurato()
        {
            ValoreAssicurato = ValoreDichiarato * 1000;
        }
    }
}
