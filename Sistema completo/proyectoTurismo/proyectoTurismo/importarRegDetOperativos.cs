using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace proyectoTurismo
{
    public partial class importarRegDetOperativos : Form
    {
        public importarRegDetOperativos()
        {
            InitializeComponent();
        }
        string phat;
        public string tabla;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            phat = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\ariel\Downloads\";
            openFileDialog1.Title = "ARCHIVOS EXCEL";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "xls";
            openFileDialog1.Filter = "ARCHIVOS DE EXCEL|*.xls;*.xlsx;*.xlsm";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                phat = openFileDialog1.FileName;
                label1.Text = phat;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", phat);

                // Create Connection to Excel Workbook
                using (OleDbConnection connection =
                             new OleDbConnection(excelConnectionString))
                {
                    OleDbCommand command = new OleDbCommand
                            ("Select * FROM [Hoja1$]", connection);

                    connection.Open();

                    // Create DbDataReader to Data Worksheet
                    using (DbDataReader dr = command.ExecuteReader())
                    {

                        // SQL Server Connection String
                        string sqlConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

                        // Bulk Copy to SQL Server
                        using (SqlBulkCopy bulkCopy =
                                   new SqlBulkCopy(sqlConnectionString))
                        {
                            bulkCopy.DestinationTableName = "regOperativo";
                            bulkCopy.WriteToServer(dr);
                            label1.Text = "SE HAN GUARDADO LOS DATOS CORRECTAMENTE";
                        }
                    }
                }
                phat = null;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message, "ERROR... ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }



    }
}
