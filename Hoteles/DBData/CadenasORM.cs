using System.Collections.Generic;
using System.Linq;

namespace Hoteles.DBData
{
    public static class CadenasORM
    {
        // - - - - - retorna lista de cadenas
        public static List<cadenas> SelectAllCadenas()
        {
            List<cadenas> _cadenas = (from d in DBData.ORM.dbh.cadenas
                                        orderby d.nombre
                                        select d
                                          ).ToList();
            return _cadenas;
        }
    }
}

