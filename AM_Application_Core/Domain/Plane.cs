using System;
namespace AM_Application_Core.Domain
{

    // 2eme methode
    /*public enum PlaneType
    {
        Boing, Airbus
    }
    */

    public class Plane
	{
        /*
        #region exemple
        public int capacite;
		public int getCapacite { get { return capacite; } }
		public void setCapacite (int capacite ) {this.capacite = capacite ; }
        #endregion

        #region exp
        //version lite : prop+2tab
        public int Myproperty { get; set; }

		//version secure : propg+2tab
		public int myroprety { get; private set ;}

        //version full:propfull+2tab

        #endregion
        */



        #region] prop_de_base
        public int Capacite { get; set; }
        public DateTime ManuFactureDate { get; set; }
        public int PlanedId { get; set; }
        public PlaneType PlaneTypee { get; set; }
        #endregion



        #region prop_de_navigation
        public IList<Flight> Flights { get; set; }

        #endregion





        /*public Plane(int capacite, DateTime manuFactureDate)
        {
            Capacite = capacite;
            ManuFactureDate = manuFactureDate;
        }*/


    }
}

