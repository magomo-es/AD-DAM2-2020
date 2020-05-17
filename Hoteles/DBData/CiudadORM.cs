using System.Collections.Generic;
using System.Linq;

namespace Hoteles.DBData
{
    public static class CiudadORM
    {
        // - - - - - retorna lista de ciudades
        public static List<ciudades> SelectAllCiudades()
        {
            List<ciudades> _ciudades = (from c in DBData.ORM.dbh.ciudades
                                      orderby c.nombre
                                      select c
                                          ).ToList();
            return _ciudades;
        }
    }
}
