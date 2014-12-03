using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace proyectoTurismo
{
    class cargarComboModulos
    {
        public static List<moduloCiudad> GellAllciudadModulo()
        {
            string sql = @"SELECT nombreCiudad FROM ciudades WHERE nombreEstado='COAHUILA' GROUP BY nombreCiudad ORDER BY nombreCiudad ASC";

            List<moduloCiudad> list = new List<moduloCiudad>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(cargarCiudadModulo(reader));
                }

            }

            return list;
        }

        private static moduloCiudad cargarCiudadModulo(IDataReader reader)
        {
            moduloCiudad item = new moduloCiudad();

            item.nombreCiudad = Convert.ToString(reader["nombreCiudad"]);

            return item;
        }
    }
}
