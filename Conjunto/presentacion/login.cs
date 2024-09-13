using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            iniciar iniciar = new iniciar();
            iniciar.Show();
            this.Hide();
            iniciar.FormClosed += (s, args) => Application.Exit();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            registro_login registro = new registro_login();
            registro.Show();
            this.Hide();
            registro.FormClosed += (s, args) => Application.Exit();
        }
    }
}
