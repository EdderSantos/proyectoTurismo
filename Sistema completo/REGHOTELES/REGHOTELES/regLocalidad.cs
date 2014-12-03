using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace REGHOTELES
{
    public partial class regLocalidad : Form
    {
        public regLocalidad()
        {
            InitializeComponent();
        }

        /*REGISTRAR UNA NUEVA LOCALIDAD*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            {
                string miCadenaConexion;
                miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection cnx = new SqlConnection(miCadenaConexion);
                SqlCommand cmd = new SqlCommand("HOTELERIA", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Bandera", 4));
                cmd.Parameters.Add(new SqlParameter("@nombreComercial", ""));
                cmd.Parameters.Add(new SqlParameter("@nombreCiudad", cmbMunicipio.Text));
                cmd.Parameters.Add(new SqlParameter("@nombreLocalidad", txtLocalidad.Text));
                cmd.Parameters.Add(new SqlParameter("@categoria", ""));
                cmd.Parameters.Add(new SqlParameter("@numCuartos", ""));
                cmd.Parameters.Add(new SqlParameter("@actividad", ""));
                cmd.Parameters.Add(new SqlParameter("@vialidad", ""));
                cmd.Parameters.Add(new SqlParameter("@nombreVialidad", ""));
                cmd.Parameters.Add(new SqlParameter("@numExterior", ""));
                cmd.Parameters.Add(new SqlParameter("@numInterior", ""));
                cmd.Parameters.Add(new SqlParameter("@asentamiento", ""));
                cmd.Parameters.Add(new SqlParameter("@nombreColonia", ""));
                cmd.Parameters.Add(new SqlParameter("@numCp", ""));
                cmd.Parameters.Add(new SqlParameter("@tel1", ""));
                cmd.Parameters.Add(new SqlParameter("@tel2", ""));
                cmd.Parameters.Add(new SqlParameter("@email", ""));
                cmd.Parameters.Add(new SqlParameter("@url", ""));
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                LimpiarControles(this);
           
               
            }
        }
        /*-----------------------------*/

        private void LimpiarControles(Control cntr)
        {
            foreach (Control c in cntr.Controls)
            {
                if (c is GroupBox)
                    LimpiarControles((GroupBox)c);
                else if (c is TextBox)
                    c.Text = "";
                else if (c is ComboBox)
                {
                    ComboBox cm = new ComboBox();
                    cm = (ComboBox)c;
                    cm.SelectedIndex = -1;
                }
                else if (c is Panel)
                {
                    Panel cma = new Panel();
                    cma = (Panel)c;
                    cma.Text = "";
                }
            }
        }

        private void regLocalidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'turismoDataSet4.ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.turismoDataSet4.ciudades);
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }

       
}
