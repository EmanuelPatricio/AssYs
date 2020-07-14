namespace MenuPrincipal
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombrePrimer = new System.Windows.Forms.Label();
            this.lblPosicionPrimer = new System.Windows.Forms.Label();
            this.lblNombreUltimo = new System.Windows.Forms.Label();
            this.lblPosicionUltimo = new System.Windows.Forms.Label();
            this.lblHoraPrimer = new System.Windows.Forms.Label();
            this.lblHoraUltimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFecha.Location = new System.Drawing.Point(183, 173);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(367, 33);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(183, 88);
            this.lblHora.Name = "lblHora";
            this.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHora.Size = new System.Drawing.Size(367, 75);
            this.lblHora.TabIndex = 3;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // solidGauge1
            // 
            this.solidGauge1.Location = new System.Drawing.Point(51, 332);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(246, 178);
            this.solidGauge1.TabIndex = 5;
            this.solidGauge1.Text = "solidGauge1";
            this.solidGauge1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.solidGauge1_ChildChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.icons8_male_user_100;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(408, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 46);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Presentacion.Properties.Resources.icons8_male_user_100;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(408, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 46);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "EMPLEADOS REGISTRADOS HOY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "ULTIMO EMPLEADO REGISTRADO HOY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "PRIMER EMPLEADO REGISTRADO HOY";
            // 
            // lblNombrePrimer
            // 
            this.lblNombrePrimer.AutoSize = true;
            this.lblNombrePrimer.Location = new System.Drawing.Point(494, 332);
            this.lblNombrePrimer.Name = "lblNombrePrimer";
            this.lblNombrePrimer.Size = new System.Drawing.Size(35, 13);
            this.lblNombrePrimer.TabIndex = 12;
            this.lblNombrePrimer.Text = "label4";
            // 
            // lblPosicionPrimer
            // 
            this.lblPosicionPrimer.AutoSize = true;
            this.lblPosicionPrimer.Location = new System.Drawing.Point(494, 365);
            this.lblPosicionPrimer.Name = "lblPosicionPrimer";
            this.lblPosicionPrimer.Size = new System.Drawing.Size(35, 13);
            this.lblPosicionPrimer.TabIndex = 13;
            this.lblPosicionPrimer.Text = "label4";
            // 
            // lblNombreUltimo
            // 
            this.lblNombreUltimo.AutoSize = true;
            this.lblNombreUltimo.Location = new System.Drawing.Point(494, 452);
            this.lblNombreUltimo.Name = "lblNombreUltimo";
            this.lblNombreUltimo.Size = new System.Drawing.Size(35, 13);
            this.lblNombreUltimo.TabIndex = 14;
            this.lblNombreUltimo.Text = "label4";
            // 
            // lblPosicionUltimo
            // 
            this.lblPosicionUltimo.AutoSize = true;
            this.lblPosicionUltimo.Location = new System.Drawing.Point(494, 485);
            this.lblPosicionUltimo.Name = "lblPosicionUltimo";
            this.lblPosicionUltimo.Size = new System.Drawing.Size(35, 13);
            this.lblPosicionUltimo.TabIndex = 15;
            this.lblPosicionUltimo.Text = "label4";
            // 
            // lblHoraPrimer
            // 
            this.lblHoraPrimer.AutoSize = true;
            this.lblHoraPrimer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraPrimer.Location = new System.Drawing.Point(612, 348);
            this.lblHoraPrimer.Name = "lblHoraPrimer";
            this.lblHoraPrimer.Size = new System.Drawing.Size(49, 14);
            this.lblHoraPrimer.TabIndex = 16;
            this.lblHoraPrimer.Text = "label4";
            // 
            // lblHoraUltimo
            // 
            this.lblHoraUltimo.AutoSize = true;
            this.lblHoraUltimo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraUltimo.Location = new System.Drawing.Point(612, 469);
            this.lblHoraUltimo.Name = "lblHoraUltimo";
            this.lblHoraUltimo.Size = new System.Drawing.Size(49, 14);
            this.lblHoraUltimo.TabIndex = 17;
            this.lblHoraUltimo.Text = "label4";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 577);
            this.Controls.Add(this.lblHoraUltimo);
            this.Controls.Add(this.lblHoraPrimer);
            this.Controls.Add(this.lblPosicionUltimo);
            this.Controls.Add(this.lblNombreUltimo);
            this.Controls.Add(this.lblPosicionPrimer);
            this.Controls.Add(this.lblNombrePrimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.solidGauge1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.Text = "AssYs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horafecha;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombrePrimer;
        private System.Windows.Forms.Label lblPosicionPrimer;
        private System.Windows.Forms.Label lblNombreUltimo;
        private System.Windows.Forms.Label lblPosicionUltimo;
        private System.Windows.Forms.Label lblHoraPrimer;
        private System.Windows.Forms.Label lblHoraUltimo;
    }
}