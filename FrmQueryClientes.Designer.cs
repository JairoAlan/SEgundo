namespace Ventas_Jairo
{
    partial class FrmQueryClientes
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
            this.rbtnListadoClientes = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rbnClie_Rep = new System.Windows.Forms.RadioButton();
            this.rbtnClie_Lim = new System.Windows.Forms.RadioButton();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.txtClieExi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClieExi);
            this.groupBox1.Controls.Add(this.cmbOperadores);
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.rbtnClie_Lim);
            this.groupBox1.Controls.Add(this.rbnClie_Rep);
            this.groupBox1.Controls.Add(this.rbtnListadoClientes);
            this.groupBox1.Location = new System.Drawing.Point(86, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elige una opcion y luego da clic en \"Mostrar\" para ver la consulta";
            // 
            // rbtnListadoClientes
            // 
            this.rbtnListadoClientes.AutoSize = true;
            this.rbtnListadoClientes.Location = new System.Drawing.Point(6, 21);
            this.rbtnListadoClientes.Name = "rbtnListadoClientes";
            this.rbtnListadoClientes.Size = new System.Drawing.Size(123, 20);
            this.rbtnListadoClientes.TabIndex = 0;
            this.rbtnListadoClientes.TabStop = true;
            this.rbtnListadoClientes.Text = "Listado Clientes";
            this.rbtnListadoClientes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(627, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbnClie_Rep
            // 
            this.rbnClie_Rep.AutoSize = true;
            this.rbnClie_Rep.Location = new System.Drawing.Point(7, 48);
            this.rbnClie_Rep.Name = "rbnClie_Rep";
            this.rbnClie_Rep.Size = new System.Drawing.Size(254, 20);
            this.rbnClie_Rep.TabIndex = 1;
            this.rbnClie_Rep.TabStop = true;
            this.rbnClie_Rep.Text = "Cliente que pertenecen al Rep Ventas";
            this.rbnClie_Rep.UseVisualStyleBackColor = true;
            this.rbnClie_Rep.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnClie_Lim
            // 
            this.rbtnClie_Lim.AutoSize = true;
            this.rbtnClie_Lim.Location = new System.Drawing.Point(7, 87);
            this.rbtnClie_Lim.Name = "rbtnClie_Lim";
            this.rbtnClie_Lim.Size = new System.Drawing.Size(222, 20);
            this.rbtnClie_Lim.TabIndex = 2;
            this.rbtnClie_Lim.TabStop = true;
            this.rbtnClie_Lim.Text = "Clientes con limite de Credito de:";
            this.rbtnClie_Lim.UseVisualStyleBackColor = true;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(284, 44);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 24);
            this.cmbClientes.TabIndex = 3;
            // 
            // cmbOperadores
            // 
            this.cmbOperadores.FormattingEnabled = true;
            this.cmbOperadores.Location = new System.Drawing.Point(236, 82);
            this.cmbOperadores.Name = "cmbOperadores";
            this.cmbOperadores.Size = new System.Drawing.Size(79, 24);
            this.cmbOperadores.TabIndex = 4;
            // 
            // txtClieExi
            // 
            this.txtClieExi.Location = new System.Drawing.Point(335, 83);
            this.txtClieExi.Name = "txtClieExi";
            this.txtClieExi.Size = new System.Drawing.Size(100, 22);
            this.txtClieExi.TabIndex = 5;
            // 
            // FrmQueryClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQueryClientes";
            this.Text = "FrmQueryClientes";
            this.Load += new System.EventHandler(this.FrmQueryClientes_Load);
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
        private System.Windows.Forms.RadioButton rbtnListadoClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbnClie_Rep;
        private System.Windows.Forms.RadioButton rbtnClie_Lim;
        private System.Windows.Forms.TextBox txtClieExi;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.ComboBox cmbClientes;
    }
}