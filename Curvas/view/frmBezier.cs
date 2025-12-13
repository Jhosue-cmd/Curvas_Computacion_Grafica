using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CURVAS.Curvas.model;

namespace CURVAS.Curvas.view
{

    public partial class frmBezier : Form
    {
        private List<PointF> puntosControl;
        private CBezier logicaBezier;
        private int indiceArrastre = -1;
        private bool animando = false;
        private float tAnimacion = 0f;
        private Timer tmrAnimacion;

        public frmBezier()
        {
            InitializeComponent(); // Llama al método en el Designer.cs

            puntosControl = new List<PointF>();
            logicaBezier = new CBezier();

            // Configurar Timer
            tmrAnimacion = new Timer();
            tmrAnimacion.Interval = 30;
            tmrAnimacion.Tick += TmrAnimacion_Tick;
        }

        private void btnAnimar_Click(object sender, EventArgs e)
        {
            if (puntosControl.Count < 2) { MessageBox.Show("Agregue al menos 2 puntos."); return; }
            animando = !animando;
            tAnimacion = 0;
            btnAnimar.Text = animando ? "Detener Animación" : "Iniciar Animación";
            tmrAnimacion.Enabled = animando;
            picLienzo.Invalidate();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            puntosControl.Clear();
            animando = false;
            tmrAnimacion.Stop();
            btnAnimar.Text = "Iniciar Animación";
            picLienzo.Invalidate();
        }

        private void TmrAnimacion_Tick(object sender, EventArgs e)
        {
            tAnimacion += 0.01f;
            if (tAnimacion > 1f) tAnimacion = 0f;
            picLienzo.Invalidate();
        }

        private void PicLienzo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < puntosControl.Count; i++)
                {
                    if (Distancia(puntosControl[i], e.Location) < 10)
                    {
                        indiceArrastre = i;
                        return;
                    }
                }
                if (e.X >= 0 && e.Y >= 0)
                    puntosControl.Add(e.Location);
            }
            else if (e.Button == MouseButtons.Right && puntosControl.Count > 0)
            {
                puntosControl.RemoveAt(puntosControl.Count - 1);
            }
            picLienzo.Invalidate();
        }

        private void PicLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (indiceArrastre != -1)
            {
                float x = Math.Max(0, Math.Min(picLienzo.Width, e.X));
                float y = Math.Max(0, Math.Min(picLienzo.Height, e.Y));
                puntosControl[indiceArrastre] = new PointF(x, y);
                picLienzo.Invalidate();
            }
        }

        private void PicLienzo_MouseUp(object sender, MouseEventArgs e)
        {
            indiceArrastre = -1;
        }

        private void PicLienzo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (puntosControl.Count > 0)
            {
                if (puntosControl.Count > 1)
                    e.Graphics.DrawLines(Pens.LightGray, puntosControl.ToArray());

                foreach (var p in puntosControl)
                {
                    e.Graphics.FillEllipse(Brushes.Red, p.X - 4, p.Y - 4, 8, 8);
                    e.Graphics.DrawEllipse(Pens.Black, p.X - 4, p.Y - 4, 8, 8);
                }
            }

            if (puntosControl.Count >= 2)
            {
                List<PointF> curva = new List<PointF>();
                for (float t = 0; t <= 1; t += 0.005f)
                    curva.Add(logicaBezier.CalcularPunto(t, puntosControl));

                curva.Add(logicaBezier.CalcularPunto(1f, puntosControl));

                e.Graphics.DrawLines(new Pen(Color.Blue, 2), curva.ToArray());

                if (animando)
                {
                    PointF ptAnim = logicaBezier.CalcularPunto(tAnimacion, puntosControl);
                    e.Graphics.FillEllipse(Brushes.LimeGreen, ptAnim.X - 6, ptAnim.Y - 6, 12, 12);
                    e.Graphics.DrawString($"t={tAnimacion:0.00}", this.Font, Brushes.Black, ptAnim.X + 10, ptAnim.Y);
                }
            }
        }

        private float Distancia(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
