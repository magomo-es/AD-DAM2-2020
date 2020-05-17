using System;
using System.Windows.Forms;

namespace Hoteles
{
    public partial class FormPortada : Form
    {
        public FormPortada()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemHoteles_Click(object sender, EventArgs e)
        {
            FormHoteles frm = new FormHoteles();
            frm.ShowDialog();
        }
    }
}
