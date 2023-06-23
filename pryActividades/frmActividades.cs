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
        int n = 0;
        public frmActividades()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string varTareas = "";
            string varReunion = "";
       
            if (dtpFecha.Value >= DateTime.Today)
            {
                
                if (cboTipoActividad.SelectedIndex != -1) 
                {
                    if(txtDetalle.Text != "")
                    {    
                        if(optSi.Checked = true)
                        {
                            varReunion = "Si";
                        }
                        else
                        {
                            varReunion = "No";
                        }
                        if(chkDebate.Checked)
                        {
                            varTareas = "Debate, ";

                        }
                        if(chkInvestigacion.Checked)
                        {
                            varTareas = "Investigacion; ";
                                                     
                        }
                        if (chkNotasReunion.Checked)
                        {
                            varTareas = "Notas Reunion, ";
                        }
                        if (chkRepositorio.Checked)
                        {
                            varTareas = "Repositorio, ";
                        }
                        
                        
                        MessageBox.Show("Vamos a grabar...");
                        int n = dtvRegistro.Rows.Add();

                        dtvRegistro.Rows[n].Cells[0].Value = dtpFecha.Text;
                        dtvRegistro.Rows[n].Cells[1].Value = cboTipoActividad.Text;
                        dtvRegistro.Rows[n].Cells[2].Value = txtDetalle.Text;
                        dtvRegistro.Rows[n].Cells[3].Value = varTareas;
                        dtvRegistro.Rows[n].Cells[4].Value = varReunion;

                        //dtvRegistro.Rows.Add(dtpFecha.Value, cboTipoActividad, txtDetalle, varTareas, varReunion)





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
