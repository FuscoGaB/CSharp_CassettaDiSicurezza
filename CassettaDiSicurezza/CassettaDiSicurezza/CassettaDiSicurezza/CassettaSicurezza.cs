using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class CassettaSicurezza
    {
        private string seriale;
        public string Seriale
        {
            get { return seriale; }
            set { seriale = value; }
        }

        private string produttore;
        public string Produttore
        {
            get { return produttore; }
            set { produttore = value; }
        }

        private string codiceSblocco;
        private string CodiceSblocco
        {
            get { return codiceSblocco; }
            set { codiceSblocco = value; }
        }

        private string pin;
        private string PIN
        {
            get { return pin; }
            set { pin = value; }
        }

        private OggettoSegreto oggetto;
        public OggettoSegreto Oggetto
        {
            get { return oggetto; }
            private set { oggetto = value; }
        }

        public CassettaSicurezza(string seriale, string produttore, string codiceSblocco, string pin)
        {
            this.seriale = seriale;
            this.produttore = produttore;
            this.codiceSblocco = codiceSblocco;
            this.pin = pin;
        }

        public bool Vuota()
        {
            return Oggetto == null;
        }

        public void InserisciOggetto(OggettoSegreto oggetto, string pin)
        {
            if (PIN != pin)
            {
                Console.WriteLine("Errore: PIN errato!");
                return;
            }
            if (Oggetto != null)
            {
                Console.WriteLine("Errore: Cassetta già occupata!");
                return;
            }
            Oggetto = oggetto;
        }

        public OggettoSegreto RimuoviOggetto(string pin)
        {
            if (PIN != pin)
            {
                Console.WriteLine("Errore: PIN errato!");
                return null;
            }
            OggettoSegreto oggetto = Oggetto;
            return oggetto;
        }

        public void ModificaPIN(string nuovoPIN, string codiceSblocco)
        {
            if (CodiceSblocco != codiceSblocco)
            {
                Console.WriteLine("Errore: Codice di sblocco errato.");
                return;
            }
            PIN = nuovoPIN;
        }
    }
}
