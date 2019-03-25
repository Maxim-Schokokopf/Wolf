using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeug_Verwaltung_Wolf
{
    class Parkplatz
    {
        #region Variablen
        private string typ;
        private string stellplatznummer;
        #endregion
        #region Eigenschaften
        public string Typ
        {
            get { return typ; }
        }

        public string Stellplatznummer
        {
            get { return stellplatznummer; }
            set { stellplatznummer = value; }
        }
        #endregion
    }
}
