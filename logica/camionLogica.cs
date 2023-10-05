using datos;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class camionLogica
    {
        public List<camion> viewCamiones()
        {
            List<camion> lista = new List<camion>();
            camion op = null;
            try
            {
                List<ListarTodosLosCamionesResult> auxlista = camionData.listarCamiones();
                foreach (ListarTodosLosCamionesResult obj in auxlista)
                {
                    op = new camion(obj.IdCamion, (decimal)obj.TamañoCarga, obj.Chofer, obj.EstadoCamion);
                    lista.Add(op);
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar camions capa negocio:" + ex);
            }
        }

        public List<camion> viewCamionesDisponible()
        {
            List<camion> lista = new List<camion>();
            camion op = null;
            try
            {
                List<ListarCamionesDisponiblesResult> auxlista = camionData.listarCamionesDisponible();
                foreach (ListarCamionesDisponiblesResult obj in auxlista)
                {
                    op = new camion(obj.IdCamion, (decimal)obj.TamañoCarga, obj.Chofer);
                    lista.Add(op);
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar camions capa negocio:" + ex);
            }
        }

        public bool createCamion(camion op)
        {
            try
            {
                camionData.insertCamion(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Autor capa negocio:" + ex);
            }
        }


    }
}
