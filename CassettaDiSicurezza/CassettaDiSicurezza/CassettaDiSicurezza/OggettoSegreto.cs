using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class OggettoSegreto
    {
        private string id;
        public string Id {
            get {  return id; } 
            set { id = value; }
        }
        private double valoreDichiarato;
        public double ValoreDichiarato { 
            get { return valoreDichiarato;}
            set { valoreDichiarato = value;}
        }
        private double valoreAssicurato;
        public double ValoreAssicurato
        {
            get { return valoreAssicurato; }
            set { valoreAssicurato = value; }
        }

        public OggettoSegreto(string id, double valoreDichiarato)
        {
            this.id = id;
            this.valoreDichiarato = valoreDichiarato;
        }

        public virtual void CalcolaValoreAssicurato()
        {
            ValoreAssicurato = ValoreDichiarato;
        }
    }
}
