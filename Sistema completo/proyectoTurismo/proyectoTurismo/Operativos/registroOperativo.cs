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

namespace proyectoTurismo.Operativos
{
    public partial class registroOperativo : Form
    {
        public registroOperativo()
        {
            InitializeComponent();
        }

       
        private void registroOperativo_Load(object sender, EventArgs e)
        {
            LoadComboCiudadModulo();
            rbHospedajeNo.Checked = true;
            LoadComboOperativo();
        }


        #region comboBox

        private void cmbCiudadModulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbCiudadModulo.SelectedValue);

            LoadComboModulo(nombreCiudad);
        }



        private void LoadComboCiudadModulo()
        {
            cmbCiudadModulo.DataSource = rellenarCombosRegModulo.GellAllciudadModulo();
            cmbCiudadModulo.DisplayMember = "nombreCiudad";
            cmbCiudadModulo.ValueMember = "nombreCiudad";

            if (cmbCiudadModulo.Items.Count != 0)
            {
                string nombreCiudad = Convert.ToString(cmbCiudadModulo.SelectedValue);

                LoadComboModulo(nombreCiudad);
            }
            else
            {
                cmbModulo.DataSource = null;
                //cbTrack.DataSource = null;
                //dgvCustomer.DataSource = null;
            }

        }

        private void LoadComboOperativo()
        {
            cmbOperativo.DataSource = rellenarCombosRegModulo.GellAllOperativo();
            cmbOperativo.DisplayMember = "nombreOperativo";
            cmbOperativo.ValueMember = "nombreOperativo";

            //if (cmbCiudadModulo.Items.Count != 0)
            //{
            //    string nombreCiudad = Convert.ToString(cmbCiudadModulo.SelectedValue);

            //    LoadComboModulo(nombreCiudad);
            //}
            //else
            //{
            //    cmbModulo.DataSource = null;
            //    //cbTrack.DataSource = null;
            //    //dgvCustomer.DataSource = null;
            //}

        }

        private void LoadComboPais()
        {
            cmbPais.DataSource = rellenarCombosRegModulo.GellAllPaises();
            cmbPais.DisplayMember = "nombrePais";
            cmbPais.ValueMember = "nombrePais";

            if (cmbPais.Items.Count != 0)
            {
                string nombrePais = Convert.ToString(cmbPais.SelectedValue);
                cmbEstado.DataSource = null;
                cmbCiudad.DataSource = null;
                LoadComboEstado(nombrePais);
            }
            else
            {
                cmbEstado.DataSource = null;
                //cbTrack.DataSource = null;
                //dgvCustomer.DataSource = null;
            }

        }

        private void LoadComboPaisMexico()
        {
            cmbPais.DataSource = rellenarCombosRegModulo.GellAllPaisMexico();
            cmbPais.DisplayMember = "nombrePais";
            cmbPais.ValueMember = "nombrePais";

            if (cmbPais.Items.Count != 0)
            {
                string nombrePais = Convert.ToString(cmbPais.SelectedValue);

                LoadComboEstado(nombrePais);
            }
            else
            {
                cmbEstado.DataSource = null;
                //cbTrack.DataSource = null;
                //dgvCustomer.DataSource = null;
            }

        }

        private void LoadComboEstado(string nombrePais)
        {
            cmbEstado.DataSource = rellenarCombosRegModulo.GellEstadoByPais(nombrePais);
            cmbEstado.DisplayMember = "nombreEstado";
            cmbEstado.ValueMember = "nombreEstado";


            if (cmbModulo.Items.Count != 0)
            {
                string nombreEstado = Convert.ToString(cmbEstado.SelectedValue);

                LoadComboCiudad(nombreEstado);
            }
            else
            {
                //cbTrack.DataSource = null;
                //dgvCustomer.DataSource = null;
            }

        }

        private void LoadComboCiudad(string nombreEstado)
        {
            cmbCiudad.DataSource = rellenarCombosRegModulo.GellCiudadByPais(nombreEstado);
            cmbCiudad.DisplayMember = "nombreCiudad";
            cmbCiudad.ValueMember = "nombreCiudad";


            if (cmbModulo.Items.Count != 0)
            {
                string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);

                //LoadComboTrack(AlbumId);
            }
            else
            {
                //cbTrack.DataSource = null;
                //dgvCustomer.DataSource = null;
            }

        }


        private void LoadComboModulo(string nombreCiudad)
        {
            cmbModulo.DataSource = rellenarCombosRegModulo.GellModuloByCiudad(nombreCiudad);
            cmbModulo.DisplayMember = "nombreModulo";
            cmbModulo.ValueMember = "nombreModulo";


            if (cmbModulo.Items.Count != 0)
            {
                string nombreModulo = Convert.ToString(cmbModulo.SelectedValue);

                //LoadComboTrack(AlbumId);
            }
            else
            {
                //cbTrack.DataSource = null;
                //dgvCustomer.DataSource = null;
            }

        }





        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cmbProcedencia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbProcedencia.Text == "NACIONAL") {
                cmbPais.Text = null;
                LoadComboPaisMexico();
                numTotExtrangeros.Enabled = false;
                numTotalNAcionales.Enabled = true;
                numHombres.Value = 0;
                numMujeres.Value= 0;
                numNinos.Value = 0;
                numTotalNAcionales.Value = 0;
                numTotExtrangeros.Value = 0;
            }else if(cmbProcedencia.Text == "INTERNACIONAL"){
                cmbPais.Text = null;
                LoadComboPais();
                numTotalNAcionales.Enabled = false;
                numTotExtrangeros.Enabled = true;
                numHombres.Value = 0;
                numMujeres.Value = 0;
                numNinos.Value = 0;
                numTotalNAcionales.Value = 0;
                numTotExtrangeros.Value = 0;
            }
        }

        private void cmbPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nombrePais = Convert.ToString(cmbPais.SelectedValue);

            LoadComboEstado(nombrePais);
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEstado = Convert.ToString(cmbEstado.SelectedValue);

            LoadComboCiudad(nombreEstado);
        }

        
        #endregion

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            int sumaHum = Convert.ToInt32(numHombres.Value) + Convert.ToInt32(numMujeres.Value) + Convert.ToInt32(numNinos.Value);
            int sumaTot = Convert.ToInt32(numTotalNAcionales.Value) + Convert.ToInt32(numTotExtrangeros.Value);

            if (sumaHum == sumaTot)
            {

                errorProvider1.Clear();
                string miCadenaConexion;
                miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                //string sql = "Insert into registroAlumno(matricula,nombre,direccion,telefono,foto) values(@matricula,@nombre,@direccion,@telefono,@foto)";
                string sql = "INSERT INTO regOperativo (nomCiudadMod,nombreModulo,nombreOperativo,numAtendidos,fecha,procedencia,pais,estado,ciudad,diasEstancia,hospedaje,hombres,mujeres,ninos,totNacionales,totExtrangeros,totalVisitantes) VALUES (@nomCiudadMod,@nombreModulo,@nombreOperativo,@numAtendidos,@fecha,@procedencia,@pais,@estado,@ciudad,@diasEstancia,@hospedaje,@hombres,@mujeres,@ninos,@totNacionales,@totExtrangeros,@totalVisit)";
                SqlConnection conexion = new SqlConnection(miCadenaConexion);
                SqlCommand comando = new SqlCommand(sql, conexion);

                try
                {
                    conexion.Open();
                    comando.Parameters.AddWithValue("@nomCiudadMod", cmbCiudadModulo.Text);
                    comando.Parameters.AddWithValue("@nombreModulo", cmbModulo.Text);
                    comando.Parameters.AddWithValue("@nombreOperativo", cmbOperativo.Text);
                    comando.Parameters.AddWithValue("@numAtendidos", numAtendidos.Value);
                    comando.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    comando.Parameters.AddWithValue("@procedencia", cmbProcedencia.Text);
                    comando.Parameters.AddWithValue("@pais", cmbPais.Text);
                    comando.Parameters.AddWithValue("@estado", cmbEstado.Text);
                    comando.Parameters.AddWithValue("@ciudad", cmbCiudad.Text);
                    comando.Parameters.AddWithValue("@diasEstancia", numDiasEstancia.Value);
                    if (rbHospedajeSi.Checked)
                    {
                        comando.Parameters.AddWithValue("@hospedaje", 1);
                    }
                    else if (rbHospedajeNo.Checked)
                    {
                        comando.Parameters.AddWithValue("@hospedaje", 0);
                    }
                    comando.Parameters.AddWithValue("@hombres", numHombres.Value);
                    comando.Parameters.AddWithValue("@mujeres", numMujeres.Value);
                    comando.Parameters.AddWithValue("@ninos", numNinos.Value);
                    comando.Parameters.AddWithValue("@totNacionales", numTotalNAcionales.Value);
                    comando.Parameters.AddWithValue("@totExtrangeros", numTotExtrangeros.Value);
                    int totvisi = Convert.ToInt32(numTotalNAcionales.Value) + Convert.ToInt32(numTotExtrangeros.Value);
                    comando.Parameters.AddWithValue("@totalVisit", totvisi);
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Se han agregado los datos correctamente");


                }


                finally
                {

                }
            }
            else {
                 errorProvider1.SetError(numTotExtrangeros, "Los numeros no coinciden");
                 errorProvider1.SetError(numTotalNAcionales, "Los numeros no coinciden");
                 errorProvider1.SetError(numNinos, "Los numeros no coinciden");
                 errorProvider1.SetError(numMujeres, "Los numeros no coinciden");
                 errorProvider1.SetError(numHombres, "Los numeros no coinciden");
                MessageBox.Show("Los numeros no coinciden");    
            }

        }

        private void numHombres_ValueChanged(object sender, EventArgs e)
        {
            if (cmbProcedencia.Text == "NACIONAL")
            {
                numTotalNAcionales.Value = numHombres.Value + numNinos.Value + numMujeres.Value;
            }
            else if (cmbProcedencia.Text == "INTERNACIONAL")
            {
                numTotExtrangeros.Value = numHombres.Value + numNinos.Value + numMujeres.Value;
            }
        }





    }
}
