using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Prestamo
    {
		
		//Atributos | Estructura de la tabla Prestamo

		public int idPre { get; set; }
		public string codP { get; set; }
		public string ced { get; set; }
		public decimal monto { get; set; }
		public int inte { get; set; }
        public int temp { get; set; }
        public decimal cuo { get; set; }
		public decimal deu { get; set; }
		
	}
}
