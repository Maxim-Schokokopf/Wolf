using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeug_Verwaltung_Wolf
{
    class Parkhaus
    {
        #region Variablen
        private string ort;
        private string straße;
        private string plz;
        private string parkplatznummer;
        private int parkplatzart;
        #endregion
        #region Eigenschaften
        public string Ort
        {
            get { return ort; }
            set { ort = value; }
        }

        public string Plz
        {
            get { return plz; }
            set { plz = value; }
        }

        public string Parkplatznummer
        {
            get { return parkplatznummer; }
            set { parkplatznummer = value; }
        }

        public int Parkplatzart
        {
            get { return parkplatzart; }
            set { parkplatzart = value; }
        }

        public string Straße
        {
            get { return straße; }
            set { straße = value; }
        }
        #endregion
        #region Methoden
        //abstract ParkplatzHinzufügen()
        //{
           
        //}
        #endregion
    }

}
