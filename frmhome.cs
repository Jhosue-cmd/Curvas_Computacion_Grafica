using System;
using System.Windows.Forms;
using CURVAS.Curvas.view;
namespace CURVAS
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void itemBezier_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmBezier>();
        }

        private void itemBSpline_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmBSpline>();
        }

        private void itemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void itemHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void itemAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto de Curvas y Splines.\nDesarrollado en .NET Framework.", "Información");
        }

        // Método genérico para abrir formularios MDI hijos
        private void AbrirFormulario<T>() where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
                    f.Activate();
                    return;
                }
            }
            T form = new T();
            form.MdiParent = this;
            form.Show();
        }
    }
}
