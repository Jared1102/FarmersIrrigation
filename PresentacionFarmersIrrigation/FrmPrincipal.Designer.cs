namespace PresentacionFarmersIrrigation
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.panelCornerRound1 = new PresentacionFarmersIrrigation.PanelCornerRound();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.pctrbLogo = new System.Windows.Forms.PictureBox();
            this.btnrExit = new PresentacionClubAjedrez.ButtonRound();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            this.panelCornerRound1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.btnrExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farmers Irrigation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(225)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnMonitoring);
            this.panel2.Controls.Add(this.btnControl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 992);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel3.Controls.Add(this.pctrbLogo);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 200);
            this.panel3.TabIndex = 0;
            // 
            // pPrincipal
            // 
            this.pPrincipal.Controls.Add(this.panelCornerRound1);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(416, 32);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1024, 992);
            this.pPrincipal.TabIndex = 2;
            // 
            // panelCornerRound1
            // 
            this.panelCornerRound1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCornerRound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panelCornerRound1.BorderRadius = 50;
            this.panelCornerRound1.Controls.Add(this.label2);
            this.panelCornerRound1.Controls.Add(this.pictureBox1);
            this.panelCornerRound1.Location = new System.Drawing.Point(183, 115);
            this.panelCornerRound1.Name = "panelCornerRound1";
            this.panelCornerRound1.Size = new System.Drawing.Size(710, 690);
            this.panelCornerRound1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Farmers Irrigation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PresentacionFarmersIrrigation.Properties.Resources.drip;
            this.pictureBox1.Location = new System.Drawing.Point(103, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::PresentacionFarmersIrrigation.Properties.Resources.salidColor_64;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(0, 908);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(20, 0, 50, 0);
            this.btnExit.Size = new System.Drawing.Size(416, 84);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Cerrar";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.BackColor = System.Drawing.Color.White;
            this.btnMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonitoring.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitoring.Image")));
            this.btnMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonitoring.Location = new System.Drawing.Point(0, 284);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Padding = new System.Windows.Forms.Padding(20, 0, 50, 0);
            this.btnMonitoring.Size = new System.Drawing.Size(416, 84);
            this.btnMonitoring.TabIndex = 2;
            this.btnMonitoring.Text = "Monitoreo";
            this.btnMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMonitoring.UseVisualStyleBackColor = false;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.White;
            this.btnControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.Image = global::PresentacionFarmersIrrigation.Properties.Resources.remote_control_64;
            this.btnControl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnControl.Location = new System.Drawing.Point(0, 200);
            this.btnControl.Name = "btnControl";
            this.btnControl.Padding = new System.Windows.Forms.Padding(20, 0, 50, 0);
            this.btnControl.Size = new System.Drawing.Size(416, 84);
            this.btnControl.TabIndex = 1;
            this.btnControl.Text = "Control de riego";
            this.btnControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // pctrbLogo
            // 
            this.pctrbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctrbLogo.Image = global::PresentacionFarmersIrrigation.Properties.Resources.drip;
            this.pctrbLogo.Location = new System.Drawing.Point(158, 44);
            this.pctrbLogo.Name = "pctrbLogo";
            this.pctrbLogo.Size = new System.Drawing.Size(100, 112);
            this.pctrbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbLogo.TabIndex = 0;
            this.pctrbLogo.TabStop = false;
            // 
            // btnrExit
            // 
            this.btnrExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrExit.FlatAppearance.BorderSize = 0;
            this.btnrExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrExit.Image = global::PresentacionFarmersIrrigation.Properties.Resources.closeRed_32;
            this.btnrExit.Location = new System.Drawing.Point(1408, -1);
            this.btnrExit.Name = "btnrExit";
            this.btnrExit.Size = new System.Drawing.Size(32, 32);
            this.btnrExit.TabIndex = 1;
            this.btnrExit.UseVisualStyleBackColor = true;
            this.btnrExit.Click += new System.EventHandler(this.btnrExit_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pPrincipal.ResumeLayout(false);
            this.panelCornerRound1.ResumeLayout(false);
            this.panelCornerRound1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private PresentacionClubAjedrez.ButtonRound btnrExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctrbLogo;
        private System.Windows.Forms.Panel pPrincipal;
        private PanelCornerRound panelCornerRound1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnMonitoring;
        private System.Windows.Forms.Button btnExit;
    }
}

