using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace Hoteles.DBData
{
    public static class ORM
    {
        public static hotelesEntities dbh = new hotelesEntities();

        // funcion de retorno de exceptiones sql
        public static string MensajesError(SqlException ex)
        {
            string mensaje;
            switch (ex.Number)
            {
                case -1: mensaje = "Error de conexion con el servidor"; break;
                case 547: mensaje = "Tiene datos relacionados"; break;
                case 2601: mensaje = "Datos duplicados"; break;
                case 2627: mensaje = "Datos duplicados"; break;
                case 4060: mensaje = "No se encuentra en la base de datos"; break;
                case 18456: mensaje = "Usuario o contraseña incorrectos"; break;
                default: mensaje = mensaje = ex.Number + " - " + ex.Message; break;
            }
            return mensaje;
        }

        // metodo de rollback action sobre tablas por ocurrencia de Excepcion
        public static void RejectChanges()
        {
            foreach (DbEntityEntry entry in dbh.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added: entry.State = EntityState.Detached; break;
                    case EntityState.Modified: entry.State = EntityState.Unchanged; break;
                    case EntityState.Deleted: entry.Reload(); break;
                    default: break;
                }
            }
        }

        // - - - - - ejecuta accion sobre tabla y controla ocurrencia de excepciones con rollback de accion realizada
        public static string SaveChanges()
        {
            string retumsj = "";
            try { dbh.SaveChanges(); }
            catch (DbUpdateException ex)
            {
                RejectChanges();
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                retumsj = MensajesError(sqlEx);
            }
            return retumsj;
        }
    }
}
