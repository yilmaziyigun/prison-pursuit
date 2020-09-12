namespace WindowsFormsApplication2
{
    partial class persnlgoruntu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(persnlgoruntu));
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new WindowsFormsApplication2.DataSet2();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new WindowsFormsApplication2.DataSet2TableAdapters.PersonelTableAdapter();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(419, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 113);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iconfinder_f-cross_256_282471.ico");
            this.ımageList1.Images.SetKeyName(1, "iconfinder_go-first_118769.ico");
            this.ımageList1.Images.SetKeyName(2, "iconfinder_go-last_118772.ico");
            this.ımageList1.Images.SetKeyName(3, "iconfinder_go-next_118773.ico");
            this.ımageList1.Images.SetKeyName(4, "iconfinder_go-previous_118774.ico");
            this.ımageList1.Images.SetKeyName(5, "iconfinder_icon-136-document-edit_314724.ico");
            this.ımageList1.Images.SetKeyName(6, "iconfinder_magnifier_glass_1296372.ico");
            this.ımageList1.Images.SetKeyName(7, "iconfinder_plus_1646001.ico");
            // 
            // button2
            // 
            this.button2.ImageIndex = 5;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(222, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 113);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageIndex = 7;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(25, 80);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 113);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Görüntüle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(569, 191);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.dataSet2;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "per_id";
            this.peridDataGridViewTextBoxColumn.HeaderText = "per_id";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "per_ad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "per_ad";
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            this.peradDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // persoyDataGridViewTextBoxColumn
            // 
            this.persoyDataGridViewTextBoxColumn.DataPropertyName = "per_soy";
            this.persoyDataGridViewTextBoxColumn.HeaderText = "per_soy";
            this.persoyDataGridViewTextBoxColumn.Name = "persoyDataGridViewTextBoxColumn";
            this.persoyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // persnlgoruntu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "persnlgoruntu";
            this.Text = "persnlgoruntu";
            this.Load += new System.EventHandler(this.persnlgoruntu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private DataSet2TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyDataGridViewTextBoxColumn;
    }
}