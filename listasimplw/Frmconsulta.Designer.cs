namespace listasimplw
{
    partial class Frmconsulta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbllegajo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblsueldo = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.btninsertar = new System.Windows.Forms.Button();
            this.cmbarea = new System.Windows.Forms.ComboBox();
            this.txtlegajo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.grpconsultas = new System.Windows.Forms.GroupBox();
            this.rdtodos = new System.Windows.Forms.RadioButton();
            this.rdsueldo = new System.Windows.Forms.RadioButton();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.rdarea = new System.Windows.Forms.RadioButton();
            this.cmbareas = new System.Windows.Forms.ComboBox();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.dtgconsulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpconsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllegajo
            // 
            this.lbllegajo.AutoSize = true;
            this.lbllegajo.Location = new System.Drawing.Point(12, 22);
            this.lbllegajo.Name = "lbllegajo";
            this.lbllegajo.Size = new System.Drawing.Size(39, 15);
            this.lbllegajo.TabIndex = 0;
            this.lbllegajo.Text = "legajo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(156, 22);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(49, 15);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "nombre";
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.Location = new System.Drawing.Point(449, 16);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(42, 15);
            this.lblsueldo.TabIndex = 2;
            this.lblsueldo.Text = "sueldo";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(291, 16);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(29, 15);
            this.lblarea.TabIndex = 3;
            this.lblarea.Text = "area";
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(559, 22);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 4;
            this.btninsertar.Text = "insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            // 
            // cmbarea
            // 
            this.cmbarea.FormattingEnabled = true;
            this.cmbarea.Location = new System.Drawing.Point(291, 57);
            this.cmbarea.Name = "cmbarea";
            this.cmbarea.Size = new System.Drawing.Size(121, 23);
            this.cmbarea.TabIndex = 5;
            // 
            // txtlegajo
            // 
            this.txtlegajo.Location = new System.Drawing.Point(12, 57);
            this.txtlegajo.Name = "txtlegajo";
            this.txtlegajo.Size = new System.Drawing.Size(100, 23);
            this.txtlegajo.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(156, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 7;
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(449, 57);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(100, 23);
            this.txtsueldo.TabIndex = 8;
            // 
            // grpconsultas
            // 
            this.grpconsultas.Controls.Add(this.dtgconsulta);
            this.grpconsultas.Controls.Add(this.btnconsulta);
            this.grpconsultas.Controls.Add(this.cmbareas);
            this.grpconsultas.Controls.Add(this.rdarea);
            this.grpconsultas.Controls.Add(this.txtconsulta);
            this.grpconsultas.Controls.Add(this.rdsueldo);
            this.grpconsultas.Controls.Add(this.rdtodos);
            this.grpconsultas.Location = new System.Drawing.Point(23, 132);
            this.grpconsultas.Name = "grpconsultas";
            this.grpconsultas.Size = new System.Drawing.Size(651, 277);
            this.grpconsultas.TabIndex = 9;
            this.grpconsultas.TabStop = false;
            this.grpconsultas.Text = "consulta";
            // 
            // rdtodos
            // 
            this.rdtodos.AutoSize = true;
            this.rdtodos.Location = new System.Drawing.Point(6, 22);
            this.rdtodos.Name = "rdtodos";
            this.rdtodos.Size = new System.Drawing.Size(55, 19);
            this.rdtodos.TabIndex = 0;
            this.rdtodos.TabStop = true;
            this.rdtodos.Text = "todos";
            this.rdtodos.UseVisualStyleBackColor = true;
            // 
            // rdsueldo
            // 
            this.rdsueldo.AutoSize = true;
            this.rdsueldo.Location = new System.Drawing.Point(88, 22);
            this.rdsueldo.Name = "rdsueldo";
            this.rdsueldo.Size = new System.Drawing.Size(60, 19);
            this.rdsueldo.TabIndex = 1;
            this.rdsueldo.TabStop = true;
            this.rdsueldo.Text = "sueldo";
            this.rdsueldo.UseVisualStyleBackColor = true;
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(197, 18);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(100, 23);
            this.txtconsulta.TabIndex = 2;
            // 
            // rdarea
            // 
            this.rdarea.AutoSize = true;
            this.rdarea.Location = new System.Drawing.Point(330, 22);
            this.rdarea.Name = "rdarea";
            this.rdarea.Size = new System.Drawing.Size(47, 19);
            this.rdarea.TabIndex = 3;
            this.rdarea.TabStop = true;
            this.rdarea.Text = "area";
            this.rdarea.UseVisualStyleBackColor = true;
            // 
            // cmbareas
            // 
            this.cmbareas.FormattingEnabled = true;
            this.cmbareas.Location = new System.Drawing.Point(405, 18);
            this.cmbareas.Name = "cmbareas";
            this.cmbareas.Size = new System.Drawing.Size(121, 23);
            this.cmbareas.TabIndex = 4;
            // 
            // btnconsulta
            // 
            this.btnconsulta.Location = new System.Drawing.Point(557, 17);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(75, 23);
            this.btnconsulta.TabIndex = 5;
            this.btnconsulta.Text = "consulta";
            this.btnconsulta.UseVisualStyleBackColor = true;
            // 
            // dtgconsulta
            // 
            this.dtgconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgconsulta.Location = new System.Drawing.Point(99, 76);
            this.dtgconsulta.Name = "dtgconsulta";
            this.dtgconsulta.RowTemplate.Height = 25;
            this.dtgconsulta.Size = new System.Drawing.Size(440, 195);
            this.dtgconsulta.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "legajo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "area";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "sueldo";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.grpconsultas);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtlegajo);
            this.Controls.Add(this.cmbarea);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblsueldo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbllegajo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpconsultas.ResumeLayout(false);
            this.grpconsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbllegajo;
        private Label lblnombre;
        private Label lblsueldo;
        private Label lblarea;
        private Button btninsertar;
        private ComboBox cmbarea;
        private TextBox txtlegajo;
        private TextBox txtnombre;
        private TextBox txtsueldo;
        private GroupBox grpconsultas;
        private DataGridView dtgconsulta;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnconsulta;
        private ComboBox cmbareas;
        private RadioButton rdarea;
        private TextBox txtconsulta;
        private RadioButton rdsueldo;
        private RadioButton rdtodos;
    }
}