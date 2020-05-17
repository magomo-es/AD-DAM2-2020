using System;
using System.Windows.Forms;

namespace Hoteles
{
    public partial class FormHotel : Form
    {
        private hoteles m_hotel = null;

        public FormHotel()
        {
            InitializeComponent();
        }

        public FormHotel( hoteles hotel )
        {
            InitializeComponent();
            this.m_hotel = hotel;
        }

        private void FormHotel_Load(object sender, EventArgs e)
        {
            bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
            bindingSourceCadenas.DataSource = DBData.CadenasORM.SelectAllCadenas();
            if (this.m_hotel != null)
            {
                FormHotel.ActiveForm.Text = "Modificación hotel";
                textBoxNombre.Text = this.m_hotel.nombre;
                textBoxCategoria.Text = this.m_hotel.categoria.ToString();
                textBoxDireccion.Text = this.m_hotel.direccion;
                textBoxTelefono.Text = this.m_hotel.telefono.ToString();
                // SET de combobox
                if (m_hotel.tipo.Equals("PLAYA")) { comboBoxTipo.SelectedIndex = 0; }
                else { comboBoxTipo.SelectedIndex = 1; }
                comboBoxCiudades.SelectedValue = m_hotel.id_ciudad;
                comboBoxCadena.SelectedValue = m_hotel.cif;
                // SET not enable
                comboBoxCiudades.Enabled = false;
                textBoxNombre.Enabled = false;
            }
            else
            {
                FormHotel.ActiveForm.Text = "Alta hotel";
                comboBoxTipo.SelectedIndex = 0;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int aux;
            string errmsg = "", ormmsg = "";
            bool isOK = true;
            bool isNew = true;
            if (m_hotel != null) { isNew = false; } else { m_hotel = new hoteles(); }
            // El nom de l’hotel ha de ser obligatori.
            m_hotel.nombre = textBoxNombre.Text;
            if (isOK && m_hotel.nombre.Equals("")) { isOK = false; errmsg = "El nombre no puede estar vacío"; textBoxNombre.Focus(); }
            // Control de categoria
            if (isOK && int.TryParse(textBoxCategoria.Text, out aux))
            {
                m_hotel.categoria = int.Parse(textBoxCategoria.Text);
                if (m_hotel.categoria < 1 || m_hotel.categoria > 5)
                {
                    isOK = false; errmsg = "Categoría debe ser entre 1 y 5"; textBoxCategoria.Focus();
                }
            }
            else { isOK = false; errmsg = "Error de formato de Categoría"; textBoxCategoria.Focus(); }
            // Control de longitud de cadena de numero de telefono
            if (isOK && (textBoxTelefono.TextLength > 0 && textBoxTelefono.TextLength <= 9))
            {
                if (int.TryParse(textBoxTelefono.Text, out aux))
                {
                    m_hotel.telefono = int.Parse(textBoxTelefono.Text);
                }
                else
                {
                    isOK = false; errmsg = "Error de formatyo de teléfono"; textBoxCategoria.Focus();
                }
            }
            else { isOK = false; errmsg = "El número de teréfono es demasiado extenso"; textBoxTelefono.Focus(); }
            m_hotel.direccion = textBoxDireccion.Text;
            m_hotel.tipo = comboBoxTipo.SelectedItem.ToString();
            m_hotel.id_ciudad = ((ciudades)comboBoxCiudades.SelectedItem).id_ciudad;
            m_hotel.cif = ((cadenas)comboBoxCadena.SelectedItem).cif;
            // Si les dades són correctes:
            if (isOK)
            {
                if (isNew)
                {
                    // Si estem tractant un alta: Donar d’alta un hotel amb les dades introduïdes per l’usuari. En cas d’error donar el missatge corresponent.Si no, donar el missatge de que s’ha realitzat correctament l’alta.
                    ormmsg = DBData.HotelORM.InsertaHotel(m_hotel);
                }
                else
                {
                    // Si estem tractant una modificació:
                    //      Modificar l’hotel amb les dades introduïdes per l’usuari.
                    ormmsg = DBData.HotelORM.ModificaHotel(m_hotel);
                }
                this.Close();
            }
            else
            {
                // Si les dades són incorrectes, donar el missatge adient i posicionar el cursor en el camp erroni.
                MessageBox.Show(errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!ormmsg.Equals(""))
            {
                // En cas d’error donar el missatge corresponent.Si no, donar el missatge de que s’ha realitzat correctament la modificació.
                MessageBox.Show(ormmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
