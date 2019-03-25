using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeug_Verwaltung_Wolf
{
   public abstract class Fahrzeug
    {
        #region Variablen
        protected string hersteller;
        protected string model;
        protected string kennzeichen;
        protected DateTime zulassungsjahr;
        protected int anschaffungspreis;
        #endregion
        #region Eigenschaften
        public Fahrzeug()
        {
            zulassungsjahr = new DateTime();
        }

        public string Hersteller
        {
            get { return hersteller; }
            set { hersteller = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }
        #endregion
        #region Methoden
        public virtual void SetzenWertePKW(double hubraum, int schadstoffklasse)
        {
            
        }
        public virtual void SetzenWerteLKW(float Achsen, double Zuladung)
        {

        }
        public virtual void SetzenWerteMotorrad(double Hubraum)
        {

        }
        #endregion

    }
}
