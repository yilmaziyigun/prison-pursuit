namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vatandasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication2.DataSet1();
            this.vatandasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vatandasTableAdapter = new WindowsFormsApplication2.DataSet1TableAdapters.vatandasTableAdapter();
            this.vatandasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatandasadsaoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatandasdogumgunuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatandassicilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicilnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatandasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatandasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(948, 473);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button8
            // 
            this.button8.ImageIndex = 0;
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(574, 52);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(189, 113);
            this.button8.TabIndex = 6;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
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
            // button5
            // 
            this.button5.ImageIndex = 5;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(377, 50);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 113);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ImageIndex = 7;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(180, 50);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 113);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vatandasidDataGridViewTextBoxColumn,
            this.vatandasadsaoyadDataGridViewTextBoxColumn,
            this.vatandasdogumgunuDataGridViewTextBoxColumn,
            this.vatandassicilDataGridViewTextBoxColumn,
            this.Suc,
            this.sicilnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vatandasBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(948, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // vatandasBindingSource1
            // 
            this.vatandasBindingSource1.DataMember = "vatandas";
            this.vatandasBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vatandasBindingSource
            // 
            this.vatandasBindingSource.DataMember = "vatandas";
            this.vatandasBindingSource.DataSource = this.dataSet1;
            // 
            // vatandasTableAdapter
            // 
            this.vatandasTableAdapter.ClearBeforeFill = true;
            // 
            // vatandasidDataGridViewTextBoxColumn
            // 
            this.vatandasidDataGridViewTextBoxColumn.DataPropertyName = "vatandas_id";
            this.vatandasidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.vatandasidDataGridViewTextBoxColumn.Name = "vatandasidDataGridViewTextBoxColumn";
            this.vatandasidDataGridViewTextBoxColumn.ReadOnly = true;
            this.vatandasidDataGridViewTextBoxColumn.Width = 35;
            // 
            // vatandasadsaoyadDataGridViewTextBoxColumn
            // 
            this.vatandasadsaoyadDataGridViewTextBoxColumn.DataPropertyName = "vatandas_adsaoyad";
            this.vatandasadsaoyadDataGridViewTextBoxColumn.HeaderText = "ADSOYAD";
            this.vatandasadsaoyadDataGridViewTextBoxColumn.Name = "vatandasadsaoyadDataGridViewTextBoxColumn";
            this.vatandasadsaoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vatandasdogumgunuDataGridViewTextBoxColumn
            // 
            this.vatandasdogumgunuDataGridViewTextBoxColumn.DataPropertyName = "vatandas_dogumgunu";
            this.vatandasdogumgunuDataGridViewTextBoxColumn.HeaderText = "DOĞUMTARİHİ";
            this.vatandasdogumgunuDataGridViewTextBoxColumn.Name = "vatandasdogumgunuDataGridViewTextBoxColumn";
            this.vatandasdogumgunuDataGridViewTextBoxColumn.ReadOnly = true;
            this.vatandasdogumgunuDataGridViewTextBoxColumn.Width = 120;
            // 
            // vatandassicilDataGridViewTextBoxColumn
            // 
            this.vatandassicilDataGridViewTextBoxColumn.DataPropertyName = "vatandas_sicil";
            this.vatandassicilDataGridViewTextBoxColumn.HeaderText = "SİCİLDURUM";
            this.vatandassicilDataGridViewTextBoxColumn.Name = "vatandassicilDataGridViewTextBoxColumn";
            this.vatandassicilDataGridViewTextBoxColumn.ReadOnly = true;
            this.vatandassicilDataGridViewTextBoxColumn.Width = 110;
            // 
            // Suc
            // 
            this.Suc.HeaderText = "SUÇU";
            this.Suc.Name = "Suc";
            this.Suc.ReadOnly = true;
            this.Suc.Visible = false;
            // 
            // sicilnoDataGridViewTextBoxColumn
            // 
            this.sicilnoDataGridViewTextBoxColumn.DataPropertyName = "sicil_no";
            this.sicilnoDataGridViewTextBoxColumn.HeaderText = "SUÇ_NO";
            this.sicilnoDataGridViewTextBoxColumn.Name = "sicilnoDataGridViewTextBoxColumn";
            this.sicilnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sicilnoDataGridViewTextBoxColumn.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 473);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Şubeye Giren Vatandaşlar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatandasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatandasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vatandasBindingSource;
        private DataSet1TableAdapters.vatandasTableAdapter vatandasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vatandasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatandasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatandasadsaoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatandasdogumgunuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatandassicilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicilnoDataGridViewTextBoxColumn;
    }
}

