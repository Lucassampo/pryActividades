namespace pryActividades
{
    partial class frmMostrar
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
            this.lbMuestra = new System.Windows.Forms.ListBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.cboTipoActividad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbMuestra
            // 
            this.lbMuestra.FormattingEnabled = true;
            this.lbMuestra.ItemHeight = 16;
            this.lbMuestra.Location = new System.Drawing.Point(13, 115);
            this.lbMuestra.Margin = new System.Windows.Forms.Padding(4);
            this.lbMuestra.Name = "lbMuestra";
            this.lbMuestra.Size = new System.Drawing.Size(421, 260);
            this.lbMuestra.TabIndex = 3;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(37, 55);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(147, 29);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "Actividades";
            this.lblActividad.Click += new System.EventHandler(this.lblActividad_Click);
            // 
            // cboTipoActividad
            // 
            this.cboTipoActividad.FormattingEnabled = true;
            this.cboTipoActividad.Items.AddRange(new object[] {
            "Relvevamiento",
            "Propuesta",
            "Diagnostico",
            "Analisis",
            "Diagrama base de datos",
            "Programacion"});
            this.cboTipoActividad.Location = new System.Drawing.Point(191, 60);
            this.cboTipoActividad.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoActividad.Name = "cboTipoActividad";
            this.cboTipoActividad.Size = new System.Drawing.Size(154, 24);
            this.cboTipoActividad.TabIndex = 5;
            this.cboTipoActividad.SelectedIndexChanged += new System.EventHandler(this.cboTipoActividad_SelectedIndexChanged);
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 406);
            this.Controls.Add(this.cboTipoActividad);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.lbMuestra);
            this.Name = "frmMostrar";
            this.Text = "frmMostrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMuestra;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox cboTipoActividad;
    }
}