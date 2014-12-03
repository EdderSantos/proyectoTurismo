using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace yaTodo
{
    class rellenarCombos
    {
        public static List<Ciudades> GellAllCiudades()
        {
            string sql = @"SELECT  nombreCiudad FROM modulos GROUP BY nombreCiudad ORDER BY nombreCiudad ASC";

            List<Ciudades> list = new List<Ciudades>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(LoadCiudad(reader));
                }

            }

            return list;
        }

        private static Ciudades LoadCiudad(IDataReader reader)
        {
            Ciudades item = new Ciudades(); 

            //item.idCiudad = Convert.ToInt32(reader["idCiudad"]);
            item.nombreCiudad = Convert.ToString(reader["nombreCiudad"]);

            return item;
        }


        //----------------------------------------------------------------
        public static List<Modulos> GellModulos(string nombreCiudad)
        {
            string sql = @"SELECT nombreModulo, nombreCiudad FROM modulos WHERE nombreCiudad = @nombreCiudad ORDER BY nombreModulo ASC";

            List<Modulos> list = new List<Modulos>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombreCiudad", nombreCiudad);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(cargarComboModulo(reader));
                }

            }

            return list;
        }

        private static Modulos cargarComboModulo(IDataReader reader)
        {
            Modulos item = new Modulos();

            
            item.nombreModulo = Convert.ToString(reader["nombreModulo"]);

            return item;
        }

    }
}
