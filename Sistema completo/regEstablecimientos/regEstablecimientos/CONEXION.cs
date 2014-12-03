using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace regEstablecimientoss
{
    class CONEXION
    {

        public static List<regEstablecimientos.COMBOS.Ciudad> GellAllCiudad()
        {
            string sql = @"SELECT nombreCiudad FROM localidades GROUP BY nombreCiudad ORDER BY nombreCiudad ASC";

            List<regEstablecimientos.COMBOS.Ciudad> list = new List<regEstablecimientos.COMBOS.Ciudad>();

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

        private static regEstablecimientos.COMBOS.Ciudad LoadCiudad(IDataReader reader)
        {
            regEstablecimientos.COMBOS.Ciudad item = new regEstablecimientos.COMBOS.Ciudad();

            item.nombreCiudad = Convert.ToString(reader["nombreCiudad"]);
            return item;
        }

        //**********************************************************************************//




        public static List<regEstablecimientos.COMBOS.Localidad> GellLocalidadByCiudad(string nombreCiudad)
        {
            string sql = @"SELECT nombreLocalidad  FROM localidades WHERE nombreCiudad = @nombreCiudad";

            List<regEstablecimientos.COMBOS.Localidad> list = new List<regEstablecimientos.COMBOS.Localidad>();

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



        private static regEstablecimientos.COMBOS.Localidad LoadLocalidad(IDataReader reader)
        {
            regEstablecimientos.COMBOS.Localidad item = new regEstablecimientos.COMBOS.Localidad();

            item.nombreLocalidad = Convert.ToString(reader["nombreLocalidad"]);
            return item;
        }

        public static List< regEstablecimientos.COMBOS.Localidades> GellAllLOCALIDAD()
        {
            string sql = @"SELECT nombreLocalidad FROM localidades GROUP BY nombreLocalidad ORDER BY nombreLocalidad ASC";

            List< regEstablecimientos.COMBOS.Localidades> list = new List< regEstablecimientos.COMBOS.Localidades>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(LoadLocalidades(reader));
                }

            }

            return list;
        }

        private static  regEstablecimientos.COMBOS.Localidades LoadLocalidades(IDataReader reader)
        {
             regEstablecimientos.COMBOS.Localidades item = new  regEstablecimientos.COMBOS.Localidades();

            item.nombreLocalidad = Convert.ToString(reader["nombreLocalidad"]);
            return item;
        }



    }


    }
