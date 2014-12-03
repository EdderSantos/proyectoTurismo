using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace proyectoTurismo
{
    class rellenarCombosRegModulo
    {

        public static List<moduloCiudad> GellAllciudadModulo()
        {
            string sql = @"SELECT nombreCiudad FROM modulos GROUP BY nombreCiudad ORDER BY nombreCiudad ASC";

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


        //----------------------------------------------------------
        public static List<modulo> GellModuloByCiudad(string nombreCiudad)
        {
            string sql = @"SELECT nombreModulo, nombreCiudad FROM modulos WHERE nombreCiudad = @nombreCiudad ORDER BY nombreModulo ASC";

            List<modulo> list = new List<modulo>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombreCiudad", nombreCiudad);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(cargarModulo(reader));
                }

            }

            return list;
        }

        private static modulo cargarModulo(IDataReader reader)
        {
            modulo item = new modulo();

            item.nombreModulo = Convert.ToString(reader["nombreModulo"]);

            return item;
        }


        //--------------------------------------------------------

        public static List<operativo> GellAllOperativo()
        {
            string sql = @"SELECT nombreOperativo FROM operativos ORDER BY nombreOperativo ASC";

            List<operativo> list = new List<operativo>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(cargarOperativos(reader));
                }

            }

            return list;
        }

        private static operativo cargarOperativos(IDataReader reader)
        {
            operativo item = new operativo();

            item.nombreOperativo = Convert.ToString(reader["nombreOperativo"]);

            return item;
        }

        //----------------------------------------------

        public static List<pais> GellAllPaises()
        {
            string sql = @"SELECT nombrePais FROM paises WHERE nombrePais <> 'MÉXICO' ORDER BY nombrePais ASC ";

            List<pais> list = new List<pais>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(cargarPaises(reader));
                }

            }

            return list;
        }

        private static pais cargarPaises(IDataReader reader)
        {
            pais item = new pais();

            item.nombrePais = Convert.ToString(reader["nombrePais"]);

            return item;
        }


        //----------------------------------------------

        public static List<paisMexico> GellAllPaisMexico()
        {
            string sql = @"SELECT nombrePais FROM paises WHERE nombrePais = 'MÉXICO' ORDER BY nombrePais ASC ";

            List<paisMexico> list = new List<paisMexico>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(cargarPaisMexico(reader));
                }

            }

            return list;
        }

        private static paisMexico cargarPaisMexico(IDataReader reader)
        {
            paisMexico item = new paisMexico();

            item.nombrePais = Convert.ToString(reader["nombrePais"]);

            return item;
        }

        //----------------------------------------------------------
        public static List<estadoPais> GellEstadoByPais(string nombrePais)
        {
            string sql = @"SELECT nombreEstado, nombrePais FROM estados WHERE nombrePais = @nombrePais ORDER BY nombrePais ASC";

            List<estadoPais> list = new List<estadoPais>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombrePais", nombrePais);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(cargarEstadoByPais(reader));
                }

            }

            return list;
        }

        private static estadoPais cargarEstadoByPais(IDataReader reader)
        {
            estadoPais item = new estadoPais();

            item.nombreEstado = Convert.ToString(reader["nombreEstado"]);

            return item;
        }


        //----------------------------------------------------------
        public static List<ciudadEstado> GellCiudadByPais(string nombreEstado)
        {
            string sql = @"SELECT nombreCiudad, nombreEstado FROM ciudades WHERE nombreEstado = @nombreEstado ORDER BY nombreCiudad ASC";

            List<ciudadEstado> list = new List<ciudadEstado>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombreEstado", nombreEstado);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(cargarCiudadByEstado(reader));
                }

            }

            return list;
        }

        private static ciudadEstado cargarCiudadByEstado(IDataReader reader)
        {
            ciudadEstado item = new ciudadEstado();

            item.nombreCiudad = Convert.ToString(reader["nombreCiudad"]);

            return item;
        }




    }
}
