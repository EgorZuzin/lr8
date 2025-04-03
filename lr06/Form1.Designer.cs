namespace lr06
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lr06DataSet = new lr06.lr06DataSet();
            this.kvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kvTableAdapter = new lr06.lr06DataSetTableAdapters.kvTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vladelecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozvrastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lr06DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vladelecDataGridViewTextBoxColumn,
            this.размерDataGridViewTextBoxColumn,
            this.vozvrastDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kvBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(181, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // lr06DataSet
            // 
            this.lr06DataSet.DataSetName = "lr06DataSet";
            this.lr06DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kvBindingSource
            // 
            this.kvBindingSource.DataMember = "kv";
            this.kvBindingSource.DataSource = this.lr06DataSet;
            // 
            // kvTableAdapter
            // 
            this.kvTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // vladelecDataGridViewTextBoxColumn
            // 
            this.vladelecDataGridViewTextBoxColumn.DataPropertyName = "Vladelec";
            this.vladelecDataGridViewTextBoxColumn.HeaderText = "Vladelec";
            this.vladelecDataGridViewTextBoxColumn.Name = "vladelecDataGridViewTextBoxColumn";
            // 
            // размерDataGridViewTextBoxColumn
            // 
            this.размерDataGridViewTextBoxColumn.DataPropertyName = "Размер";
            this.размерDataGridViewTextBoxColumn.HeaderText = "Размер";
            this.размерDataGridViewTextBoxColumn.Name = "размерDataGridViewTextBoxColumn";
            // 
            // vozvrastDataGridViewTextBoxColumn
            // 
            this.vozvrastDataGridViewTextBoxColumn.DataPropertyName = "Vozvrast";
            this.vozvrastDataGridViewTextBoxColumn.HeaderText = "Vozvrast";
            this.vozvrastDataGridViewTextBoxColumn.Name = "vozvrastDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lr06DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private lr06DataSet lr06DataSet;
        private System.Windows.Forms.BindingSource kvBindingSource;
        private lr06DataSetTableAdapters.kvTableAdapter kvTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vladelecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozvrastDataGridViewTextBoxColumn;
    }
}

