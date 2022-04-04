using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String Username = "Lee";
            String Password = "lee123";

            if (Username.Contains (txtUsuario.Text) &&
                    Password.Contains(txtPassword.Text)){
                frmInicio frm = new frmInicio();
                frm.Show();
            }
            else
            {
                string text = "Usuario o clave incorrecta";
                MessageBox.Show(text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
