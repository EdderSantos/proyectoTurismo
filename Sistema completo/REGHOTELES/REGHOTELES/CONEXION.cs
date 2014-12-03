using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace REGHOTELES
{
    class CONEXION
    {

        public static List<REGHOTELES.COMBOS.Ciudad> GellAllCiudad()
        {
            string sql = @"SELECT nombreCiudad FROM localidades GROUP BY nombreCiudad ORDER BY nombreCiudad ASC";

            List<REGHOTELES.COMBOS.Ciudad> list = new List<REGHOTELES.COMBOS.Ciudad>();

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

        private static REGHOTELES.COMBOS.Ciudad LoadCiudad(IDataReader reader)
        {
            REGHOTELES.COMBOS.Ciudad item = new REGHOTELES.COMBOS.Ciudad();

            item.nombreCiudad = Convert.ToString(reader["nombreCiudad"]);
            return item;
        }

        //**********************************************************************************//




        public static List<REGHOTELES.COMBOS.Localidad> GellLocalidadByCiudad(string nombreCiudad)
        {
            string sql = @"SELECT nombreLocalidad  FROM localidades WHERE nombreCiudad = @nombreCiudad";

            List<REGHOTELES.COMBOS.Localidad> list = new List<REGHOTELES.COMBOS.Localidad>();

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



        private static REGHOTELES.COMBOS.Localidad LoadLocalidad (IDataReader reader)
        {
            REGHOTELES.COMBOS.Localidad item = new REGHOTELES.COMBOS.Localidad();

            item.nombreLocalidad = Convert.ToString(reader["nombreLocalidad"]);
            return item;
        }

        //********************************************************************************




        public static List<REGHOTELES.COMBOS.Categoria> GellCategoriaByCiudad(string nombreCiudad)
        {
            string sql = @"SELECT categoria FROM regHoteles WHERE nombreCiudad=@nombreCiudad GROUP BY categoria";

            List<REGHOTELES.COMBOS.Categoria> list = new List<REGHOTELES.COMBOS.Categoria>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombreCiudad", nombreCiudad);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(LoadCategoria(reader));
                }

            }


            return list;
        }

        private static REGHOTELES.COMBOS.Categoria LoadCategoria(IDataReader reader)
        {
            REGHOTELES.COMBOS.Categoria item = new REGHOTELES.COMBOS.Categoria();

            item.categoria = Convert.ToString(reader["categoria"]);
            return item;
        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static List<REGHOTELES.COMBOS.Localidades> GellAllLOCALIDAD()
        {
            string sql = @"SELECT nombreLocalidad FROM localidades GROUP BY nombreLocalidad ORDER BY nombreLocalidad ASC";

            List<REGHOTELES.COMBOS.Localidades> list = new List<REGHOTELES.COMBOS.Localidades>();

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

        private static REGHOTELES.COMBOS.Localidades LoadLocalidades(IDataReader reader)
        {
            REGHOTELES.COMBOS.Localidades item = new REGHOTELES.COMBOS.Localidades();

            item.nombreLocalidad = Convert.ToString(reader["nombreLocalidad"]);
            return item;
        }

        //*******************
        public static List<REGHOTELES.COMBOS.CategoriaLoc> GellCategoriaByLocalidad(string nombreLocalidad)
        {
            string sql = @"SELECT categoria FROM regHoteles WHERE nombreLocalidad=@nombreLocalidad GROUP BY categoria ";

            List<REGHOTELES.COMBOS.CategoriaLoc> list = new List<REGHOTELES.COMBOS.CategoriaLoc>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombreLocalidad", nombreLocalidad);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(LoadCategoriaLoc(reader));
                }

            }


            return list;
        }

        private static REGHOTELES.COMBOS.CategoriaLoc LoadCategoriaLoc(IDataReader reader)
        {
            REGHOTELES.COMBOS.CategoriaLoc item = new REGHOTELES.COMBOS.CategoriaLoc();

            item.categoria = Convert.ToString(reader["categoria"]);
            return item;
        }




        internal static object GellAllLocalidades()
        {
            throw new NotImplementedException();
        }

        internal static object GellCategoriaByLoc(string nombreLocalidad)
        {
            throw new NotImplementedException();
        }
    }
}

