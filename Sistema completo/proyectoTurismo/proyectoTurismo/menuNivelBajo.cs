using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyectoTurismo
{
    public partial class menuNivelBajo : Form
    {
        public menuNivelBajo()
        {
            InitializeComponent();
        }

        private void reporteModuloDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yaTodo.Form1 childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is yaTodo.Form1)
                {
                    childForm = (yaTodo.Form1)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new yaTodo.Form1();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            } 
        }

        private void reporteModuloEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteAnio.Form1 childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is reporteAnio.Form1)
                {
                    childForm = (reporteAnio.Form1)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new reporteAnio.Form1();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            } 
        }

        private void reporteEntreFechasCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteByCiudad.Form1 childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is reporteByCiudad.Form1)
                {
                    childForm = (reporteByCiudad.Form1)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new reporteByCiudad.Form1();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            } 
        }

        private void reporteModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.reporteModulo childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is Modulos.reporteModulo)
                {
                    childForm = (Modulos.reporteModulo)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new Modulos.reporteModulo();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void reportePorMunicipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGHOTELES.reportemunicipio childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is REGHOTELES.reportemunicipio)
                {
                    childForm = (REGHOTELES.reportemunicipio)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new REGHOTELES.reportemunicipio();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void reportePorLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGHOTELES.reporteLocalidad childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is REGHOTELES.reporteLocalidad)
                {
                    childForm = (REGHOTELES.reporteLocalidad)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new REGHOTELES.reporteLocalidad();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGHOTELES.Rep_General childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is REGHOTELES.Rep_General)
                {
                    childForm = (REGHOTELES.Rep_General)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new REGHOTELES.Rep_General();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void reporteMunicipioPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGHOTELES.CategoriaMunicipio childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is REGHOTELES.CategoriaMunicipio)
                {
                    childForm = (REGHOTELES.CategoriaMunicipio)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new REGHOTELES.CategoriaMunicipio();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void reporteLocalidadPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            REGHOTELES.repcategoriaLocalidad childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is REGHOTELES.CategoriaMunicipio)
                {
                    childForm = (REGHOTELES.repcategoriaLocalidad)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new REGHOTELES.repcategoriaLocalidad();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            regEstablecimientos.rep_Muni childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is regEstablecimientos.rep_Muni)
                {
                    childForm = (regEstablecimientos.rep_Muni)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new regEstablecimientos.rep_Muni();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            regEstablecimientos.rep_Loc childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is regEstablecimientos.rep_Loc)
                {
                    childForm = (regEstablecimientos.rep_Loc)f;
                    break;
                }
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new regEstablecimientos.rep_Loc();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void llblCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar sesión?", "Alerta...Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar sesión?", "Alerta...Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
