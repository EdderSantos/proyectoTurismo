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


namespace proyectoTurismo.Modulos
{
    public partial class agregarModulo : Form
    {
        public agregarModulo()
        {
            InitializeComponent();
        }

        private void agregarModulo_Load(object sender, EventArgs e)
        {
            cargarComboCiudad();
        }

        private void cargarComboCiudad()
        {
            cmbCiudad.DataSource = cargarComboModulos.GellAllciudadModulo();
            cmbCiudad.DisplayMember = "nombreCiudad";
            cmbCiudad.ValueMember = "nombreCiudad";

            if (cmbCiudad.Items.Count != 0)
            {
                string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);

             
            }
            else
            {
               
                //cbTrack.DataSource = null;
                //dgvCustomer.DataSource = null;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            if (string.IsNullOrEmpty(txtNombredModulo.Text) || string.IsNullOrEmpty(txtDireccion.Text))
            {
                //validartextos();
                MessageBox.Show("falta un campo");
            }
            else
            {

                //validartextos();

                //string sql = "Insert into registroAlumno(matricula,nombre,direccion,telefono,foto) values(@matricula,@nombre,@direccion,@telefono,@foto)";
                string sql = "if exists(select nombreModulo from modulos where nombreModulo= @nombreModulo) update modulos set nombreModulo=@nombreModulo,direccionModulo=@direccionModulo,encargadoModulo=@encargadoModulo,nombreCiudad=@nombreCiudad where nombreModulo=@nombreModulo else insert into modulos (nombreModulo,direccionModulo,encargadoModulo,nombreCiudad) values (@nombreModulo,@direccionModulo,@encargadoModulo,@nombreCiudad)";
                SqlConnection conexion = new SqlConnection(miCadenaConexion);
                SqlCommand comando = new SqlCommand(sql, conexion);

                try
                {
                    conexion.Open();
                    comando.Parameters.AddWithValue("@nombreModulo", txtNombredModulo.Text);
                    comando.Parameters.AddWithValue("@direccionModulo", txtDireccion.Text);
                    comando.Parameters.AddWithValue("@nombreCiudad", cmbCiudad.Text);
                    comando.Parameters.AddWithValue("@encargadoModulo", txtEncargado.Text);

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
    }
}
