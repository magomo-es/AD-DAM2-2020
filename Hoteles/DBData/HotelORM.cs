using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace Hoteles.DBData
{
    public static class HotelORM
    {
        // - - - - - retorna lista de hoteles
        public static List<hoteles> SelectAllhoteles()
        {
            List<hoteles> _hoteles = (from h in DBData.ORM.dbh.hoteles
                                          orderby h.nombre
                                          select h
                                          ).ToList();
            return _hoteles;
        }

        // - - - - - retorna lista de hoteles por ciudad
        public static List<hoteles> SelectHotelesByCiudad(int idciudad)
        {
            List<hoteles> _hoteles = (from h in DBData.ORM.dbh.hoteles
                                      orderby h.nombre
                                      where h.id_ciudad.Equals(idciudad)
                                      select h
                                      ).ToList();
            return _hoteles;
        }

        // - - - - - inserta un hotel el la tabla
        public static string InsertaHotel(hoteles hotel)
        {
            ORM.dbh.hoteles.Add(hotel);
            return DBData.ORM.SaveChanges();
        }

        // - - - - - inserta un hotel el la tabla
        public static string ModificaHotel(hoteles hotel)
        {
            hoteles h = DBData.ORM.dbh.hoteles.Find(hotel.id_ciudad, hotel.nombre);
            h = hotel;
            return DBData.ORM.SaveChanges();
        }

        // - - - - - elimina un hotel de la tabla
        public static string DeleteHotel(hoteles hotel)
        {
            ORM.dbh.hoteles.Remove(hotel);
            return DBData.ORM.SaveChanges();
        }
    }
}
