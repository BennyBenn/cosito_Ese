namespace Data_Digester
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.pruebasDataSet = new Data_Digester.pruebasDataSet();
            this.rAMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAMOTableAdapter = new Data_Digester.pruebasDataSetTableAdapters.RAMOTableAdapter();
            this.aÑODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIÓNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "ramo",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.listBox1.Location = new System.Drawing.Point(62, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(191, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 84);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(317, 30);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 84);
            this.listBox3.TabIndex = 2;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(443, 30);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 84);
            this.listBox4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aÑODataGridViewTextBoxColumn,
            this.rAMODataGridViewTextBoxColumn,
            this.dESCRIPCIÓNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rAMOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(126, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 311);
            this.dataGridView1.TabIndex = 4;
            // 
            // pruebasDataSet
            // 
            this.pruebasDataSet.DataSetName = "pruebasDataSet";
            this.pruebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAMOBindingSource
            // 
            this.rAMOBindingSource.DataMember = "RAMO";
            this.rAMOBindingSource.DataSource = this.pruebasDataSet;
            // 
            // rAMOTableAdapter
            // 
            this.rAMOTableAdapter.ClearBeforeFill = true;
            // 
            // aÑODataGridViewTextBoxColumn
            // 
            this.aÑODataGridViewTextBoxColumn.DataPropertyName = "AÑO";
            this.aÑODataGridViewTextBoxColumn.HeaderText = "AÑO";
            this.aÑODataGridViewTextBoxColumn.Name = "aÑODataGridViewTextBoxColumn";
            // 
            // rAMODataGridViewTextBoxColumn
            // 
            this.rAMODataGridViewTextBoxColumn.DataPropertyName = "RAMO";
            this.rAMODataGridViewTextBoxColumn.HeaderText = "RAMO";
            this.rAMODataGridViewTextBoxColumn.Name = "rAMODataGridViewTextBoxColumn";
            // 
            // dESCRIPCIÓNDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIÓNDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCIÓN";
            this.dESCRIPCIÓNDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN";
            this.dESCRIPCIÓNDataGridViewTextBoxColumn.Name = "dESCRIPCIÓNDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 703);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMOBindingSource)).EndInit();
=======
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aÑODataGridViewTextBoxColumn,
            this.rAMODataGridViewTextBoxColumn,
            this.dESCRIPCIÓNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rAMOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
>>>>>>> 0a9c2375762f31a0d989f1990827260dbf88459a
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private pruebasDataSet pruebasDataSet;
        private System.Windows.Forms.BindingSource rAMOBindingSource;
        private pruebasDataSetTableAdapters.RAMOTableAdapter rAMOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aÑODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIÓNDataGridViewTextBoxColumn;
=======
        private System.Windows.Forms.DataGridView dataGridView1;
>>>>>>> 0a9c2375762f31a0d989f1990827260dbf88459a
    }
}

