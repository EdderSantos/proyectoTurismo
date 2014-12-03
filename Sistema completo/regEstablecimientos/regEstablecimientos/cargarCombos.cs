using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace regEstablecimientos
{
    class cargarCombos
    {
        public static List<regEstablecimientos.entidades.Ciudad> GellAllCiudad()
        {
            string sql = @"SELECT nombreCiudad FROM localidades GROUP BY nombreCiudad ORDER BY nombreCiudad ASC";

            List<regEstablecimientos.entidades.Ciudad> list = new List<regEstablecimientos.entidades.Ciudad>();

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

        private static regEstablecimientos.entidades.Ciudad LoadCiudad(IDataReader reader)
        {
            regEstablecimientos.entidades.Ciudad item = new regEstablecimientos.entidades.Ciudad();

            item.nombreCiudad = Convert.ToString(reader["nombreCiudad"]);
            return item;
        }

        //**********************************************************************************//




        public static List<regEstablecimientos.entidades.Localidad> GellLocalidadByCiudad(string nombreCiudad)
        {
            string sql = @"SELECT nombreLocalidad  FROM localidades WHERE nombreCiudad = @nombreCiudad";

            List<regEstablecimientos.entidades.Localidad> list = new List<regEstablecimientos.entidades.Localidad>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombreCiudad", nombreCiudad);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(LoadLocalidad(reader));
                }

            }

            return list;
        }



        private static regEstablecimientos.entidades.Localidad LoadLocalidad(IDataReader reader)
        {
            regEstablecimientos.entidades.Localidad item = new regEstablecimientos.entidades.Localidad();

            item.nombreLocalidad = Convert.ToString(reader["nombreLocalidad"]);
            return item;
        }


    }
}
