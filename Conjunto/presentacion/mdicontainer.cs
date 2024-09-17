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
    public partial class mdicontainer : Form
    {
        public mdicontainer()
        {
            InitializeComponent();
        }

        private void nuevaPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añadirpropiedad propiedad = new añadirpropiedad();
            propiedad.MdiParent = this;
            propiedad.Show();
        }
    }
}
