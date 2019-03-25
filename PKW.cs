using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeug_Verwaltung_Wolf
{
    class PKW : Fahrzeug
    {
        
        private double hubraum;
        private double leistung;
        private int schadstoffklasse;

        #region Eigenschaften
        public double Hubraum
        {
            get { return hubraum; }
            set { hubraum = value; }

        }
        public double Leistung
        {
            get { return leistung; }
            set { leistung = value; }
        }
        public int Schadstoffklasse
        {
            get { return schadstoffklasse; }
            set { schadstoffklasse = value; }
        }
#endregion
        public override void SetzenWertePKW(double hubraum, int schadstoffklasse)
        {
            Hubraum = hubraum;
            Leistung = leistung;
            Schadstoffklasse = schadstoffklasse;
            
        }
        

    }
}
