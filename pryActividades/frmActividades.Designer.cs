namespace pryActividades
{
    partial class frmActividades
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.cboTipoActividad = new System.Windows.Forms.ComboBox();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(16, 43);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(279, 22);
            this.dtpFecha.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 23);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 91);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(12, 156);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(50, 16);
            this.lblDetalle.TabIndex = 3;
            this.lblDetalle.Text = "Detalle";
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
            this.cboTipoActividad.Location = new System.Drawing.Point(16, 111);
            this.cboTipoActividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoActividad.Name = "cboTipoActividad";
            this.cboTipoActividad.Size = new System.Drawing.Size(279, 24);
            this.cboTipoActividad.TabIndex = 4;
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optNo);
            this.mrcReunion.Controls.Add(this.optSi);
            this.mrcReunion.Location = new System.Drawing.Point(16, 286);
            this.mrcReunion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcReunion.Size = new System.Drawing.Size(280, 62);
            this.mrcReunion.TabIndex = 6;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Location = new System.Drawing.Point(148, 23);
            this.optNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(48, 20);
            this.optNo.TabIndex = 1;
            this.optNo.TabStop = true;
            this.optNo.Text = "NO";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Location = new System.Drawing.Point(43, 23);
            this.optSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(40, 20);
            this.optSi.TabIndex = 0;
            this.optSi.TabStop = true;
            this.optSi.Text = "SI";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkNotasReunion);
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkRepositorio);
            this.mrcTareas.Location = new System.Drawing.Point(16, 366);
            this.mrcTareas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTareas.Size = new System.Drawing.Size(280, 87);
            this.mrcTareas.TabIndex = 7;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(144, 59);
            this.chkNotasReunion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(118, 20);
            this.chkNotasReunion.TabIndex = 2;
            this.chkNotasReunion.Text = "Notas Reunion";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(144, 23);
            this.chkDebate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(74, 20);
            this.chkDebate.TabIndex = 1;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(8, 59);
            this.chkInvestigacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(108, 20);
            this.chkInvestigacion.TabIndex = 3;
            this.chkInvestigacion.Text = "Investigacion";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(8, 23);
            this.chkRepositorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(99, 20);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            this.chkRepositorio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(16, 484);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 28);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(196, 484);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(16, 177);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(272, 83);
            this.txtDetalle.TabIndex = 10;
            // 
            // frmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 554);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.cboTipoActividad);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmActividades";
            this.Text = "frmActividades";
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.ComboBox cboTipoActividad;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDetalle;
    }
}