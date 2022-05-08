using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DI06_DocumentacionAyuda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.tb_form1, "ingresa tu texto aqui");
            this.ttMensaje.SetToolTip(this.btn_EnviarTexto, "clica el boton para enviar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_EnviarTexto_Click(object sender, EventArgs e)
        {
            PopUp pop = new PopUp(this.tb_form1.Text);
            pop.Show();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void manualDeUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\34603\\Desktop\\trabajosDAM\\_DI\\T6\\ficheros CHM helpers\\ficheroschm.chm");
        }
    }
}
