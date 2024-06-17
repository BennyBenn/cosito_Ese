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
            this.components = new System.ComponentModel.Container();
            this.pruebasDataSet = new Data_Digester.pruebasDataSet();
            this.rAMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAMOTableAdapter = new Data_Digester.pruebasDataSetTableAdapters.RAMOTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dESCRIPCIÓNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aÑODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pruebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dESCRIPCIÓNDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIÓNDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCIÓN";
            this.dESCRIPCIÓNDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN";
            this.dESCRIPCIÓNDataGridViewTextBoxColumn.Name = "dESCRIPCIÓNDataGridViewTextBoxColumn";
            // 
            // rAMODataGridViewTextBoxColumn
            // 
            this.rAMODataGridViewTextBoxColumn.DataPropertyName = "RAMO";
            this.rAMODataGridViewTextBoxColumn.HeaderText = "RAMO";
            this.rAMODataGridViewTextBoxColumn.Name = "rAMODataGridViewTextBoxColumn";
            // 
            // aÑODataGridViewTextBoxColumn
            // 
            this.aÑODataGridViewTextBoxColumn.DataPropertyName = "AÑO";
            this.aÑODataGridViewTextBoxColumn.HeaderText = "AÑO";
            this.aÑODataGridViewTextBoxColumn.Name = "aÑODataGridViewTextBoxColumn";
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 127);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pruebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private pruebasDataSet pruebasDataSet;
        private System.Windows.Forms.BindingSource rAMOBindingSource;
        private pruebasDataSetTableAdapters.RAMOTableAdapter rAMOTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIÓNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aÑODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}

