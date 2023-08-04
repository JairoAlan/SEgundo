namespace Ventas_Jairo
{
    partial class FrmConsultaRepVentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbtnListRepVen = new System.Windows.Forms.RadioButton();
            this.rbtnRepVen_Ofi = new System.Windows.Forms.RadioButton();
            this.rbtnCuoRepVent = new System.Windows.Forms.RadioButton();
            this.cmbOficinas = new System.Windows.Forms.ComboBox();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.txtRepCuota = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRepCuota);
            this.groupBox1.Controls.Add(this.cmbOperadores);
            this.groupBox1.Controls.Add(this.cmbOficinas);
            this.groupBox1.Controls.Add(this.rbtnCuoRepVent);
            this.groupBox1.Controls.Add(this.rbtnRepVen_Ofi);
            this.groupBox1.Controls.Add(this.rbtnListRepVen);
            this.groupBox1.Location = new System.Drawing.Point(52, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Representantes de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Representante de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elige la opcion y luego da clic en \"Mostrar\"  para ver la consulta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(621, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rbtnListRepVen
            // 
            this.rbtnListRepVen.AutoSize = true;
            this.rbtnListRepVen.Location = new System.Drawing.Point(7, 22);
            this.rbtnListRepVen.Name = "rbtnListRepVen";
            this.rbtnListRepVen.Size = new System.Drawing.Size(254, 20);
            this.rbtnListRepVen.TabIndex = 0;
            this.rbtnListRepVen.TabStop = true;
            this.rbtnListRepVen.Text = "Listado de Representantes de Ventas";
            this.rbtnListRepVen.UseVisualStyleBackColor = true;
            // 
            // rbtnRepVen_Ofi
            // 
            this.rbtnRepVen_Ofi.AutoSize = true;
            this.rbtnRepVen_Ofi.Location = new System.Drawing.Point(7, 49);
            this.rbtnRepVen_Ofi.Name = "rbtnRepVen_Ofi";
            this.rbtnRepVen_Ofi.Size = new System.Drawing.Size(348, 20);
            this.rbtnRepVen_Ofi.TabIndex = 1;
            this.rbtnRepVen_Ofi.TabStop = true;
            this.rbtnRepVen_Ofi.Text = "Representantes de Ventas que pertenecen a oficinas:";
            this.rbtnRepVen_Ofi.UseVisualStyleBackColor = true;
            // 
            // rbtnCuoRepVent
            // 
            this.rbtnCuoRepVent.AutoSize = true;
            this.rbtnCuoRepVent.Location = new System.Drawing.Point(7, 76);
            this.rbtnCuoRepVent.Name = "rbtnCuoRepVent";
            this.rbtnCuoRepVent.Size = new System.Drawing.Size(238, 20);
            this.rbtnCuoRepVent.TabIndex = 2;
            this.rbtnCuoRepVent.TabStop = true;
            this.rbtnCuoRepVent.Text = "Cuota de Representante de Ventas";
            this.rbtnCuoRepVent.UseVisualStyleBackColor = true;
            // 
            // cmbOficinas
            // 
            this.cmbOficinas.FormattingEnabled = true;
            this.cmbOficinas.Location = new System.Drawing.Point(385, 45);
            this.cmbOficinas.Name = "cmbOficinas";
            this.cmbOficinas.Size = new System.Drawing.Size(121, 24);
            this.cmbOficinas.TabIndex = 3;
            // 
            // cmbOperadores
            // 
            this.cmbOperadores.FormattingEnabled = true;
            this.cmbOperadores.Location = new System.Drawing.Point(263, 75);
            this.cmbOperadores.Name = "cmbOperadores";
            this.cmbOperadores.Size = new System.Drawing.Size(121, 24);
            this.cmbOperadores.TabIndex = 4;
            // 
            // txtRepCuota
            // 
            this.txtRepCuota.Location = new System.Drawing.Point(406, 77);
            this.txtRepCuota.Name = "txtRepCuota";
            this.txtRepCuota.Size = new System.Drawing.Size(100, 22);
            this.txtRepCuota.TabIndex = 5;
            // 
            // FrmConsultaRepVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 514);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaRepVentas";
            this.Text = "FrmConsultaRepVentas";
            this.Load += new System.EventHandler(this.FrmConsultaRepVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtnCuoRepVent;
        private System.Windows.Forms.RadioButton rbtnRepVen_Ofi;
        private System.Windows.Forms.RadioButton rbtnListRepVen;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.ComboBox cmbOficinas;
        private System.Windows.Forms.TextBox txtRepCuota;
    }
}