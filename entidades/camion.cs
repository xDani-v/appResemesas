using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class camion
    {

        public int IdCamion { get; set; }
        public decimal TamañoCarga { get; set; }
        public string Chofer { get; set; }
        public string EstadoCamion { get; set; }

        // Constructor vacío
        public camion()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con parámetros para inicializar todas las propiedades
        public camion(int idCamion, decimal tamañoCarga, string chofer, string estadoCamion)
        {
            IdCamion = idCamion;
            TamañoCarga = tamañoCarga;
            Chofer = chofer;
            EstadoCamion = estadoCamion;
        }

        public camion(int idCamion, decimal tamañoCarga, string chofer)
        {
            IdCamion = idCamion;
            TamañoCarga = tamañoCarga;
            Chofer = chofer;
   
        }

    }
}
