namespace WindowsApplication1
{
    partial class Form13
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.batchidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsApplication1.Database1DataSet();
            this.batchTableAdapter = new WindowsApplication1.Database1DataSetTableAdapters.BatchTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startingDateDataGridViewTextBoxColumn,
            this.endingDateDataGridViewTextBoxColumn,
            this.lecturerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.batchBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // batchidDataGridViewTextBoxColumn
            // 
            this.batchidDataGridViewTextBoxColumn.DataPropertyName = "Batchid";
            this.batchidDataGridViewTextBoxColumn.HeaderText = "Batchid";
            this.batchidDataGridViewTextBoxColumn.Name = "batchidDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // startingDateDataGridViewTextBoxColumn
            // 
            this.startingDateDataGridViewTextBoxColumn.DataPropertyName = "StartingDate";
            this.startingDateDataGridViewTextBoxColumn.HeaderText = "StartingDate";
            this.startingDateDataGridViewTextBoxColumn.Name = "startingDateDataGridViewTextBoxColumn";
            // 
            // endingDateDataGridViewTextBoxColumn
            // 
            this.endingDateDataGridViewTextBoxColumn.DataPropertyName = "EndingDate";
            this.endingDateDataGridViewTextBoxColumn.HeaderText = "EndingDate";
            this.endingDateDataGridViewTextBoxColumn.Name = "endingDateDataGridViewTextBoxColumn";
            // 
            // lecturerDataGridViewTextBoxColumn
            // 
            this.lecturerDataGridViewTextBoxColumn.DataPropertyName = "Lecturer";
            this.lecturerDataGridViewTextBoxColumn.HeaderText = "Lecturer";
            this.lecturerDataGridViewTextBoxColumn.Name = "lecturerDataGridViewTextBoxColumn";
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataMember = "Batch";
            this.batchBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batchTableAdapter
            // 
            this.batchTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show All Batch Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form13";
            this.Text = "Search Batch Details";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource batchBindingSource;
        private WindowsApplication1.Database1DataSetTableAdapters.BatchTableAdapter batchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}