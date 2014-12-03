using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using yaTodo;
using reporteAnio;
using reporteByCiudad;

namespace proyectoTurismo
{
    public partial class menuSuperAdmn : Form
    {
        public menuSuperAdmn()
        {
            InitializeComponent();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarUsuarios childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is agregarUsuarios)
                {
                    childForm = (agregarUsuarios)f;
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
                childForm = new agregarUsuarios();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            } 

        }

        private void registroOperativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operativos.registroOperativo childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is Operativos.registroOperativo)
                {
                    childForm = (Operativos.registroOperativo)f;
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
                childForm = new Operativos.registroOperativo();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            } 

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

        private void agregarOperativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operativos.nuevoOperativo childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is Operativos.nuevoOperativo)
                {
                    childForm = (Operativos.nuevoOperativo)f;
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
                childForm = new Operativos.nuevoOperativo();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            } 
        }

        private void agregarModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.agregarModulo childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is Modulos.agregarModulo)
                {
                    childForm = (Modulos.agregarModulo)f;
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
                childForm = new Modulos.agregarModulo();
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            REGHOTELES.Form1 childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is REGHOTELES.Form1)
                {
                    childForm = (REGHOTELES.Form1)f;
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
                childForm = new REGHOTELES.Form1();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            REGHOTELES.regLocalidad childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is REGHOTELES.regLocalidad)
                {
                    childForm = (REGHOTELES.regLocalidad)f;
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
                childForm = new REGHOTELES.regLocalidad();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
           regEstablecimientos.regOp childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is regEstablecimientos.regOp)
                {
                    childForm = (regEstablecimientos.regOp)f;
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
                childForm = new regEstablecimientos.regOp();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            REGHOTELES.regLocalidad childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is REGHOTELES.regLocalidad)
                {
                    childForm = (REGHOTELES.regLocalidad)f;
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
                childForm = new REGHOTELES.regLocalidad();
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

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar sesión?", "Alerta...Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iMPORTARDATOSMASIVOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importarRegDetOperativos childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is importarRegDetOperativos)
                {
                    childForm = (importarRegDetOperativos)f;
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
                childForm = new importarRegDetOperativos();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void iMPORTARDATOSMASIVOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            importarDatosRegHoteles childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is importarDatosRegHoteles)
                {
                    childForm = (importarDatosRegHoteles)f;
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
                childForm = new importarDatosRegHoteles();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        private void iMPORTARDATOSMASIVOSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            importarDatosMasivosEstablecimientos childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is importarDatosMasivosEstablecimientos)
                {
                    childForm = (importarDatosMasivosEstablecimientos)f;
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
                childForm = new importarDatosMasivosEstablecimientos();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }

        



    }
}
