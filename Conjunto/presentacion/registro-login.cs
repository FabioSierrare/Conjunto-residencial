﻿using Negocio;
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
    public partial class registro_login : Form
    {
        NG_usuario usuario = new NG_usuario();
        public registro_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario.documentVer(txtnumero.Text))
                {
                    MessageBox.Show("El numero de documento el cual intenta registrar ya existe");
                }
                else
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
    }
}
