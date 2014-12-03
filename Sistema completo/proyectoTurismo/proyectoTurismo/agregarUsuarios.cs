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


namespace proyectoTurismo
{
    public partial class agregarUsuarios : Form
    {
        public agregarUsuarios()
        {
            InitializeComponent();
        }

        public void LimpiarControles()
        {
            //    foreach (Control caja in Grupo.Controls)
            //    {
            //        if (caja is TextBox)
            //        {
            //            caja.Text = "";
            //        }
            //    }
      
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtContrasena.Text = "";
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            cmbTipo.Text = null;

        }

        public void validartextos()
        {
            if (txtUsuario.Text == "")
            { errorProvider1.SetError(txtUsuario, "Debe llenar este campo");}
            else { errorProvider1.Clear(); }


            if (txtNombre.Text == "")
            {errorProvider1.SetError(txtNombre, "Debe llenar este campo");}
            else { errorProvider1.Clear(); }
            
            
            if (txtDireccion.Text == "")
            { errorProvider1.SetError(txtDireccion, "Debe llenar este campo");}
            else { errorProvider1.Clear(); }
            
            
            if (txtTelefono.Text == "")
            { errorProvider1.SetError(txtTelefono, "Debe llenar este campo");}
            else { errorProvider1.Clear(); }
            
            
            if (txtCorreo.Text == "")
            { errorProvider1.SetError(txtCorreo, "Debe llenar este campo");}
            else { errorProvider1.Clear(); }
            
            
            if (txtContrasena.Text == "")
            { errorProvider1.SetError(txtContrasena, "Debe llenar este campo");}
            else { errorProvider1.Clear(); }
            
            
            if (cmbTipo.Text == "")
            { errorProvider1.SetError(cmbTipo, "Debe llenar este campo");}
            else { errorProvider1.Clear(); }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }


        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtContrasena.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "";
            cmbTipo.Text = null;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnGuardar.Visible = true;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            if (txtUsuario.Text != "" && txtTelefono.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "" && txtCorreo.Text !="" && txtContrasena.Text != "" && cmbTipo.Text != "")
            {
                //string sql = "Insert into registroAlumno(matricula,nombre,direccion,telefono,foto) values(@matricula,@nombre,@direccion,@telefono,@foto)";
                string sql = "if exists(select usuario from registroUsuarios where usuario= @usuario) update registroUsuarios set nombre=@nombre,usuario=@usuario,contrasena=@contrasena,direccion=@direccion, telefono=@telefono, correo=@correo, tipo=@tipo where usuario=@usuario else insert into registroUsuarios (nombre,usuario,contrasena,direccion,telefono,correo,tipo) values (@nombre,@usuario,@contrasena,@direccion,@telefono,@correo,@tipo)";
                SqlConnection conexion = new SqlConnection(miCadenaConexion);
                SqlCommand comando = new SqlCommand(sql, conexion);

                try
                {
                    conexion.Open();
                    comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                    comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    comando.Parameters.AddWithValue("@tipo", cmbTipo.Text);
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Se han agregado los datos correctamente");
                    LimpiarControles();

                }


                finally
                {

                }
            }
            else
            {
                MessageBox.Show("Falta llenar algunos campos", "ERROR... ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            string sql = "SELECT * FROM registroUsuarios WHERE usuario=@usuario";
            SqlConnection conexion = new SqlConnection(miCadenaConexion);
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.ExecuteNonQuery();
            SqlDataReader Leer = comando.ExecuteReader();
            if (Leer.Read() == true)
            {
                txtNombre.Text = Leer[2].ToString();
                txtContrasena.Text = Leer[3].ToString();
                txtDireccion.Text = Leer[4].ToString();
                txtTelefono.Text = Leer[5].ToString();
                txtCorreo.Text = Leer[6].ToString();
                cmbTipo.Text = Leer[7].ToString();
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
                btnGuardar.Visible = false;

            }
            conexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            if (txtUsuario.Text != "" && txtTelefono.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "" && txtCorreo.Text != "" && txtContrasena.Text != "" && cmbTipo.Text != "")
            {
                //string sql = "Insert into registroAlumno(matricula,nombre,direccion,telefono,foto) values(@matricula,@nombre,@direccion,@telefono,@foto)";
                string sql = "if exists(select usuario from registroUsuarios where usuario= @usuario) update registroUsuarios set nombre=@nombre,usuario=@usuario,contrasena=@contrasena,direccion=@direccion, telefono=@telefono, correo=@correo, tipo=@tipo where usuario=@usuario else insert into registroUsuarios (nombre,usuario,contrasena,direccion,telefono,correo,tipo) values (@nombre,@usuario,@contrasena,@direccion,@telefono,@correo,@tipo)";
                SqlConnection conexion = new SqlConnection(miCadenaConexion);
                SqlCommand comando = new SqlCommand(sql, conexion);

                try
                {
                    conexion.Open();
                    comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                    comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    comando.Parameters.AddWithValue("@tipo", cmbTipo.Text);
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Se han agregado los datos correctamente");
                    LimpiarControles();
                    btnGuardar.Visible = true;
                    btnModificar.Visible = false;
                    btnEliminar.Visible = false;

                }


                finally
                {

                }
            }
            else
            {
                MessageBox.Show("Falta llenar algunos campos", "ERROR... ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desas eliminar el usuario?", "Alerta...Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                string miCadenaConexion;
                miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                string sql = "DELETE  FROM registroUsuarios WHERE usuario=@usuario";
                SqlConnection conexion = new SqlConnection(miCadenaConexion);
                SqlCommand comando = new SqlCommand(sql, conexion);
                conexion.Open();
                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                comando.ExecuteNonQuery();
                conexion.Close();
                LimpiarControles();
                MessageBox.Show("Se ha eliminado correctamente");
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnGuardar.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

     

        
       


       
    }
}
