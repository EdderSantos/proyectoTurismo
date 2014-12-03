using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace proyectoTurismo.Operativos
{
    public partial class nuevoOperativo : Form
    {
        public nuevoOperativo()
        {
            InitializeComponent();
        }

        private void nuevoOperativo_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
              string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            if (string.IsNullOrEmpty(txtNuevoOp.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                //validartextos();
                MessageBox.Show("falta un campo");
            }
            else
            {

                //validartextos();

                //string sql = "Insert into registroAlumno(matricula,nombre,direccion,telefono,foto) values(@matricula,@nombre,@direccion,@telefono,@foto)";
                string sql = "if exists(select nombreOperativo from operativos where nombreOperativo= @nombreOperativo) update operativos set nombreOperativo=@nombreOperativo,descripcionOperativo=@descripcionOperativo where nombreOperativo=@nombreOperativo else insert into operativos (nombreOperativo,descripcionOperativo) values (@nombreOperativo,@descripcionOperativo)";
                SqlConnection conexion = new SqlConnection(miCadenaConexion);
                SqlCommand comando = new SqlCommand(sql, conexion);

                try
                {
                    conexion.Open();
                    comando.Parameters.AddWithValue("@nombreOperativo", txtNuevoOp.Text);
                    comando.Parameters.AddWithValue("@descripcionOperativo", txtDescripcion.Text);
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Se han agregado los datos correctamente");
                    //LimpiarControles();

                }


                finally
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



    }
}
