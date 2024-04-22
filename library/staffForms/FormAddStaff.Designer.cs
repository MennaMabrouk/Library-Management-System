namespace LibraryManagementSystem_Amal.Forms.staffForms
{
    partial class FormAddStaff
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combDesignation = new System.Windows.Forms.ComboBox();
            this.combGender = new System.Windows.Forms.ComboBox();
            this.textStaffName = new System.Windows.Forms.TextBox();
            this.textFatherName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textContactNum = new System.Windows.Forms.TextBox();
            this.dgvstaff = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColContactNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.epAddStaff = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textContactNum);
            this.groupBox1.Controls.Add(this.textAddress);
            this.groupBox1.Controls.Add(this.textFatherName);
            this.groupBox1.Controls.Add(this.textStaffName);
            this.groupBox1.Controls.Add(this.combGender);
            this.groupBox1.Controls.Add(this.combDesignation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter New Staff";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Father Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ContactNum";
            // 
            // combDesignation
            // 
            this.combDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDesignation.FormattingEnabled = true;
            this.combDesignation.Location = new System.Drawing.Point(161, 32);
            this.combDesignation.Name = "combDesignation";
            this.combDesignation.Size = new System.Drawing.Size(296, 24);
            this.combDesignation.TabIndex = 6;
            // 
            // combGender
            // 
            this.combGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGender.FormattingEnabled = true;
            this.combGender.Items.AddRange(new object[] {
            "Select Gender",
            "Male",
            "Female"});
            this.combGender.Location = new System.Drawing.Point(161, 182);
            this.combGender.Name = "combGender";
            this.combGender.Size = new System.Drawing.Size(296, 24);
            this.combGender.TabIndex = 7;
            // 
            // textStaffName
            // 
            this.textStaffName.Location = new System.Drawing.Point(161, 76);
            this.textStaffName.Name = "textStaffName";
            this.textStaffName.Size = new System.Drawing.Size(296, 22);
            this.textStaffName.TabIndex = 8;
            // 
            // textFatherName
            // 
            this.textFatherName.Location = new System.Drawing.Point(161, 132);
            this.textFatherName.Name = "textFatherName";
            this.textFatherName.Size = new System.Drawing.Size(296, 22);
            this.textFatherName.TabIndex = 9;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(158, 278);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(296, 39);
            this.textAddress.TabIndex = 10;
            // 
            // textContactNum
            // 
            this.textContactNum.Location = new System.Drawing.Point(161, 234);
            this.textContactNum.Name = "textContactNum";
            this.textContactNum.Size = new System.Drawing.Size(293, 22);
            this.textContactNum.TabIndex = 11;
            // 
            // dgvstaff
            // 
            this.dgvstaff.AllowUserToAddRows = false;
            this.dgvstaff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDesignation,
            this.ColName,
            this.ColFatherName,
            this.ColGender,
            this.ColContactNum,
            this.ColAddress});
            this.dgvstaff.Location = new System.Drawing.Point(12, 389);
            this.dgvstaff.MultiSelect = false;
            this.dgvstaff.Name = "dgvstaff";
            this.dgvstaff.ReadOnly = true;
            this.dgvstaff.RowHeadersVisible = false;
            this.dgvstaff.RowHeadersWidth = 51;
            this.dgvstaff.RowTemplate.Height = 24;
            this.dgvstaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstaff.Size = new System.Drawing.Size(1262, 267);
            this.dgvstaff.TabIndex = 1;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // ColDesignation
            // 
            this.ColDesignation.HeaderText = "Designation";
            this.ColDesignation.MinimumWidth = 6;
            this.ColDesignation.Name = "ColDesignation";
            this.ColDesignation.ReadOnly = true;
            this.ColDesignation.Width = 125;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 125;
            // 
            // ColFatherName
            // 
            this.ColFatherName.HeaderText = "FatherName";
            this.ColFatherName.MinimumWidth = 6;
            this.ColFatherName.Name = "ColFatherName";
            this.ColFatherName.ReadOnly = true;
            this.ColFatherName.Width = 125;
            // 
            // ColGender
            // 
            this.ColGender.HeaderText = "Gender";
            this.ColGender.MinimumWidth = 6;
            this.ColGender.Name = "ColGender";
            this.ColGender.ReadOnly = true;
            this.ColGender.Width = 125;
            // 
            // ColContactNum
            // 
            this.ColContactNum.HeaderText = "ContactNum";
            this.ColContactNum.MinimumWidth = 6;
            this.ColContactNum.Name = "ColContactNum";
            this.ColContactNum.ReadOnly = true;
            this.ColContactNum.Width = 125;
            // 
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.MinimumWidth = 6;
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            this.ColAddress.Width = 125;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(547, 290);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(547, 241);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(547, 189);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(547, 141);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 12;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(759, 290);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(655, 290);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Enter Name";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(212, 355);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(184, 22);
            this.textSearch.TabIndex = 19;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // epAddStaff
            // 
            this.epAddStaff.ContainerControl = this;
            // 
            // FormAddStaff
            // 
            this.ClientSize = new System.Drawing.Size(1286, 668);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.dgvstaff);
            this.Controls.Add(this.groupBox1);
            
            this.Name = "FormAddStaff";
         
            this.Text = "library staff";
            this.Load += new System.EventHandler(this.FormAddStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textContactNum;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textFatherName;
        private System.Windows.Forms.TextBox textStaffName;
        private System.Windows.Forms.ComboBox combGender;
        private System.Windows.Forms.ComboBox combDesignation;
        private System.Windows.Forms.DataGridView dgvstaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContactNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ErrorProvider epAddStaff;
    }
}
