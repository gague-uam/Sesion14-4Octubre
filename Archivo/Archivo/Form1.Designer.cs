namespace Archivo
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
            this.lblNames = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.dtpAge = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cbSex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(35, 20);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(52, 13);
            this.lblNames.TabIndex = 0;
            this.lblNames.Text = "Nombres:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(52, 48);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Edad:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(54, 80);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(33, 13);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "Nota:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(44, 113);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(45, 13);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "Genero:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(236, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(95, 77);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(236, 20);
            this.tbGrade.TabIndex = 7;
            // 
            // dtpAge
            // 
            this.dtpAge.Location = new System.Drawing.Point(95, 47);
            this.dtpAge.Name = "dtpAge";
            this.dtpAge.Size = new System.Drawing.Size(236, 20);
            this.dtpAge.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 24);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(47, 191);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(284, 116);
            this.dgvData.TabIndex = 10;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(100, 114);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(230, 21);
            this.cbSex.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 334);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpAge);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblNames);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.DateTimePicker dtpAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cbSex;
    }
}

