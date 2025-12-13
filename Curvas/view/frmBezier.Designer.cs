
namespace CURVAS.Curvas.view

{
    partial class frmBezier
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
            this.picLienzo = new System.Windows.Forms.PictureBox();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAnimar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).BeginInit();
            this.pnlControles.SuspendLayout();
            this.SuspendLayout();

            // 
            // picLienzo
            // 
            this.picLienzo.BackColor = System.Drawing.Color.White;
            this.picLienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLienzo.Location = new System.Drawing.Point(0, 30);
            this.picLienzo.Name = "picLienzo";
            this.picLienzo.Size = new System.Drawing.Size(800, 510);
            this.picLienzo.TabIndex = 2;
            this.picLienzo.TabStop = false;
            this.picLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicLienzo_MouseDown);
            this.picLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicLienzo_MouseMove);
            this.picLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicLienzo_MouseUp);
            this.picLienzo.Paint += new System.Windows.Forms.PaintEventHandler(this.PicLienzo_Paint);

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
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(800, 30);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Click Izq: Agregar Punto | Arrastrar: Mover | Click Der: Borrar Último";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // frmBezier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.picLienzo);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmBezier";
            this.Text = "Simulación Curvas de Bézier";
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picLienzo;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAnimar;
        private System.Windows.Forms.Label lblInfo;
    }

}