namespace BaiTap5_ConnectDB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxSelectClass = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox_selectString = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.comboBox_Sort = new System.Windows.Forms.ComboBox();
            this.comboBox_ASC_DESC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxSelectClass
            // 
            this.comboBoxSelectClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectClass.Location = new System.Drawing.Point(42, 24);
            this.comboBoxSelectClass.Name = "comboBoxSelectClass";
            this.comboBoxSelectClass.Size = new System.Drawing.Size(145, 24);
            this.comboBoxSelectClass.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(406, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox_selectString
            // 
            this.textBox_selectString.Location = new System.Drawing.Point(214, 24);
            this.textBox_selectString.Name = "textBox_selectString";
            this.textBox_selectString.Size = new System.Drawing.Size(170, 22);
            this.textBox_selectString.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(330, 430);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(510, 430);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 35);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(690, 430);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 35);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // comboBox_Sort
            // 
            this.comboBox_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sort.FormattingEnabled = true;
            this.comboBox_Sort.Items.AddRange(new object[] {
            "MSSV",
            "HoTenSV",
            "LopSH",
            "NgaySinh",
            "DTB"});
            this.comboBox_Sort.Location = new System.Drawing.Point(806, 432);
            this.comboBox_Sort.Name = "comboBox_Sort";
            this.comboBox_Sort.Size = new System.Drawing.Size(122, 24);
            this.comboBox_Sort.TabIndex = 8;
            // 
            // comboBox_ASC_DESC
            // 
            this.comboBox_ASC_DESC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ASC_DESC.FormattingEnabled = true;
            this.comboBox_ASC_DESC.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.comboBox_ASC_DESC.Location = new System.Drawing.Point(959, 432);
            this.comboBox_ASC_DESC.Name = "comboBox_ASC_DESC";
            this.comboBox_ASC_DESC.Size = new System.Drawing.Size(123, 24);
            this.comboBox_ASC_DESC.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 504);
            this.Controls.Add(this.comboBox_ASC_DESC);
            this.Controls.Add(this.comboBox_Sort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox_selectString);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxSelectClass);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox_selectString;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox comboBoxSelectClass;
        private System.Windows.Forms.ComboBox comboBox_Sort;
        private System.Windows.Forms.ComboBox comboBox_ASC_DESC;
    }
}

