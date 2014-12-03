using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace proyectoTurismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string contrasena = txtContrasena.Text;

            string miCadenaConexion;
            miCadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            string sql = "SELECT tipo FROM registroUsuarios WHERE usuario=@usuario AND contrasena=@contrasena";
            SqlConnection conexion = new SqlConnection(miCadenaConexion);
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
            comando.ExecuteNonQuery();
            SqlDataReader Leer = comando.ExecuteReader();
            if (Leer.Read() == true)
            {
                contrasena = Leer[0].ToString();

                switch (contrasena)
                {
                    case "ALTO":
                        {
                            menuSuperAdmn x = new menuSuperAdmn();
                            x.ShowDialog();
                            this.Close();
                            break;
                        }
                    case "MEDIO":
                        {
                            menuNivelMedio x = new menuNivelMedio();
                            x.ShowDialog();
                            this.Close();
                            break;
                        }
                    case "BAJO":
                        {
                            menuNivelBajo x = new menuNivelBajo();
                            x.ShowDialog();
                            this.Close();
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Usuario o contraseña incorrecta", "ERROR... ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }


                }

            }
            else {
                MessageBox.Show("Usuario o contraseña incorrecta", "ERROR... ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
      
               

         }
  
        

       

       



        

      


        
    }
}
