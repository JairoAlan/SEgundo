namespace Ventas_Jairo
{
    partial class FrmConsultaOficina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnListOfi = new System.Windows.Forms.RadioButton();
            this.rbtnOfiDir = new System.Windows.Forms.RadioButton();
            this.rbtnObjetVentOfi = new System.Windows.Forms.RadioButton();
            this.cmbRepDirVen = new System.Windows.Forms.ComboBox();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.txtObjOfi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Oficinas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elige una opcion y luego da clic en \"Mostrar\" para ver la consulta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObjOfi);
            this.groupBox1.Controls.Add(this.cmbOperadores);
            this.groupBox1.Controls.Add(this.cmbRepDirVen);
            this.groupBox1.Controls.Add(this.rbtnObjetVentOfi);
            this.groupBox1.Controls.Add(this.rbtnOfiDir);
            this.groupBox1.Controls.Add(this.rbtnListOfi);
            this.groupBox1.Location = new System.Drawing.Point(97, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oficinas";
            // 
            // rbtnListOfi
            // 
            this.rbtnListOfi.AutoSize = true;
            this.rbtnListOfi.Location = new System.Drawing.Point(7, 29);
            this.rbtnListOfi.Name = "rbtnListOfi";
            this.rbtnListOfi.Size = new System.Drawing.Size(142, 20);
            this.rbtnListOfi.TabIndex = 0;
            this.rbtnListOfi.TabStop = true;
            this.rbtnListOfi.Text = "Listado de Oficinas";
            this.rbtnListOfi.UseVisualStyleBackColor = true;
            // 
            // rbtnOfiDir
            // 
            this.rbtnOfiDir.AutoSize = true;
            this.rbtnOfiDir.Location = new System.Drawing.Point(7, 58);
            this.rbtnOfiDir.Name = "rbtnOfiDir";
            this.rbtnOfiDir.Size = new System.Drawing.Size(249, 20);
            this.rbtnOfiDir.TabIndex = 1;
            this.rbtnOfiDir.TabStop = true;
            this.rbtnOfiDir.Text = "Oficinas que pertenecen a Directores";
            this.rbtnOfiDir.UseVisualStyleBackColor = true;
            // 
            // rbtnObjetVentOfi
            // 
            this.rbtnObjetVentOfi.AutoSize = true;
            this.rbtnObjetVentOfi.Location = new System.Drawing.Point(7, 96);
            this.rbtnObjetVentOfi.Name = "rbtnObjetVentOfi";
            this.rbtnObjetVentOfi.Size = new System.Drawing.Size(205, 20);
            this.rbtnObjetVentOfi.TabIndex = 2;
            this.rbtnObjetVentOfi.TabStop = true;
            this.rbtnObjetVentOfi.Text = "Objetivo de Venta de Oficinas";
            this.rbtnObjetVentOfi.UseVisualStyleBackColor = true;
            // 
            // cmbRepDirVen
            // 
            this.cmbRepDirVen.FormattingEnabled = true;
            this.cmbRepDirVen.Location = new System.Drawing.Point(281, 54);
            this.cmbRepDirVen.Name = "cmbRepDirVen";
            this.cmbRepDirVen.Size = new System.Drawing.Size(121, 24);
            this.cmbRepDirVen.TabIndex = 3;
            // 
            // cmbOperadores
            // 
            this.cmbOperadores.FormattingEnabled = true;
            this.cmbOperadores.Location = new System.Drawing.Point(248, 94);
            this.cmbOperadores.Name = "cmbOperadores";
            this.cmbOperadores.Size = new System.Drawing.Size(121, 24);
            this.cmbOperadores.TabIndex = 4;
            // 
            // txtObjOfi
            // 
            this.txtObjOfi.Location = new System.Drawing.Point(405, 96);
            this.txtObjOfi.Name = "txtObjOfi";
            this.txtObjOfi.Size = new System.Drawing.Size(100, 22);
            this.txtObjOfi.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(700, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // FrmConsultaOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaOficina";
            this.Text = "FrmConsultaOficina";
            this.Load += new System.EventHandler(this.FrmConsultaOficina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnObjetVentOfi;
        private System.Windows.Forms.RadioButton rbtnOfiDir;
        private System.Windows.Forms.RadioButton rbtnListOfi;
        private System.Windows.Forms.ComboBox cmbRepDirVen;
        private System.Windows.Forms.TextBox txtObjOfi;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}