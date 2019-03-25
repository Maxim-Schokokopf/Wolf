using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeug_Verwaltung_Wolf
{
    class Fahrzeugpool
    {
        #region Varioablen
        List<Fahrzeug> fahrzeuge = new List<Fahrzeug>();
        #endregion
        #region Methoden
        public Fahrzeugpool()
        {
        
        }

        public void Pkwhinzufügen()
        {
            fahrzeuge.Add(new PKW());

            fahrzeuge[fahrzeuge.Count - 1].SetzenWertePKW(1200, 1); // Hubraum, Leistung , Schadstoffklasse Werte aus der Formeingabe 

        }
        public void LKWhinzufügen()
        {
            fahrzeuge.Add(new LKW());
            fahrzeuge[fahrzeuge.Count - 1].SetzenWerteLKW(1200, 1);
        }
        public void Motorradhinzufügen()
        {
            fahrzeuge.Add(new Motorrad());
            fahrzeuge[fahrzeuge.Count - 1].SetzenWerteMotorrad(1200);
        }
        #endregion
    }
}
