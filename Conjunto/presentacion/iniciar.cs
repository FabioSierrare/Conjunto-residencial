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
    public partial class iniciar : Form
    {
        NG_usuario usuario = new NG_usuario();
        public iniciar()
        {
            InitializeComponent();
        }

        private void btniniciars_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario.VerificarUser(txtcorreo.Text, txtcontraseña.Text))
                {
                    mdicontainer mdicontainer = new mdicontainer();
                    mdicontainer.Show();
                    this.Hide();
                    mdicontainer.FormClosed += (s, args) => Application.Exit();
                }
            }
            catch (Exception xe)
            {

                MessageBox.Show(xe.Message);
            }
        }

        private void iniciar_Load(object sender, EventArgs e)
        {

        }
    }
}
