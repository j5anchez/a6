using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI06_DocumentacionAyuda
{
    public partial class PopUp : Form
    {
        public PopUp(string texto)
        {
            InitializeComponent();
            this.tb_PopUp.Text = texto;
        }

        private void PopUp_Load(object sender, EventArgs e)
        {

        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
