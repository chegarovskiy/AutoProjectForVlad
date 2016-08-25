namespace autoProject.formClases
{
    partial class FormAddExcelData
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
            this.btChooseFile = new System.Windows.Forms.Button();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.btOpenExcel = new System.Windows.Forms.Button();
            this.textBox_sheet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAddExcelDada = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btChooseFile
            // 
            this.btChooseFile.Location = new System.Drawing.Point(12, 24);
            this.btChooseFile.Name = "btChooseFile";
            this.btChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btChooseFile.TabIndex = 0;
            this.btChooseFile.Text = "choose file";
            this.btChooseFile.UseVisualStyleBackColor = true;
            this.btChooseFile.Click += new System.EventHandler(this.btChooseFile_Click);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(106, 26);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(166, 20);
            this.textBox_pass.TabIndex = 1;
            // 
            // btOpenExcel
            // 
            this.btOpenExcel.Location = new System.Drawing.Point(13, 54);
            this.btOpenExcel.Name = "btOpenExcel";
            this.btOpenExcel.Size = new System.Drawing.Size(75, 23);
            this.btOpenExcel.TabIndex = 2;
            this.btOpenExcel.Text = "Open Marks ";
            this.btOpenExcel.UseVisualStyleBackColor = true;
            this.btOpenExcel.Click += new System.EventHandler(this.btOpenExcel_Click);
            // 
            // textBox_sheet
            // 
            this.textBox_sheet.Location = new System.Drawing.Point(397, 54);
            this.textBox_sheet.Name = "textBox_sheet";
            this.textBox_sheet.Size = new System.Drawing.Size(166, 20);
            this.textBox_sheet.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 164);
            this.dataGridView1.TabIndex = 4;
            // 
            // btAddExcelDada
            // 
            this.btAddExcelDada.Location = new System.Drawing.Point(397, 23);
            this.btAddExcelDada.Name = "btAddExcelDada";
            this.btAddExcelDada.Size = new System.Drawing.Size(140, 23);
            this.btAddExcelDada.TabIndex = 5;
            this.btAddExcelDada.Text = "add current data in Base";
            this.btAddExcelDada.UseVisualStyleBackColor = true;
            this.btAddExcelDada.Click += new System.EventHandler(this.btAddExcelDada_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormAddExcelData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 276);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btAddExcelDada);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_sheet);
            this.Controls.Add(this.btOpenExcel);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.btChooseFile);
            this.Name = "FormAddExcelData";
            this.Text = "FormAddExcelData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChooseFile;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button btOpenExcel;
        private System.Windows.Forms.TextBox textBox_sheet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAddExcelDada;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}