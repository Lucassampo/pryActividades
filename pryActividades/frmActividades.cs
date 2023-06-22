using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryActividades
{
    public partial class frmActividades : Form
    {
        public frmActividades()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            frmMostrar Mostrar = new frmMostrar();
            Mostrar.ShowDialog();
            
            if (dtpFecha.Value >= DateTime.Today)
            {
                if(cboTipoActividad.SelectedIndex != -1) 
                {
                    if(txtDetalle.Text != "")
                    {
                        MessageBox.Show("Vamos a grabar...");
                    }
                    else
                    {
                        MessageBox.Show("Te falta completar detalle");
                        txtDetalle.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione fecha actual o posterior","Error de fecha",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            
            }
            
                    
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
