using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace reporteByCiudad
{
    class rellenarCombo
    {

        public static List<Ciudades> GellAllCiudades()
        {
            string sql = @"SELECT idCiudad, nombreCiudad FROM ciudades WHERE nombreEstado='COAHUILA' ORDER BY nombreCiudad ASC";

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

            item.idCiudad = Convert.ToInt32(reader["idCiudad"]);
            item.nombreCiudad = Convert.ToString(reader["nombreCiudad"]);

            return item;
        }
    }
}
