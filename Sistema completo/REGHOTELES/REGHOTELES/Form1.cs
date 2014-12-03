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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void linkRegLocalidad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regLocalidad X = new regLocalidad();
            X.Show();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cnx = new SqlConnection(miCadenaConexion);
            SqlCommand cmd = new SqlCommand("HOTELERIA", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
             if (cmbMunicipio.Text != "" && cmbLocalidad.Text != "" && txtNombreComercial.Text != "" && cmbActividad.Text != "")
            {
             
                try
                {


            cmd.Parameters.Add(new SqlParameter("@Bandera", 1));
            cmd.Parameters.Add(new SqlParameter("@nombreCiudad", cmbMunicipio.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreLocalidad", cmbLocalidad.Text));
            cmd.Parameters.Add(new SqlParameter("@categoria", cmbCategoria.Text));
            cmd.Parameters.Add(new SqlParameter("@numCuartos", txtnumCuartos.Text));
            cmd.Parameters.Add(new SqlParameter("@actividad", cmbActividad.Text));
            cmd.Parameters.Add(new SqlParameter("@vialidad", cmbVialidad.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreVialidad", txtNombreVialidad.Text));
            cmd.Parameters.Add(new SqlParameter("@numExterior", txtNumeroExterior.Text));
            cmd.Parameters.Add(new SqlParameter("@numInterior", txtNumeroInterior.Text));
            cmd.Parameters.Add(new SqlParameter("@asentamiento", cmbAsentamiento.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreColonia", txtColonia.Text));
            cmd.Parameters.Add(new SqlParameter("@numCp", txtCp.Text));
            cmd.Parameters.Add(new SqlParameter("@tel1", txtTel1.Text));
            cmd.Parameters.Add(new SqlParameter("@tel2", txtTel2.Text));
            cmd.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
            cmd.Parameters.Add(new SqlParameter("@url", txtUrl.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreComercial", txtNombreComercial.Text));

            MessageBox.Show(" LOS DATOS SE HAN REGISTRADO CORRECTAMENTE");
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            LimpiarControles(this);
        }

                finally
                {

                }
            }
             else
             {
                 MessageBox.Show("PARA REGISTRAR TIENE QUE LLENAR LOS SIGUIENTES CAMPOS:\n *NOMBRE COMERCIAL \n *MUNICIPIO\n *LOCALIDAD\n *ACTIVIDAD", "ERROR... ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombreComercial.Enabled = true;
            LoadComboCiudad();
            LimpiarControles(this);
            btnmodificar.Visible = false;
            btncancelar.Visible = false;
            // TODO: esta línea de código carga datos en la tabla 'turismoDataSet6.localidades' Puede moverla o quitarla según sea necesario.
            this.localidadesTableAdapter1.Fill(this.turismoDataSet6.localidades);
            // TODO: esta línea de código carga datos en la tabla 'turismoDataSet5.ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter1.Fill(this.turismoDataSet5.ciudades);
            LOAD();

        }



        public void LOAD()
        {

            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cnx = new SqlConnection(miCadenaConexion);

            cnx.Open();
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            string querry = @"Select nombreComercial from regHoteles";
            SqlCommand cmd = new SqlCommand(querry, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows ==true)
            {
                while(dr.Read())
                    namesCollection.Add(dr["nombreComercial"].ToString());
            }
            dr.Close();
            cnx.Close();
            txtbuscar.AutoCompleteMode = AutoCompleteMode.Append;
            txtbuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtbuscar.AutoCompleteCustomSource = namesCollection;

        }





      
        private void consultar()
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cnx = new SqlConnection(miCadenaConexion);
            SqlCommand cmd = new SqlCommand("HOTELERIA", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Bandera", 2));
            cmd.Parameters.Add(new SqlParameter("@nombreComercial", txtbuscar.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreCiudad", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreLocalidad", ""));
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
            string nombreCiudad;
            string nombreLocalidad;
            string categoria;
            string numCuartos;
            string actividad;
            string vialidad;
            string nombreVialidad;
            string numExterior;
            string numInterior;
            string asentamiento;
            string nombreColonia;
            string numCp;
            string tel1;
            string tel2;
            string email;
            string url;
            string nombreComercial;
            SqlDataReader Leer = cmd.ExecuteReader();
            if (Leer.Read() == true)
            {
                nombreCiudad = Leer[1].ToString();
                nombreLocalidad = Leer[2].ToString();
                nombreComercial = Leer[3].ToString();
                categoria = Leer[4].ToString();
                numCuartos = Leer[5].ToString();
                actividad = Leer[6].ToString();
                vialidad = Leer[7].ToString();
                nombreVialidad = Leer[8].ToString();
                numExterior = Leer[9].ToString();
                numInterior = Leer[10].ToString();
                asentamiento = Leer[11].ToString();
                nombreColonia = Leer[12].ToString();
                numCp = Leer[13].ToString();
                tel1 = Leer[14].ToString();
                tel2 = Leer[15].ToString();
                email = Leer[16].ToString();
                url = Leer[17].ToString();

                cmbMunicipio.Text = nombreCiudad;
                cmbLocalidad.Text = nombreLocalidad;
                cmbCategoria.Text = categoria;
                txtnumCuartos.Text = numCuartos;
                cmbActividad.Text = actividad;
                cmbVialidad.Text = vialidad;
                txtNombreVialidad.Text = nombreVialidad;
                txtNumeroExterior.Text = numExterior;
                txtNumeroInterior.Text = numInterior;
                cmbAsentamiento.Text = asentamiento;
                txtColonia.Text = nombreColonia;
                txtCp.Text = numCp;
                txtTel1.Text = tel1;
                txtTel2.Text = tel2;
                txtEmail.Text = email;
                txtUrl.Text = url;
                txtNombreComercial.Text = nombreComercial;
            }
            cnx.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtNombreComercial.Enabled=false;
            LimpiarControles(this);
            consultar();
            pane.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            btnNuevo.Visible = false;
            button4.Visible = false;
            btnConsultar.Visible = false;
            btnRegistrar.Visible = false;
            btnmodificar.Visible = true;
            btncancelar.Visible = true;
            txtbuscar.Text = "";
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtnumCuartos.Text = "";
            LimpiarControles(this);
            txtNombreComercial.Enabled = true;
            pane.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            btnNuevo.Visible = true;
            button4.Visible = true;
            btnConsultar.Visible = true;
            btnRegistrar.Visible = true;
            btnmodificar.Visible = false;
            btncancelar.Visible = false;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cnx = new SqlConnection(miCadenaConexion);
            SqlCommand cmd = new SqlCommand("update_hoteles", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@nombreComercial", txtNombreComercial.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreCiudad", cmbMunicipio.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreLocalidad", cmbLocalidad.Text));
            cmd.Parameters.Add(new SqlParameter("@categoria", cmbCategoria.Text));
            cmd.Parameters.Add(new SqlParameter("@numCuartos", txtnumCuartos.Text));
            cmd.Parameters.Add(new SqlParameter("@actividad", cmbActividad.Text));
            cmd.Parameters.Add(new SqlParameter("@vialidad", cmbVialidad.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreVialidad", txtNombreVialidad.Text));
            cmd.Parameters.Add(new SqlParameter("@numExterior", txtNumeroExterior.Text));
            cmd.Parameters.Add(new SqlParameter("@numInterior", txtNumeroInterior.Text));
            cmd.Parameters.Add(new SqlParameter("@asentamiento", cmbAsentamiento.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreColonia", txtColonia.Text));
            cmd.Parameters.Add(new SqlParameter("@numCp", txtCp.Text));
            cmd.Parameters.Add(new SqlParameter("@tel1", txtTel1.Text));
            cmd.Parameters.Add(new SqlParameter("@tel2", txtTel2.Text));
            cmd.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
            cmd.Parameters.Add(new SqlParameter("@url", txtUrl.Text));
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            LimpiarControles(this);
            MessageBox.Show(" LOS DATOS SE HAN MODIFICADO CORRECTAMENTE");
            LimpiarControles(this);
            pane.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            btnNuevo.Visible = true;
            button4.Visible = true;
            btnConsultar.Visible = true;
            btnRegistrar.Visible = true;
            btnmodificar.Visible = false;
            btncancelar.Visible = false;

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
        }
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
        private void btncancelarbusqueda_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
            txtNombreComercial.Enabled = true;
            txtbuscar.Text = "";
            pane.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            btnNuevo.Visible = true;
            button4.Visible = true;
            btnConsultar.Visible = true;
            btnRegistrar.Visible = true;
            btnmodificar.Visible = false;
            btncancelar.Visible = false;
        }
        private void LoadComboCiudad()
        {
            cmbMunicipio.DataSource = CONEXION.GellAllCiudad();
            cmbMunicipio.DisplayMember = "nombreCiudad";
            cmbMunicipio.ValueMember = "nombreCiudad";


            if (cmbMunicipio.Items.Count != 0)
            {
                string nombreCiudad = Convert.ToString(cmbMunicipio.SelectedValue);

              LoadComboLocalidad(nombreCiudad);
            }
            else
            {
               //cmbLocalidad.DataSource = null;
                
            }

        }
      

        private void LoadComboLocalidad(string nombreCiudad)
        {
            {
                cmbLocalidad.DataSource = CONEXION.GellLocalidadByCiudad(nombreCiudad);
                cmbLocalidad.DisplayMember = "nombreLocalidad";
                cmbLocalidad.ValueMember = "nombreLocalidad";


                if (cmbLocalidad.Items.Count != 0)
                {
                    string nombreLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);

                    // LoadComboCiudad(nombreCiudad);
                }
                else
                {
                    //cbTrack.DataSource = null;
                    //dgvCustomer.DataSource = null;
                }

            }
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbMunicipio.SelectedValue);

            LoadComboLocalidad(nombreCiudad);
        }

        private void cmbMunicipio_Click(object sender, EventArgs e)
        {
            LoadComboCiudad();
        }

        private void cmbLocalidad_Click(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbMunicipio.SelectedValue);

            LoadComboLocalidad(nombreCiudad);
        }

        private void rEPORTEPORMUNICIPIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportemunicipio X = new reportemunicipio();
            X.Show();
           
        }

        private void rEPORTEPORLOCALIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteLocalidad X = new reporteLocalidad();
            X.Show();
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            LOAD();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            LimpiarControles(this);
            txtbuscar.Text = "";
            btneliminar.Visible = false;
            pane.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            btnNuevo.Visible = false;
            button4.Visible = false;
            btnConsultar.Visible = false;
            btnRegistrar.Visible = false;
           
        }

        private void rEPORTEPORCAETEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rep_General X = new Rep_General();
            X.Show();
        }

        private void rEPORTEPORACTIVIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaMunicipio X = new CategoriaMunicipio();
            X.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pane.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            btnNuevo.Visible = false;
            button4.Visible = false;
            btnConsultar.Visible = false;
            btnRegistrar.Visible = false;
            btneliminar.Visible = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desas eliminar el nombre comercial?", "Alerta...Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                string miCadenaConexion;
                miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection cnx = new SqlConnection(miCadenaConexion); SqlCommand cmd = new SqlCommand("HOTELERIA", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Bandera", 3));
                cmd.Parameters.Add(new SqlParameter("@nombreComercial", txtbuscar.Text));
                cmd.Parameters.Add(new SqlParameter("@nombreCiudad", ""));
                cmd.Parameters.Add(new SqlParameter("@nombreLocalidad", ""));
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
                MessageBox.Show(" LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                LimpiarControles(this);
                pane.Visible = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                btnNuevo.Visible = true;
                button4.Visible = true;
                btnConsultar.Visible = true;
                btnRegistrar.Visible = true;
                btnmodificar.Visible = false;
                btncancelar.Visible = false;
                txtbuscar.Text = "";
            }
            else
            {
                txtbuscar.Text = "";
            }
        }

        private void txtnumCuartos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rEPORTEPORVIALIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
      

      

    }
}
        
    
