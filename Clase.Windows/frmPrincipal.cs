using Clase.Datos;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private RepositorioDeEsfera repo;
        private List<Esfera> lista;
        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregar();
            DialogResult = frm.ShowDialog(this);

            var esfera = frm.GetRadio();
            repo.Agregar(esfera);

            var r = ContruirFila();
            SetearFila(r, esfera);
            AgregarFila(r);
            repo.Guardar();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Esfera esfera)
        {
            r.Cells[Radio.Index].Value = esfera.radio;
            r.Cells[Relleno.Index].Value = esfera.ColorRelleno;
            r.Cells[Trazo.Index].Value = esfera.trazo;
            r.Cells[Volumen.Index].Value = esfera.GetVolumen().ToString("N2");
            r.Cells[Area.Index].Value = esfera.GetArea().ToString("N2");
           
        }

        private DataGridViewRow ContruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DgvDatos);
            return r;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            repo = new RepositorioDeEsfera();
            if (repo.GetCantidad() > 0)
            {
                RecargarGrilla();
            }
        }

        private void RecargarGrilla()
        {
            lista = repo.GetLista();
            MostrarLista();
        }

        private void MostrarLista()
        {
            DgvDatos.Rows.Clear();
            foreach (var esfera in lista)
            {
                var r = ContruirFila();
                SetearFila(r, esfera);
                AgregarFila(r);
            }
        }
    }
}
