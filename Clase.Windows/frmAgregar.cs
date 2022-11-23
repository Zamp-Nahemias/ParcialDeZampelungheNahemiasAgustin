using Clase.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase.Windows
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void AzulRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            esfera = new Esfera();
            esfera.radio = float.Parse(AgregarTextBox.Text);
            esfera.ColorRelleno = (ColorEsf)ColorComboBox.SelectedItem;
            esfera.trazo = RayaRadioButton.Checked ? Trazo.rayas : ContinuoRadioButton.Checked ?
                Trazo.continuo : Trazo.puntos;
           

            DialogResult = DialogResult.OK;
        }
        public Esfera GetRadio()
        {
            return esfera;
        }
        private Esfera esfera;

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            CargarComboColor();
        }

        private void CargarComboColor()
        {
            ColorComboBox.DataSource = Enum.GetValues(typeof(ColorEsf));
        }
    }
}
