using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeug_Verwaltung_Wolf
{
    class Motorrad : Fahrzeug
    {
        #region Variablen
        private double hubraum;
        #endregion 
        #region Eigenschaften
        public double Hubraum
        {
            get { return hubraum; }
            set { hubraum = value; }
        }
        #endregion
        #region Methoden
        public override void SetzenWerteMotorrad(double hubraum)
        {
            Hubraum = hubraum;
        }
        #endregion



    }
}
