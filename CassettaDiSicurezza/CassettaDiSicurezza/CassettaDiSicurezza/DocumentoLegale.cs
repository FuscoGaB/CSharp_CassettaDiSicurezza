using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class DocumentoLegale : OggettoSegreto
    {
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public DocumentoLegale(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            this.tipo = tipo;
            CalcolaValoreAssicurato();
        }

        public override void CalcolaValoreAssicurato()
        {
            if (ValoreDichiarato >= 100)
                ValoreAssicurato = ValoreDichiarato;
            else
                ValoreAssicurato = 50;
        }
    }
}
