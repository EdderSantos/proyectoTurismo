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


namespace regEstablecimientos
{
    public partial class regOp : Form
    {
        public regOp()
        {
            InitializeComponent();
        }

        private void regOp_Load(object sender, EventArgs e)
        {
            txtNombreUnidadEconomica.Enabled = true;
            btneliminar.Visible = false;
            LoadComboCiudad();
            LOAD();
            LimpiarControles(this);
            btnmodificar.Visible = false;
            btncancelar.Visible = false;
            
        }

        public void LOAD()
        {

            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cnx = new SqlConnection(miCadenaConexion);

            cnx.Open();
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            string querry = @"Select nombreEstablecimiento from regEstablecimiento";
            SqlCommand cmd = new SqlCommand(querry, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    namesCollection.Add(dr["nombreEstablecimiento"].ToString());
            }
            dr.Close();
            cnx.Close();
            txtbuscar.AutoCompleteMode = AutoCompleteMode.Append;
            txtbuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtbuscar.AutoCompleteCustomSource = namesCollection;

        }


        private void LoadComboCiudad()
        {
            cmbMunicipio.DataSource = cargarCombos.GellAllCiudad();
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
                cmbLocalidad.DataSource = cargarCombos.GellLocalidadByCiudad(nombreCiudad);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtNombreUnidadEconomica.Enabled = true; 
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

        private void btncancelarbusqueda_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
            txtNombreUnidadEconomica.Enabled = true;
            txtbuscar.Text = "";
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

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            LOAD();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
            txtNombreUnidadEconomica.Enabled = false;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cnx = new SqlConnection(miCadenaConexion);
            SqlCommand cmd = new SqlCommand("ESTABLECIMIENTOS", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (cmbMunicipio.Text != "" && cmbLocalidad.Text != "" && txtNombreUnidadEconomica.Text != "" && cmbActividad.Text != "" && txtRazonSocial.Text != "")
            {

                try
                {
                    cmd.Parameters.Add(new SqlParameter("@Bandera", 1));
                    //cmd.Parameters.Add(new SqlParameter("@idRegEstablecimiento", ""));
                    cmd.Parameters.Add(new SqlParameter("@razonSocial", txtRazonSocial.Text));
                    cmd.Parameters.Add(new SqlParameter("@ocupacionPersona", txtPersonal.Text));
                    cmd.Parameters.Add(new SqlParameter("@claseActividad", cmbActividad.Text));
                    cmd.Parameters.Add(new SqlParameter("@tipoVialidad", cmbVialidad.Text));
                    cmd.Parameters.Add(new SqlParameter("@nombreVialidad", txtNombreVialidad.Text));
                    cmd.Parameters.Add(new SqlParameter("@numExterior", txtNumeroExterior.Text));
                    cmd.Parameters.Add(new SqlParameter("@numInterior", txtNumeroInterior.Text));
                    cmd.Parameters.Add(new SqlParameter("@edificioPisoOnivel", txtPisoNivel.Text));
                    cmd.Parameters.Add(new SqlParameter("@numLocal", txtnumLocal.Text));
                    cmd.Parameters.Add(new SqlParameter("@tipoAsentamiento", cmbAsentamiento.Text));
                    cmd.Parameters.Add(new SqlParameter("@nombreAsentamiento", txtNombreAsentamiento.Text));
                    cmd.Parameters.Add(new SqlParameter("@codigoPostal", txtCodigoPostal.Text));
                    cmd.Parameters.Add(new SqlParameter("@corredorCentroOmercado", txtCorredor.Text));
                    cmd.Parameters.Add(new SqlParameter("@telefono1", txtTel1.Text));
                    cmd.Parameters.Add(new SqlParameter("@telefono2", txtTel2.Text));
                    cmd.Parameters.Add(new SqlParameter("@correo", txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@url", txtUrl.Text));
                    cmd.Parameters.Add(new SqlParameter("@nombreMunicipio", cmbMunicipio.Text));
                    cmd.Parameters.Add(new SqlParameter("@nombreLocalidad", cmbLocalidad.Text));
                    cmd.Parameters.Add(new SqlParameter("@nombreEstablecimiento", txtNombreUnidadEconomica.Text));

                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show(" LOS DATOS SE HAN REGISTRADO CORRECTAMENTE");
                    LimpiarControles(this);
                }


                finally
                {

                }
            }
            else
            {
                MessageBox.Show("PARA REGISTRAR TIENE QUE LLENAR LOS SIGUIENTES CAMPOS:\n *NOMBRE UNIDAD ECONOMICA\n *RAZON SOCIAL \n *MUNICIPIO\n *LOCALIDAD\n *CLASE ACTIVIDAD", "ERROR... ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void consultar()
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cnx = new SqlConnection(miCadenaConexion);
            SqlCommand cmd = new SqlCommand("ESTABLECIMIENTOS", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Bandera", 2));
            //cmd.Parameters.Add(new SqlParameter("@idRegEstablecimiento", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreEstablecimiento", txtbuscar.Text));
            cmd.Parameters.Add(new SqlParameter("@razonSocial", ""));
            cmd.Parameters.Add(new SqlParameter("@ocupacionPersona", ""));
            cmd.Parameters.Add(new SqlParameter("@claseActividad", ""));
            cmd.Parameters.Add(new SqlParameter("@tipoVialidad", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreVialidad", ""));
            cmd.Parameters.Add(new SqlParameter("@numExterior", ""));
            cmd.Parameters.Add(new SqlParameter("@numInterior", ""));
            cmd.Parameters.Add(new SqlParameter("@edificioPisoOnivel", ""));
            cmd.Parameters.Add(new SqlParameter("@numLocal", ""));
            cmd.Parameters.Add(new SqlParameter("@tipoAsentamiento", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreAsentamiento", ""));
            cmd.Parameters.Add(new SqlParameter("@codigoPostal", ""));
            cmd.Parameters.Add(new SqlParameter("@corredorCentroOmercado", ""));
            cmd.Parameters.Add(new SqlParameter("@telefono1", ""));
            cmd.Parameters.Add(new SqlParameter("@telefono2", ""));
            cmd.Parameters.Add(new SqlParameter("@correo", ""));
            cmd.Parameters.Add(new SqlParameter("@url", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreMunicipio", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreLocalidad", ""));

            cnx.Open();
            string nombreEstablecimiento;
            string razonSocial;
            string ocupacionPersona;
            string claseActividad;
            string tipoVialidad;
            string nombreVialidad;
            string numExterior;
            string numInterior;
            string edificioPisoOnivel;
            string numLocal;
            string tipoAsentamiento;
            string nombreAsentamiento;
            string codigoPostal;
            string telefono1;
            string telefono2;
            string correo;
            string corredorCentroOmercado;
            string url;
            string nombreMunicipio;
            string nombreLocalidad;
            SqlDataReader Leer = cmd.ExecuteReader();
            if (Leer.Read() == true)
            {
                nombreEstablecimiento = Leer[1].ToString();
                razonSocial = Leer[2].ToString();
                ocupacionPersona = Leer[3].ToString();
                claseActividad = Leer[4].ToString();
                tipoVialidad = Leer[5].ToString();
                nombreVialidad= Leer[6].ToString();
                numExterior = Leer[7].ToString();
                numInterior = Leer[8].ToString();
                edificioPisoOnivel= Leer[9].ToString();
                numLocal = Leer[10].ToString();
                tipoAsentamiento = Leer[11].ToString();
                nombreAsentamiento = Leer[12].ToString();
                codigoPostal = Leer[13].ToString();
                corredorCentroOmercado = Leer[14].ToString();
                telefono1 = Leer[15].ToString();
                telefono2 = Leer[16].ToString();
               correo = Leer[17].ToString();
                url = Leer[18].ToString();
                nombreMunicipio = Leer[19].ToString();
                nombreLocalidad = Leer[20].ToString();


                txtNombreUnidadEconomica.Text = nombreEstablecimiento;
                txtRazonSocial.Text = razonSocial;
                txtPersonal.Text = ocupacionPersona;
                cmbActividad.Text = claseActividad;
              cmbVialidad.Text = tipoVialidad;
              txtNombreVialidad.Text = nombreVialidad;
              txtNumeroExterior.Text = numExterior;
                txtNumeroInterior.Text = numInterior;
                txtPisoNivel.Text = edificioPisoOnivel;
                txtnumLocal.Text= numLocal;
                cmbAsentamiento.Text = tipoAsentamiento;
                txtNombreAsentamiento.Text = nombreAsentamiento;
               txtCodigoPostal.Text = codigoPostal;
               txtCorredor.Text = corredorCentroOmercado;
                txtTel1.Text = telefono1;
                txtTel2.Text = telefono2;
                txtEmail.Text = correo;
                txtUrl.Text = url;
                cmbMunicipio.Text = nombreMunicipio;
                cmbLocalidad.Text = nombreLocalidad;
               

            }
            cnx.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cnx = new SqlConnection(miCadenaConexion);
            SqlCommand cmd = new SqlCommand("update_establecimientos", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@nombreEstablecimiento", txtNombreUnidadEconomica.Text));
            cmd.Parameters.Add(new SqlParameter("@razonSocial", txtRazonSocial.Text));
            cmd.Parameters.Add(new SqlParameter("@ocupacionPersona", txtPersonal.Text));
            cmd.Parameters.Add(new SqlParameter("@claseActividad", cmbActividad.Text));
            cmd.Parameters.Add(new SqlParameter("@tipoVialidad", cmbVialidad.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreVialidad", txtNombreVialidad.Text));
            cmd.Parameters.Add(new SqlParameter("@numExterior", txtNumeroExterior.Text));
            cmd.Parameters.Add(new SqlParameter("@numInterior", txtNumeroInterior.Text));
            cmd.Parameters.Add(new SqlParameter("@edificioPisoOnivel", txtPisoNivel.Text));
            cmd.Parameters.Add(new SqlParameter("@numLocal", txtnumLocal.Text));
            cmd.Parameters.Add(new SqlParameter("@tipoAsentamiento", cmbAsentamiento.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreAsentamiento", txtNombreAsentamiento.Text));
            cmd.Parameters.Add(new SqlParameter("@codigoPostal", txtCodigoPostal.Text));
            cmd.Parameters.Add(new SqlParameter("@corredorCentroOmercado", txtCorredor.Text));
            cmd.Parameters.Add(new SqlParameter("@telefono1", txtTel1.Text));
            cmd.Parameters.Add(new SqlParameter("@telefono2", txtTel2.Text));
            cmd.Parameters.Add(new SqlParameter("@correo", txtEmail.Text));
            cmd.Parameters.Add(new SqlParameter("@url", txtUrl.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreMunicipio", cmbMunicipio.Text));
            cmd.Parameters.Add(new SqlParameter("@nombreLocalidad", cmbLocalidad.Text));
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
           
         
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
            txtNombreUnidadEconomica.Enabled = true;
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
            SqlConnection cnx = new SqlConnection(miCadenaConexion);
            SqlCommand cmd = new SqlCommand("ESTABLECIMIENTOS", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure; cmd.Parameters.Add(new SqlParameter("@Bandera", 3));
            //cmd.Parameters.Add(new SqlParameter("@idRegEstablecimiento", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreEstablecimiento", txtbuscar.Text));
            cmd.Parameters.Add(new SqlParameter("@razonSocial", ""));
            cmd.Parameters.Add(new SqlParameter("@ocupacionPersona", ""));
            cmd.Parameters.Add(new SqlParameter("@claseActividad", ""));
            cmd.Parameters.Add(new SqlParameter("@tipoVialidad", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreVialidad", ""));
            cmd.Parameters.Add(new SqlParameter("@numExterior", ""));
            cmd.Parameters.Add(new SqlParameter("@numInterior", ""));
            cmd.Parameters.Add(new SqlParameter("@edificioPisoOnivel", ""));
            cmd.Parameters.Add(new SqlParameter("@numLocal", ""));
            cmd.Parameters.Add(new SqlParameter("@tipoAsentamiento", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreAsentamiento", ""));
            cmd.Parameters.Add(new SqlParameter("@codigoPostal", ""));
            cmd.Parameters.Add(new SqlParameter("@corredorCentroOmercado", ""));
            cmd.Parameters.Add(new SqlParameter("@telefono1", ""));
            cmd.Parameters.Add(new SqlParameter("@telefono2", ""));
            cmd.Parameters.Add(new SqlParameter("@correo", ""));
            cmd.Parameters.Add(new SqlParameter("@url", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreMunicipio", ""));
            cmd.Parameters.Add(new SqlParameter("@nombreLocalidad", ""));
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
        }
             else
             {
                 txtbuscar.Text = "";
             }
        }

        private void rEPORTEPORMUNICIPIOToolStripMenuItem_Click(object sender, EventArgs e)
        {


            rep_Muni X = new rep_Muni();
            X.Show();
        }

        private void rEPORTEPORLOCALIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rep_Loc X = new rep_Loc();
            X.Show();
        }

        private void linkRegLocalidad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REGHOTELES.regLocalidad x = new REGHOTELES.regLocalidad();
            x.Show();
        }

       



    }
}
