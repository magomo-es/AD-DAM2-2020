using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hoteles
{
    public partial class FormHoteles : Form
    {
        public FormHoteles()
        {
            InitializeComponent();
        }

        private void FormHoteles_Load(object sender, EventArgs e)
        {
            bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
            //bindingSourceHoteles.DataSource = DBData.HotelORM.SelectAllhoteles();
            bindingSourceHoteles.DataSource = GetBySelectedCity();
        }

        private void toolStripMenuItemNuevo_Click(object sender, EventArgs e)
        {
            FormHotel frm = new FormHotel();
            frm.Text = "Alta hotel";
            frm.ShowDialog();
            // bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
            bindingSourceHoteles.DataSource = GetBySelectedCity();
        }

        private void toolStripMenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudades _ciudad;
            if (comboBoxCiudades.SelectedItem != null)
            {
                _ciudad = (ciudades)comboBoxCiudades.SelectedItem;
                bindingSourceHoteles.DataSource = _ciudad.hoteles;
            }
        }

        private void dataGridViewHoteles_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hoteles hotel = (hoteles)dataGridViewHoteles.CurrentRow.DataBoundItem;
            FormHotel frm = new FormHotel(hotel);
            frm.Text = "Modificación hotel";
            frm.ShowDialog();
            // bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
            bindingSourceHoteles.DataSource = GetBySelectedCity();
        }

        private void dataGridViewHoteles_DeleteRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            hoteles hotel = (hoteles)dataGridViewHoteles.CurrentRow.DataBoundItem;
            String mnsj = "Está seguro de eliminar definitivamente el hotel " + hotel.nombre + " ?";
            DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (isOK == DialogResult.OK)
            {
                mnsj = DBData.HotelORM.DeleteHotel(hotel);
                if (!mnsj.Equals(""))
                {
                    MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
            bindingSourceHoteles.DataSource = GetBySelectedCity();
        }

        private List<hoteles> GetBySelectedCity()
        {
            /*
            List<hoteles> retu = new List<hoteles>();
            int theid = ((ciudades)comboBoxCiudades.SelectedItem).id_ciudad;
            if (theid >= 0) { retu = DBData.HotelORM.SelectHotelesByCiudad(theid); }
            else { retu = DBData.HotelORM.SelectAllhoteles(); }
            return retu;
            */
            return ((ciudades)comboBoxCiudades.SelectedItem).hoteles.ToList();
        }

        private void dataGridViewHoteles_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            hoteles hotel = (hoteles)dataGridViewHoteles.CurrentRow.DataBoundItem;
            String mnsj = "Está seguro de eliminar definitivamente el hotel " + hotel.nombre + " ?";
            DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isOK == DialogResult.Yes)
            {
                mnsj = DBData.HotelORM.DeleteHotel(hotel);
                if (!mnsj.Equals(""))
                {
                    MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else { e.Cancel = true; }
            bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
            bindingSourceHoteles.DataSource = GetBySelectedCity();
        }

    }
}
