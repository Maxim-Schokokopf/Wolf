using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeug_Verwaltung_Wolf
{
    class LKW : Fahrzeug
    {
        #region Variablen
        private float achsen;
        private double zuladung;
        #endregion
        #region Eigenschaften
        public float Achsen
        {
            get {return achsen; }
            set { achsen = value; }
        }
        public double Zuladung
        {
            get { return zuladung; }
            set { zuladung = value; }
        }
        #endregion
        #region Methode
        public override void SetzenWerteLKW(float Achsen, double Zuladung )
        {
            Achsen = achsen;
            Zuladung = zuladung;
        }
        #endregion
    }
}
