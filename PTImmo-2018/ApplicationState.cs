using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTImmo_2018
{
	public static class ApplicationState
	{
		public static string id_bien;
		public static string id_vendeur;		
		public static string id_proposition;
		public static string id_acheteur;
		public static string id_visite;
		public static string id_souhait;
		public static string id_commercial;
        public static string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
    }
}
