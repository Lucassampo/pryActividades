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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Lucon" && txtContraseña.Text == "jesucristopasion") ;
            {
                this.Hide();
                frmActividades frmActividades= new frmActividades();
                frmActividades.ShowDialog();
            }
        }    
    }
}
