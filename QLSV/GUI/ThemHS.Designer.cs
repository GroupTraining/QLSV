namespace QLSV.GUI
{
    partial class ThemHS
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
            this.label3 = new System.Windows.Forms.Label();
            this.textMasv = new System.Windows.Forms.TextBox();
            this.textMalop = new System.Windows.Forms.TextBox();
            this.textTensv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sinh Viên";
            // 
            // textMasv
            // 
            this.textMasv.Location = new System.Drawing.Point(111, 23);
            this.textMasv.Name = "textMasv";
            this.textMasv.Size = new System.Drawing.Size(62, 20);
            this.textMasv.TabIndex = 3;
            // 
            // textMalop
            // 
            this.textMalop.Location = new System.Drawing.Point(111, 49);
            this.textMalop.Name = "textMalop";
            this.textMalop.Size = new System.Drawing.Size(62, 20);
            this.textMalop.TabIndex = 4;
            // 
            // textTensv
            // 
            this.textTensv.Location = new System.Drawing.Point(111, 75);
            this.textTensv.Name = "textTensv";
            this.textTensv.Size = new System.Drawing.Size(141, 20);
            this.textTensv.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới Tính";
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "dd/MM/yyyy";
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.Location = new System.Drawing.Point(111, 101);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(158, 20);
            this.dateBirth.TabIndex = 8;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(111, 129);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 9;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(187, 129);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 10;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(311, 69);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(93, 26);
            this.buttonThem.TabIndex = 11;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 169);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(477, 200);
            this.dataGridView2.TabIndex = 12;
            // 
            // ThemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 369);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.radioNu);
            this.Controls.Add(this.radioNam);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTensv);
            this.Controls.Add(this.textMalop);
            this.Controls.Add(this.textMasv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemHS";
            this.Text = "ThemHS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMasv;
        private System.Windows.Forms.TextBox textMalop;
        private System.Windows.Forms.TextBox textTensv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}