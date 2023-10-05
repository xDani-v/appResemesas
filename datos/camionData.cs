using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class camionData
    {
        public static List<ListarCamionesDisponiblesResult> listarCamionesDisponible()
        {
            DataRemesaDataContext BD = null;
            try
            {
                using (BD = new DataRemesaDataContext())
                {
                    return BD.ListarCamionesDisponibles().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar camion capa datos", ex);
            }
            finally
            {
                BD = null;
            }
        }

        public static List<ListarTodosLosCamionesResult> listarCamiones()
        {
            DataRemesaDataContext BD = null;
            try
            {
                using (BD = new DataRemesaDataContext())
                {
                    return BD.ListarTodosLosCamiones().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar autorcamiones capa datos", ex);
            }
            finally
            {
                BD = null;
            }
        }

        public static void insertCamion(camion op)
        {
            DataRemesaDataContext db = null;

            try
            {
                using (db = new DataRemesaDataContext())
                {
                    db.AgregarCamion(op.TamañoCarga,op.Chofer,op.EstadoCamion);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar autor capa datos", ex);
            }
            finally
            {
                db = null;
            }
        }

    }
}
