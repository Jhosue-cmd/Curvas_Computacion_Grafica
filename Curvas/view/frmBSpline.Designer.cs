namespace CURVAS.Curvas.view
{
    partial class frmBSpline
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.numOrden = new System.Windows.Forms.NumericUpDown();
            this.lblInstr = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAnimar = new System.Windows.Forms.Button();
            this.picLienzo = new System.Windows.Forms.PictureBox();

            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrden)).BeginInit();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.lblInstr);
            this.pnlTop.Controls.Add(this.numOrden);
            this.pnlTop.Controls.Add(this.lblInfo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 40);
            this.pnlTop.TabIndex = 0;

            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(10, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(39, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Orden:";

            // 
            // numOrden
            // 
            this.numOrden.Location = new System.Drawing.Point(60, 8);
            this.numOrden.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numOrden.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.numOrden.Name = "numOrden";
            this.numOrden.Size = new System.Drawing.Size(50, 20);
            this.numOrden.TabIndex = 1;
            this.numOrden.Value = new decimal(new int[] { 4, 0, 0, 0 });
            this.numOrden.ValueChanged += new System.EventHandler(this.numOrden_ValueChanged);

            // 
            // lblInstr
            // 
            this.lblInstr.AutoSize = true;
            this.lblInstr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lblInstr.Location = new System.Drawing.Point(130, 10);
            this.lblInstr.Name = "lblInstr";
            this.lblInstr.Size = new System.Drawing.Size(298, 15);
            this.lblInstr.TabIndex = 2;
            this.lblInstr.Text = "Arrastra los puntos para modificar la curva localmente.";

            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.LightGray;
            this.pnlControles.Controls.Add(this.btnLimpiar);
            this.pnlControles.Controls.Add(this.btnAnimar);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControles.Location = new System.Drawing.Point(0, 540);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(800, 60);
            this.pnlControles.TabIndex = 1;

            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(190, 15);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // 
            // btnAnimar
            // 
            this.btnAnimar.Location = new System.Drawing.Point(20, 15);
            this.btnAnimar.Name = "btnAnimar";
            this.btnAnimar.Size = new System.Drawing.Size(150, 30);
            this.btnAnimar.TabIndex = 0;
            this.btnAnimar.Text = "Iniciar Animación";
            this.btnAnimar.UseVisualStyleBackColor = true;
            this.btnAnimar.Click += new System.EventHandler(this.btnAnimar_Click);

            // 
            // picLienzo
            // 
            this.picLienzo.BackColor = System.Drawing.Color.White;
            this.picLienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLienzo.Location = new System.Drawing.Point(0, 40);
            this.picLienzo.Name = "picLienzo";
            this.picLienzo.Size = new System.Drawing.Size(800, 500);
            this.picLienzo.TabIndex = 2;
            this.picLienzo.TabStop = false;
            this.picLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicLienzo_MouseDown);
            this.picLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicLienzo_MouseMove);
            this.picLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicLienzo_MouseUp);
            this.picLienzo.Paint += new System.Windows.Forms.PaintEventHandler(this.PicLienzo_Paint);

            // 
            // frmBSpline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.picLienzo);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmBSpline";
            this.Text = "Simulación Curvas B-Spline";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrden)).EndInit();
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NumericUpDown numOrden;
        private System.Windows.Forms.Label lblInstr;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAnimar;
        private System.Windows.Forms.PictureBox picLienzo;
    }
}