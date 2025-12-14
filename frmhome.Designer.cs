namespace CURVAS
{
    partial class frmhome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuAlgoritmos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBezier = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBSpline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAcerca = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlgoritmos,
            this.menuVentana,
            this.menuAyuda});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";

            // 
            // menuAlgoritmos
            // 
            this.menuAlgoritmos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBezier,
            this.itemBSpline,
            this.toolStripSeparator1,
            this.itemSalir});
            this.menuAlgoritmos.Name = "menuAlgoritmos";
            this.menuAlgoritmos.Size = new System.Drawing.Size(78, 20);
            this.menuAlgoritmos.Text = "Algoritmos";

            // 
            // itemBezier
            // 
            this.itemBezier.Name = "itemBezier";
            this.itemBezier.Size = new System.Drawing.Size(157, 22);
            this.itemBezier.Text = "Curvas Bézier";
            this.itemBezier.Click += new System.EventHandler(this.itemBezier_Click);

            // 
            // itemBSpline
            // 
            this.itemBSpline.Name = "itemBSpline";
            this.itemBSpline.Size = new System.Drawing.Size(157, 22);
            this.itemBSpline.Text = "Curvas B-Spline";
            this.itemBSpline.Click += new System.EventHandler(this.itemBSpline_Click);

            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);

            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(157, 22);
            this.itemSalir.Text = "Salir";
            this.itemSalir.Click += new System.EventHandler(this.itemSalir_Click);

            // 
            // menuVentana
            // 
            this.menuVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCascada,
            this.itemHorizontal});
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(61, 20);
            this.menuVentana.Text = "Ventana";

            // 
            // itemCascada
            // 
            this.itemCascada.Name = "itemCascada";
            this.itemCascada.Size = new System.Drawing.Size(129, 22);
            this.itemCascada.Text = "Cascada";
            this.itemCascada.Click += new System.EventHandler(this.itemCascada_Click);

            // 
            // itemHorizontal
            // 
            this.itemHorizontal.Name = "itemHorizontal";
            this.itemHorizontal.Size = new System.Drawing.Size(129, 22);
            this.itemHorizontal.Text = "Horizontal";
            this.itemHorizontal.Click += new System.EventHandler(this.itemHorizontal_Click);

            // 
            // menuAyuda
            // 
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAcerca});
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "Ayuda";

            // 
            // itemAcerca
            // 
            this.itemAcerca.Name = "itemAcerca";
            this.itemAcerca.Size = new System.Drawing.Size(135, 22);
            this.itemAcerca.Text = "Acerca de...";
            this.itemAcerca.Click += new System.EventHandler(this.itemAcerca_Click);

            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmhome";
            this.Text = "Algoritmos de Computación Gráfica - Sistema Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuAlgoritmos;
        private System.Windows.Forms.ToolStripMenuItem itemBezier;
        private System.Windows.Forms.ToolStripMenuItem itemBSpline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
        private System.Windows.Forms.ToolStripMenuItem menuVentana;
        private System.Windows.Forms.ToolStripMenuItem itemCascada;
        private System.Windows.Forms.ToolStripMenuItem itemHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem itemAcerca;
    }
}